using System;
using System.Collections.Generic;
using System.Text;

namespace WithLoveApp.Interfaces
{
    public interface ITaxService
    {
        public double IrelandTax(double amount);
        public double BrazilTax(double amount);
    }
}
