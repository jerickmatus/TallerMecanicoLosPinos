using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TallerMecanicoLosPinos.Persistencia;

namespace TallerMecanicoLosPinos.Persistencia
{
    public class RepositorioJson
    {
        private readonly string archivo =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "TallerMecanicoLosPinos",
                "datos.json"
            );

        private readonly JsonSerializerOptions opciones =
            new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters =
                {
                    new JsonStringEnumConverter()
                }
            };

        public DatosTaller Cargar()
        {
            if (!File.Exists(archivo))
                return new DatosTaller();

            try
            {
                string contenido = File.ReadAllText(archivo);

                return JsonSerializer.Deserialize<DatosTaller>(
                    contenido, opciones
                ) ?? new DatosTaller();
            }
            catch (JsonException ex)
            {
                string respaldo = archivo +
                    ".corrupto-" +
                    DateTime.Now.ToString("yyyyMMdd-HHmmss");

                File.Copy(archivo, respaldo, false);

                throw new InvalidDataException(
                    "El archivo de datos está dañado. " +
                    "Se conservó una copia en: " + respaldo,
                    ex
                );
            }
        }

        public void Guardar(DatosTaller datos)
        {
            string carpeta = Path.GetDirectoryName(archivo)!;

            Directory.CreateDirectory(carpeta);

            string temporal = archivo + ".tmp";

            try
            {
                string contenido =
                    JsonSerializer.Serialize(datos, opciones);

                File.WriteAllText(temporal, contenido);

                File.Move(temporal, archivo, true);
            }
            catch
            {
                if (File.Exists(temporal))
                    File.Delete(temporal);

                throw;
            }
        }
    }
}
