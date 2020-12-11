using System;
using System.Collections.Generic;
using System.Text;
using WithLoveApp.Interfaces;

namespace WithLoveApp.Services
{
    public class ServicoEntrega : IServicoEntrega
    {
        public double EntregaIrlanda(double distancia)
        {
            double pricePerTwoKm = 4;
            double twoKm = 2;
            var total = 0.0;

            if (distancia <= twoKm)
            {
                total = pricePerTwoKm;
            }
            else
            {
                total = distancia * pricePerTwoKm;
            }
            
            return total;
        }

        public double EntregaBrasil(double distancia)
        {
            double pricePerTwoKm = 4;
            double twoKm = 2;
            var total = 0.0;

            if (distancia <= twoKm)
            {
                total = pricePerTwoKm;
            }
            else
            {
                total = distancia * pricePerTwoKm;
            }

            return total;
        }
    }
}
