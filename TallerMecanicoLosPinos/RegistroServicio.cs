using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanicoLosPinos
{
    public class RegistroServicio
    {
        public string Cliente { get; set; } = "";
        public string Patente { get; set; } = "";
        public string Vehiculo { get; set; } = "";
        public string Servicio { get; set; } = "";
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; } = "";
    }
}
