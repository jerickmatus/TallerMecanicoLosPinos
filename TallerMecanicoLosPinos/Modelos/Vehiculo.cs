using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanicoLosPinos.Modelos
{
    public class Vehiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ClienteId { get; set; }

        public string Patente { get; set; } = "";

        public string Marca { get; set; } = "";

        public string Modelo { get; set; } = "";

        public int Anio { get; set; }

        public bool Activo { get; set; } = true;
    }
}
