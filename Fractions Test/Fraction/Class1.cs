using System;

namespace Fractions
{
    public class Fraction
    {
        public Fraction(int int1, int int2)
        {
            int Numerator = int1;
            int Denominator = int2;

            
        }

        public int int1 { get; set; }
        public int int2 { get; set; }
        


        public double plus(Fraction a, Fraction b)
        {
            double fraction1 = a.int1 / a.int2;
            double fraction2 = b.int1 / b.int2;
            var total = fraction1 + fraction2;
            return total;
        }
        public double minus(Fraction b)
        {
            var total = b.int1 - b.int2;
            return total;
        }
        public double multiplyBy(Fraction b)
        {
            var total = b.int1 * b.int2;
            return total;
        }
        public double divideBy(Fraction b)
        {
            var total = b.int1 / b.int2;
            return total;
        }

        public override string ToString()
        {
            return null;

        }


    }
}



