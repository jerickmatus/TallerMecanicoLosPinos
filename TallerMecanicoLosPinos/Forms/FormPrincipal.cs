using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TallerMecanicoLosPinos.Modelos;
using TallerMecanicoLosPinos.Persistencia;
using TallerMecanicoLosPinos.Servicios;

namespace TallerMecanicoLosPinos.Forms
{
    public partial class FormPrincipal : Form
    {
        private readonly GestorTaller gestor;

        public FormPrincipal()
        {
            InitializeComponent();

            try
            {
                gestor = new GestorTaller();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(
                    ex.Message + "\nSe abrirá una sesión vacía.",
                    "Advertencia de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                gestor = new GestorTaller(new DatosTaller());
            }

            ConfigurarControles();
            ConectarEventos();
            RefrescarTodo();
        }

        

        private void ConfigurarControles()
        {
            ConfigurarGrilla(dgvClientes);
            ConfigurarGrilla(dgvVehiculos);
            ConfigurarGrilla(dgvOrdenes);
            ConfigurarGrilla(dgvReporteEstado);

            cmbClienteVehiculo.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbVehiculoOrden.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbNuevoEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbFiltroEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            nudAnioVehiculo.Minimum = 1950;
            nudAnioVehiculo.Maximum = DateTime.Now.Year + 1;
            nudAnioVehiculo.Value = 2020;

            nudCostoEstimado.Minimum = 0;
            nudCostoEstimado.Maximum = 1000000000;
            nudCostoEstimado.DecimalPlaces = 0;

            txtDescripcionFalla.Multiline = true;
            txtDiagnostico.Multiline = true;

            cmbNuevoEstado.DataSource =
                Enum.GetValues<EstadoOrden>();

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("Todos");

            foreach (EstadoOrden estado in Enum.GetValues<EstadoOrden>())
            {
                cmbFiltroEstado.Items.Add(estado);
            }

            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void ConfigurarGrilla(DataGridView grilla)
        {
            grilla.AutoGenerateColumns = true;
            grilla.ReadOnly = true;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.MultiSelect = false;

            grilla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grilla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grilla.RowHeadersVisible = false;
        }

        private void ConectarEventos()
        {
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            btnActualizarCliente.Click += btnActualizarCliente_Click;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            btnLimpiarCliente.Click += btnLimpiarCliente_Click;
            dgvClientes.CellClick += dgvClientes_CellClick;

            btnGuardarVehiculo.Click += btnGuardarVehiculo_Click;
            btnActualizarVehiculo.Click += btnActualizarVehiculo_Click;
            btnEliminarVehiculo.Click += btnEliminarVehiculo_Click;
            btnLimpiarVehiculo.Click += btnLimpiarVehiculo_Click;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;

            btnCrearOrden.Click += btnCrearOrden_Click;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            btnCancelarOrden.Click += btnCancelarOrden_Click;
            btnBuscarOrden.Click += btnBuscarOrden_Click;

            btnActualizarReporte.Click +=
                btnActualizarReporte_Click;
        }

        

        private void EjecutarOperacion(Action accion, string mensaje)
        {
            try
            {
                accion();

                RefrescarTodo();

                MessageBox.Show(
                    mensaje,
                    "Taller Mecánico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo completar la operación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void RefrescarTodo()
        {
            RefrescarClientes();
            RefrescarVehiculos();
            CargarCombos();
            RefrescarOrdenes();
            ActualizarReporte();
        }

        private void OcultarColumna(DataGridView grilla, string nombre)
        {
            if (grilla.Columns.Contains(nombre))
                grilla.Columns[nombre].Visible = false;
        }

        

        private void RefrescarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = gestor.Clientes.ToList();

            OcultarColumna(dgvClientes, "Id");
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            EjecutarOperacion(
                () =>
                {
                    gestor.AgregarCliente(new Cliente
                    {
                        Rut = txtRutCliente.Text,
                        NombreCompleto = txtNombreCliente.Text,
                        Telefono = txtTelefonoCliente.Text,
                        Correo = txtCorreoCliente.Text
                    });

                    LimpiarCliente();
                },
                "Cliente registrado correctamente."
            );
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is not Cliente c)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            var nuevo = new Cliente
            {
                Id = c.Id,
                Rut = txtRutCliente.Text,
                NombreCompleto = txtNombreCliente.Text,
                Telefono = txtTelefonoCliente.Text,
                Correo = txtCorreoCliente.Text
            };

            EjecutarOperacion(
                () => gestor.ActualizarCliente(nuevo),
                "Cliente actualizado correctamente."
            );
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is not Cliente c)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (MessageBox.Show(
                "¿Desea eliminar al cliente seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) != DialogResult.Yes)
                return;

            EjecutarOperacion(
                () => gestor.EliminarCliente(c.Id),
                "Cliente eliminado correctamente."
            );
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente c)
            {
                txtRutCliente.Text = c.Rut;
                txtNombreCliente.Text = c.NombreCompleto;
                txtTelefonoCliente.Text = c.Telefono;
                txtCorreoCliente.Text = c.Correo;
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
            dgvClientes.ClearSelection();
        }

        private void LimpiarCliente()
        {
            txtRutCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefonoCliente.Clear();
            txtCorreoCliente.Clear();
        }

        

        private void RefrescarVehiculos()
        {
            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = gestor.Vehiculos.ToList();

            OcultarColumna(dgvVehiculos, "Id");
            OcultarColumna(dgvVehiculos, "ClienteId");
        }

        private void CargarCombos()
        {
            cmbClienteVehiculo.DataSource = null;
            cmbClienteVehiculo.DisplayMember =
                nameof(Cliente.NombreCompleto);
            cmbClienteVehiculo.ValueMember =
                nameof(Cliente.Id);

            cmbClienteVehiculo.DataSource =
                gestor.Clientes.Where(x => x.Activo).ToList();

            cmbVehiculoOrden.DataSource = null;
            cmbVehiculoOrden.DisplayMember =
                nameof(Vehiculo.Patente);
            cmbVehiculoOrden.ValueMember =
                nameof(Vehiculo.Id);

            cmbVehiculoOrden.DataSource =
                gestor.Vehiculos.Where(x => x.Activo).ToList();
        }

        private void btnGuardarVehiculo_Click(object sender, EventArgs e)
        {
            if (cmbClienteVehiculo.SelectedValue is not Guid clienteId)
            {
                MessageBox.Show("Primero registre y seleccione un cliente.");
                return;
            }

            EjecutarOperacion(
                () =>
                {
                    gestor.AgregarVehiculo(new Vehiculo
                    {
                        ClienteId = clienteId,
                        Patente = txtPatenteVehiculo.Text,
                        Marca = txtMarcaVehiculo.Text,
                        Modelo = txtModeloVehiculo.Text,
                        Anio = (int)nudAnioVehiculo.Value
                    });

                    LimpiarVehiculo();
                },
                "Vehículo registrado correctamente."
            );
        }

        private void btnActualizarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow?.DataBoundItem is not Vehiculo v)
            {
                MessageBox.Show("Seleccione un vehículo.");
                return;
            }

            if (cmbClienteVehiculo.SelectedValue is not Guid clienteId)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            var nuevo = new Vehiculo
            {
                Id = v.Id,
                ClienteId = clienteId,
                Patente = txtPatenteVehiculo.Text,
                Marca = txtMarcaVehiculo.Text,
                Modelo = txtModeloVehiculo.Text,
                Anio = (int)nudAnioVehiculo.Value
            };

            EjecutarOperacion(
                () => gestor.ActualizarVehiculo(nuevo),
                "Vehículo actualizado correctamente."
            );
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow?.DataBoundItem is not Vehiculo v)
            {
                MessageBox.Show("Seleccione un vehículo.");
                return;
            }

            if (MessageBox.Show(
                "¿Desea eliminar el vehículo seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                return;

            EjecutarOperacion(
                () => gestor.EliminarVehiculo(v.Id),
                "Vehículo eliminado correctamente."
            );
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehiculos.CurrentRow?.DataBoundItem is Vehiculo v)
            {
                txtPatenteVehiculo.Text = v.Patente;
                txtMarcaVehiculo.Text = v.Marca;
                txtModeloVehiculo.Text = v.Modelo;
                nudAnioVehiculo.Value = v.Anio;

                cmbClienteVehiculo.SelectedValue = v.ClienteId;
            }
        }

        private void btnLimpiarVehiculo_Click(object sender, EventArgs e)
        {
            LimpiarVehiculo();
            dgvVehiculos.ClearSelection();
        }

        private void LimpiarVehiculo()
        {
            txtPatenteVehiculo.Clear();
            txtMarcaVehiculo.Clear();
            txtModeloVehiculo.Clear();
            nudAnioVehiculo.Value = 2020;
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            if (cmbVehiculoOrden.SelectedValue is not Guid vehiculoId)
            {
                MessageBox.Show("Debe registrar y seleccionar un vehículo.");
                return;
            }

            EjecutarOperacion(
                () =>
                {
                    gestor.CrearOrden(
                        vehiculoId,
                        txtTipoServicio.Text,
                        txtDescripcionFalla.Text,
                        txtDiagnostico.Text,
                        txtMecanico.Text,
                        nudCostoEstimado.Value
                    );

                    txtTipoServicio.Clear();
                    txtDescripcionFalla.Clear();
                    txtDiagnostico.Clear();
                    txtMecanico.Clear();
                    nudCostoEstimado.Value = 0;
                },
                "Orden de servicio creada correctamente."
            );
        }

        private Guid? ObtenerOrdenSeleccionada()
        {
            if (dgvOrdenes.CurrentRow == null)
                return null;

            object? valor =
                dgvOrdenes.CurrentRow.Cells["Id"].Value;

            return valor is Guid id ? id : null;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            Guid? id = ObtenerOrdenSeleccionada();

            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una orden.");
                return;
            }

            if (cmbNuevoEstado.SelectedItem is not EstadoOrden estado)
                return;

            EjecutarOperacion(
                () => gestor.CambiarEstado(id.Value, estado),
                "Estado de la orden actualizado."
            );
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            Guid? id = ObtenerOrdenSeleccionada();

            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una orden.");
                return;
            }

            if (MessageBox.Show(
                "¿Desea cancelar esta orden?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                return;

            EjecutarOperacion(
                () => gestor.CambiarEstado(id.Value, EstadoOrden.Cancelada),
                "Orden cancelada correctamente."
            );
        }

        private EstadoOrden? ObtenerFiltroEstado()
        {
            if (cmbFiltroEstado.SelectedItem is EstadoOrden estado)
                return estado;

            return null;
        }

        private void RefrescarOrdenes()
        {
            var tabla = new DataTable();

            tabla.Columns.Add("Id", typeof(Guid));
            tabla.Columns.Add("Patente", typeof(string));
            tabla.Columns.Add("Cliente", typeof(string));
            tabla.Columns.Add("Servicio", typeof(string));
            tabla.Columns.Add("FechaIngreso", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("CostoEstimado", typeof(decimal));

            var ordenes = gestor.BuscarOrdenes(
                txtBuscarOrden.Text,
                ObtenerFiltroEstado()
            );

            foreach (var orden in ordenes)
            {
                var vehiculo = gestor.ObtenerVehiculo(orden.VehiculoId);

                var cliente = vehiculo == null
                    ? null
                    : gestor.ObtenerCliente(vehiculo.ClienteId);

                tabla.Rows.Add(
                    orden.Id,
                    vehiculo?.Patente ?? "No disponible",
                    cliente?.NombreCompleto ?? "No disponible",
                    orden.TipoServicio,
                    orden.FechaIngreso.ToString("dd/MM/yyyy HH:mm"),
                    orden.Estado.ToString(),
                    orden.CostoEstimado
                );
            }

            dgvOrdenes.DataSource = tabla;

            OcultarColumna(dgvOrdenes, "Id");
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            RefrescarOrdenes();
        }

        private void ActualizarReporte()
        {
            int total = gestor.Ordenes.Count;

            int activas = gestor.Ordenes.Count(x =>
                x.Estado != EstadoOrden.Entregada &&
                x.Estado != EstadoOrden.Cancelada);

            int entregadas = gestor.Ordenes.Count(x =>
                x.Estado == EstadoOrden.Entregada);

            lblTotalOrdenes.Text = $"Total de órdenes: {total}";
            lblOrdenesActivas.Text = $"Órdenes activas: {activas}";
            lblOrdenesEntregadas.Text = $"Órdenes entregadas: {entregadas}";

            var tabla = new DataTable();

            tabla.Columns.Add("Estado", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("Costo total estimado", typeof(decimal));

            foreach (EstadoOrden estado in Enum.GetValues<EstadoOrden>())
            {
                var registros = gestor.Ordenes
                    .Where(x => x.Estado == estado)
                    .ToList();

                tabla.Rows.Add(
                    estado.ToString(),
                    registros.Count,
                    registros.Sum(x => x.CostoEstimado)
                );
            }

            dgvReporteEstado.DataSource = tabla;
        }

        private void btnActualizarReporte_Click(object sender, EventArgs e)
        {
            ActualizarReporte();

            MessageBox.Show("Reporte actualizado correctamente.");
        }
    }
}

