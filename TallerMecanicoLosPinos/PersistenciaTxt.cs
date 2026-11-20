using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace TallerMecanicoLosPinos
{
    internal class PersistenciaTxt
    {
        private static readonly string Carpeta =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "TallerMecanico");

        private static string Archivo =>
            Path.Combine(Carpeta, "registros.txt");


        
        public static BindingList<RegistroServicio> Cargar()
        {
            BindingList<RegistroServicio> lista =
                new BindingList<RegistroServicio>();

            if (!File.Exists(Archivo))
                return lista;

            string[] lineas = File.ReadAllLines(Archivo);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] datos = linea.Split('|');

                if (datos.Length == 6)
                {
                    DateTime fecha;

                    bool fechaValida = DateTime.TryParseExact(
                        datos[4],
                        "yyyy-MM-dd",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out fecha);

                    if (fechaValida)
                    {
                        RegistroServicio registro =
                            new RegistroServicio();

                        registro.Cliente = datos[0];
                        registro.Patente = datos[1];
                        registro.Vehiculo = datos[2];
                        registro.Servicio = datos[3];
                        registro.Fecha = fecha;
                        registro.Observaciones = datos[5];

                        lista.Add(registro);
                    }
                }
            }

            return lista;
        }


        
        public static void Guardar(
            BindingList<RegistroServicio> registros)
        {
            Directory.CreateDirectory(Carpeta);

            List<string> lineas = new List<string>();

            foreach (RegistroServicio registro in registros)
            {
                string linea =
                    PrepararTexto(registro.Cliente) + "|" +
                    PrepararTexto(registro.Patente) + "|" +
                    PrepararTexto(registro.Vehiculo) + "|" +
                    PrepararTexto(registro.Servicio) + "|" +
                    registro.Fecha.ToString("yyyy-MM-dd") + "|" +
                    PrepararTexto(registro.Observaciones);

                lineas.Add(linea);
            }

            File.WriteAllLines(Archivo, lineas);
        }


        
        private static string PrepararTexto(string texto)
        {
            return (texto ?? "")
                .Replace("|", "/")
                .Replace("\r", " ")
                .Replace("\n", " ");
        }
    }
}
