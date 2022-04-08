using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Persona
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string dni { get; private set; }
        public DateTime fechaNacimiento { get; private set; }
        public string ciudad { get; private set; }
        public double ingresosNetosAnuales { get; private set; }
    }
}
