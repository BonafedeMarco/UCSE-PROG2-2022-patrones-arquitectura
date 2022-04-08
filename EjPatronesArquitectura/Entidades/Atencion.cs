using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Atencion
    {
        public int numero { get; private set; }
        public DateTime fecha { get; private set; }
        public Enfermedad enfermedad { get; private set; }
        public Persona cliente { get; private set; }
    }
}
