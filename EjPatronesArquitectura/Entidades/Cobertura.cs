using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cobertura
    {
        public int numero { get; private set; }
        public string descripcion { get; private set; }
        public string empresa { get; private set; }
        public short maximoFamiliares { get; private set; }
        public double costoBase { get; private set; }
        public List<Enfermedad> enfermedades { get; private set; }

        // Punto 1
        public abstract double CalcularCosto();
    }
}
