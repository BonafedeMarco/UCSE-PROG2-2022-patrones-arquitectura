using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maxima : Cobertura
    {
        // Punto 1
        public override double CalcularCosto()
        {
            double costo = 0;
            foreach (Enfermedad enfermedad in enfermedades)
            {
                costo += enfermedad.costo;
            }
            return costo;
        }
    }
}
