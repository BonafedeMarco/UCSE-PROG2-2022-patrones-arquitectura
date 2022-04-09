using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Enfermedad
    {
        public Enumeradores.TiposEnfermedad tipo { get; private set; }
        public string nombre { get; private set; }
        public double costo { get; private set; }
    }
}
