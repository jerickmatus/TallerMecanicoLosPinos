using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanicoLosPinos.Modelos;


namespace TallerMecanicoLosPinos.Modelos
{
    public class OrdenServicio
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid VehiculoId { get; set; }

        public DateTime FechaIngreso { get; set; } = DateTime.Now;

        public string TipoServicio { get; set; } = "";

        public string DescripcionFalla { get; set; } = "";

        public string Diagnostico { get; set; } = "";

        public string MecanicoAsignado { get; set; } = "";

        public EstadoOrden Estado { get; set; } =
            EstadoOrden.Recibida;

        public decimal CostoEstimado { get; set; }

        public DateTime? FechaEntrega { get; set; }
    }
}
