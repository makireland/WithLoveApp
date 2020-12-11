using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WithLoveApp.Interfaces;

namespace WithLoveApp.Services
{
    public class TaxService : ITaxService
    {
        public double IrelandTax(double amount)
        {
            const double taxValue = 21;
            var tax = (amount * taxValue) / 100;
            return tax;
        }

        public double BrazilTax(double amount)
        {
            const double taxValue = 23;
            var tax = (amount * taxValue) / 100;
            return tax;
        }
    }
}
