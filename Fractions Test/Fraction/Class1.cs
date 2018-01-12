using System;

namespace Fractions
{
    public class Fraction
    {
        public Fraction(int int1, int int2)
        {
             Numerator = int1;
             Denominator = int2;

            
        }

        public int Numerator { get; set; }
        public int Denominator  { get; set; }
        


        public Fraction plus(Fraction b)
        {
            double NewNumerator = Numerator + b.Numerator;
            double NewDenominator = Denominator + b.Denominator;
            Fraction total = new Fraction(Convert.ToInt32(NewNumerator), Convert.ToInt32(NewDenominator));
            return total;
        }
        public Fraction minus(Fraction b)
        {
            double NewNumerator = Numerator - b.Numerator;
            double NewDenominator = Denominator - b.Denominator;
            Fraction total = new Fraction(Convert.ToInt32(NewNumerator), Convert.ToInt32(NewDenominator));
            return total;
        }
        public Fraction multiplyBy(Fraction b)
        {
            double NewNumerator = Numerator * b.Numerator;
            double NewDenominator = Denominator * b.Denominator;
            Fraction total = new Fraction (Convert.ToInt32(NewNumerator) , Convert.ToInt32(NewDenominator));
            return total;
        }
        public Fraction divideBy(Fraction b)
        {
            double NewNumerator = Numerator / b.Numerator;
            double NewDenominator = Denominator / b.Denominator;
            Fraction total = new Fraction(Convert.ToInt32(NewNumerator), Convert.ToInt32(NewDenominator));
            return total;
        }

        public override string ToString()
        {
            return null;

        }


    }
}



