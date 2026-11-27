using System;
using System.Collections.Generic;
using System.Text;

using TallerMecanicoLosPinos.Modelos;
using TallerMecanicoLosPinos.Persistencia;


namespace TallerMecanicoLosPinos.Servicios
{
    public class GestorTaller
    {
        private readonly DatosTaller datos;
        private readonly RepositorioJson repositorio;

        public IReadOnlyList<Cliente> Clientes => datos.Clientes;
        public IReadOnlyList<Vehiculo> Vehiculos => datos.Vehiculos;
        public IReadOnlyList<OrdenServicio> Ordenes => datos.Ordenes;

        public GestorTaller()
        {
            repositorio = new RepositorioJson();
            datos = repositorio.Cargar();
        }

        public GestorTaller(DatosTaller datosIniciales)
        {
            repositorio = new RepositorioJson();
            datos = datosIniciales;
        }

        private void GuardarCambio(Action aplicar, Action revertir)
        {
            aplicar();

            try
            {
                repositorio.Guardar(datos);
            }
            catch
            {
                revertir();
                throw;
            }
        }

        private static string Normalizar(string texto)
        {
            return new string(
                texto.Where(char.IsLetterOrDigit).ToArray()
            ).ToUpperInvariant();
        }

        public Cliente? ObtenerCliente(Guid id)
        {
            return datos.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public Vehiculo? ObtenerVehiculo(Guid id)
        {
            return datos.Vehiculos.FirstOrDefault(x => x.Id == id);
        }

        // CLIENTES

        private void ValidarCliente(Cliente c)
        {
            string rut = Normalizar(c.Rut);

            if (rut.Length < 8 || rut.Length > 9 ||
                !rut[..^1].All(char.IsDigit) ||
                !(char.IsDigit(rut[^1]) || rut[^1] == 'K'))
                throw new InvalidOperationException("El RUT no tiene un formato válido.");

            if (string.IsNullOrWhiteSpace(c.NombreCompleto))
                throw new InvalidOperationException("Ingrese el nombre del cliente.");

            string numeros = new string(
                c.Telefono.Where(char.IsDigit).ToArray()
            );

            if (numeros.Length < 8 || numeros.Length > 12)
                throw new InvalidOperationException("El teléfono no es válido.");

            if (string.IsNullOrWhiteSpace(c.Correo) ||
                !c.Correo.Contains('@') ||
                !c.Correo.Contains('.'))
                throw new InvalidOperationException("El correo no es válido.");
        }

        public void AgregarCliente(Cliente c)
        {
            ValidarCliente(c);

            if (datos.Clientes.Any(
                x => Normalizar(x.Rut) == Normalizar(c.Rut)))
                throw new InvalidOperationException("El RUT ya está registrado.");

            GuardarCambio(
                () => datos.Clientes.Add(c),
                () => datos.Clientes.Remove(c)
            );
        }

        public void ActualizarCliente(Cliente nuevo)
        {
            var actual = ObtenerCliente(nuevo.Id);

            if (actual == null)
                throw new InvalidOperationException("Cliente no encontrado.");

            ValidarCliente(nuevo);

            if (datos.Clientes.Any(
                x => x.Id != nuevo.Id &&
                Normalizar(x.Rut) == Normalizar(nuevo.Rut)))
                throw new InvalidOperationException("El RUT pertenece a otro cliente.");

            string rut = actual.Rut;
            string nombre = actual.NombreCompleto;
            string telefono = actual.Telefono;
            string correo = actual.Correo;

            GuardarCambio(
                () =>
                {
                    actual.Rut = nuevo.Rut.Trim();
                    actual.NombreCompleto = nuevo.NombreCompleto.Trim();
                    actual.Telefono = nuevo.Telefono.Trim();
                    actual.Correo = nuevo.Correo.Trim();
                },
                () =>
                {
                    actual.Rut = rut;
                    actual.NombreCompleto = nombre;
                    actual.Telefono = telefono;
                    actual.Correo = correo;
                }
            );
        }

        public void EliminarCliente(Guid id)
        {
            var cliente = ObtenerCliente(id);

            if (cliente == null)
                throw new InvalidOperationException("Cliente no encontrado.");

            if (datos.Vehiculos.Any(x => x.ClienteId == id))
                throw new InvalidOperationException(
                    "No se puede eliminar un cliente que tiene vehículos registrados."
                );

            int indice = datos.Clientes.IndexOf(cliente);

            GuardarCambio(
                () => datos.Clientes.Remove(cliente),
                () => datos.Clientes.Insert(indice, cliente)
            );
        }

        // VEHÍCULOS

        public void AgregarVehiculo(Vehiculo v)
        {
            ValidarVehiculo(v);

            if (datos.Vehiculos.Any(
                x => Normalizar(x.Patente) == Normalizar(v.Patente)))
                throw new InvalidOperationException("La patente ya está registrada.");

            GuardarCambio(
                () => datos.Vehiculos.Add(v),
                () => datos.Vehiculos.Remove(v)
            );
        }

        private void ValidarVehiculo(Vehiculo v)
        {
            var cliente = ObtenerCliente(v.ClienteId);

            if (cliente == null || !cliente.Activo)
                throw new InvalidOperationException(
                    "Debe seleccionar un cliente activo."
                );

            if (string.IsNullOrWhiteSpace(v.Patente))
                throw new InvalidOperationException("Ingrese la patente.");

            if (string.IsNullOrWhiteSpace(v.Marca) ||
                string.IsNullOrWhiteSpace(v.Modelo))
                throw new InvalidOperationException("Ingrese marca y modelo.");

            if (v.Anio < 1950 || v.Anio > DateTime.Now.Year + 1)
                throw new InvalidOperationException("El año del vehículo no es válido.");
        }

        public void ActualizarVehiculo(Vehiculo nuevo)
        {
            var actual = ObtenerVehiculo(nuevo.Id);

            if (actual == null)
                throw new InvalidOperationException("Vehículo no encontrado.");

            ValidarVehiculo(nuevo);

            if (datos.Vehiculos.Any(
                x => x.Id != nuevo.Id &&
                Normalizar(x.Patente) == Normalizar(nuevo.Patente)))
                throw new InvalidOperationException("La patente ya pertenece a otro vehículo.");

            Guid clienteAnterior = actual.ClienteId;
            string patenteAnterior = actual.Patente;
            string marcaAnterior = actual.Marca;
            string modeloAnterior = actual.Modelo;
            int anioAnterior = actual.Anio;

            GuardarCambio(
                () =>
                {
                    actual.ClienteId = nuevo.ClienteId;
                    actual.Patente = nuevo.Patente.Trim().ToUpperInvariant();
                    actual.Marca = nuevo.Marca.Trim();
                    actual.Modelo = nuevo.Modelo.Trim();
                    actual.Anio = nuevo.Anio;
                },
                () =>
                {
                    actual.ClienteId = clienteAnterior;
                    actual.Patente = patenteAnterior;
                    actual.Marca = marcaAnterior;
                    actual.Modelo = modeloAnterior;
                    actual.Anio = anioAnterior;
                }
            );
        }

        public void EliminarVehiculo(Guid id)
        {
            var vehiculo = ObtenerVehiculo(id);

            if (vehiculo == null)
                throw new InvalidOperationException("Vehículo no encontrado.");

            if (datos.Ordenes.Any(x => x.VehiculoId == id))
                throw new InvalidOperationException(
                    "No se puede eliminar un vehículo con historial de órdenes."
                );

            int indice = datos.Vehiculos.IndexOf(vehiculo);

            GuardarCambio(
                () => datos.Vehiculos.Remove(vehiculo),
                () => datos.Vehiculos.Insert(indice, vehiculo)
            );
        }

        // ÓRDENES DE SERVICIO

        public OrdenServicio CrearOrden(
            Guid vehiculoId,
            string servicio,
            string falla,
            string diagnostico,
            string mecanico,
            decimal costo)
        {
            var vehiculo = ObtenerVehiculo(vehiculoId);

            if (vehiculo == null || !vehiculo.Activo)
                throw new InvalidOperationException("Vehículo no disponible.");

            if (datos.Ordenes.Any(
                x => x.VehiculoId == vehiculoId &&
                x.Estado != EstadoOrden.Entregada &&
                x.Estado != EstadoOrden.Cancelada))
                throw new InvalidOperationException(
                    "Este vehículo ya tiene una orden activa."
                );

            if (string.IsNullOrWhiteSpace(servicio) ||
                string.IsNullOrWhiteSpace(falla) ||
                string.IsNullOrWhiteSpace(mecanico))
                throw new InvalidOperationException(
                    "Complete el servicio, la falla y el mecánico."
                );

            if (costo < 0)
                throw new InvalidOperationException("El costo no puede ser negativo.");

            var orden = new OrdenServicio
            {
                VehiculoId = vehiculoId,
                TipoServicio = servicio.Trim(),
                DescripcionFalla = falla.Trim(),
                Diagnostico = diagnostico.Trim(),
                MecanicoAsignado = mecanico.Trim(),
                CostoEstimado = costo,
                FechaIngreso = DateTime.Now,
                Estado = EstadoOrden.Recibida
            };

            GuardarCambio(
                () => datos.Ordenes.Add(orden),
                () => datos.Ordenes.Remove(orden)
            );

            return orden;
        }

        public void CambiarEstado(Guid ordenId, EstadoOrden nuevoEstado)
        {
            var orden = datos.Ordenes.FirstOrDefault(x => x.Id == ordenId);

            if (orden == null)
                throw new InvalidOperationException("Orden no encontrada.");

            if (!TransicionPermitida(orden.Estado, nuevoEstado))
                throw new InvalidOperationException(
                    $"No se permite pasar de {orden.Estado} a {nuevoEstado}."
                );

            EstadoOrden estadoAnterior = orden.Estado;
            DateTime? fechaAnterior = orden.FechaEntrega;

            GuardarCambio(
                () =>
                {
                    orden.Estado = nuevoEstado;

                    if (nuevoEstado == EstadoOrden.Entregada)
                        orden.FechaEntrega = DateTime.Now;
                },
                () =>
                {
                    orden.Estado = estadoAnterior;
                    orden.FechaEntrega = fechaAnterior;
                }
            );
        }

        private bool TransicionPermitida(
            EstadoOrden actual,
            EstadoOrden nuevo)
        {
            return actual switch
            {
                EstadoOrden.Recibida =>
                    nuevo == EstadoOrden.EnDiagnostico ||
                    nuevo == EstadoOrden.Cancelada,

                EstadoOrden.EnDiagnostico =>
                    nuevo == EstadoOrden.EsperandoRepuestos ||
                    nuevo == EstadoOrden.EnReparacion ||
                    nuevo == EstadoOrden.Cancelada,

                EstadoOrden.EsperandoRepuestos =>
                    nuevo == EstadoOrden.EnReparacion ||
                    nuevo == EstadoOrden.Cancelada,

                EstadoOrden.EnReparacion =>
                    nuevo == EstadoOrden.EsperandoRepuestos ||
                    nuevo == EstadoOrden.ListaParaRetiro ||
                    nuevo == EstadoOrden.Cancelada,

                EstadoOrden.ListaParaRetiro =>
                    nuevo == EstadoOrden.Entregada,

                _ => false
            };
        }

        public List<OrdenServicio> BuscarOrdenes(
            string busqueda,
            EstadoOrden? estado)
        {
            IEnumerable<OrdenServicio> resultado = datos.Ordenes;

            if (estado.HasValue)
                resultado = resultado.Where(x => x.Estado == estado.Value);

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                string texto = busqueda.Trim();

                resultado = resultado.Where(o =>
                {
                    var vehiculo = ObtenerVehiculo(o.VehiculoId);
                    var cliente = vehiculo == null
                        ? null
                        : ObtenerCliente(vehiculo.ClienteId);

                    return
                        (vehiculo?.Patente.Contains(
                            texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (cliente?.NombreCompleto.Contains(
                            texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        o.TipoServicio.Contains(
                            texto, StringComparison.OrdinalIgnoreCase) ||
                        o.DescripcionFalla.Contains(
                            texto, StringComparison.OrdinalIgnoreCase);
                });
            }

            return resultado
                .OrderByDescending(x => x.FechaIngreso)
                .ToList();
        }
    }
}
