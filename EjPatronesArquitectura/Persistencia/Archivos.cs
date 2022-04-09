using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Persistencia
{
    public class Archivos
    {
        private bool VerificarExistenciaArchivo(string archivo)
        {
            if (!Directory.Exists("DatosLocales"))
                Directory.CreateDirectory("DatosLocales");

            string filepath = Path.Combine(Directory.GetCurrentDirectory(), $@"DatosLocales\{archivo}.json");
            if (!File.Exists(filepath))
                File.Create(filepath).Close();

            return true;
        }
    }
}
