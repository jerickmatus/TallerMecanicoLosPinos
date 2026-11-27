using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanicoLosPinos.Modelos;

namespace TallerMecanicoLosPinos.Persistencia
{
    public class DatosTaller
    {
        public List<Cliente> Clientes { get; set; } = new();

        public List<Vehiculo> Vehiculos { get; set; } = new();

        public List<OrdenServicio> Ordenes { get; set; } = new();
    }
}