using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkcjeFinansowe
{
    public class Inwestycja
    {
        public double wartoscPrzyszla(double x, double y)
        {
            var result = x + (x * y);
            if(result < 0)
            {
                throw new ArithmeticException("Liczba jest ujemna");
            }
            return x + (x * y);
        }

        public double obliczStope(double x, double y)
        {
            return x + (x * y);
        }
    }
}
