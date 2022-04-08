using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Normal : Cobertura
    {
        // Punto 1
        public override double CalcularCosto()
        {
            List<double> costos = enfermedades.Select(x => x.costo).ToList();
            return costoBase + costos.Average();
        }
    }
}
