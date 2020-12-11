using System;
using System.Collections.Generic;
using System.Text;

namespace WithLoveApp.Interfaces
{
    public interface IServicoEntrega
    {
        public double EntregaIrlanda(double distancia);
        public double EntregaBrasil(double distancia);
    }
}
