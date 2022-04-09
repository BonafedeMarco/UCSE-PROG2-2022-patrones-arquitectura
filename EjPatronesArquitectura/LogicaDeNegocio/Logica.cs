using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace LogicaDeNegocio
{
    public class Logica
    {
        private Cobertura ObtenerCoberturaPorID(int numCobertura)
        {
            return null;
        }

        private Persona ObtenerClientePorDNI(string dni)
        {
            return null;
        }

        // Punto 2
        public bool DeterminarAccesoACobertura(int numCobertura, string dniCliente)
        {
            Cobertura cobertura = ObtenerCoberturaPorID(numCobertura);
            Persona persona = ObtenerClientePorDNI(dniCliente);
            if (cobertura.CalcularCosto() <= persona.ingresosNetosAnuales)
            {
                return true;
            }
            return false;
        }
    }
}
