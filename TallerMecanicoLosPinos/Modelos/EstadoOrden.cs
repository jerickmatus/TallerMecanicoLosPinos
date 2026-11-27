using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanicoLosPinos.Modelos
{
    public enum EstadoOrden
    {
        Recibida,
        EnDiagnostico,
        EsperandoRepuestos,
        EnReparacion,
        ListaParaRetiro,
        Entregada,
        Cancelada
    }
}
