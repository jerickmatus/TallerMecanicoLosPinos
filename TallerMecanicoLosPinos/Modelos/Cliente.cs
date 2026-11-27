using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanicoLosPinos.Modelos
{
    public class Cliente
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Rut { get; set; } = "";

        public string NombreCompleto { get; set; } = "";

        public string Telefono { get; set; } = "";

        public string Correo { get; set; } = "";

        public bool Activo { get; set; } = true;
    }
}
