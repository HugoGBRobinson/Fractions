using System;


namespace Fractions
{
    public class Fraction
    {
        public Fraction(int Num1, int Num2)
        {
             Numerator = Num1;
             Denominator = Num2;
            var total = Numerator / Denominator;
            
        }

        public int Numerator { get; set; }
        public int Denominator  { get; set; }



        public Fraction plus(Fraction b)
        {

            int NewDenominator = Denominator * b.Denominator;
            int num1 = Numerator * b.Denominator;
            int num2 = b.Numerator * Denominator;
            int NewNumerator = num1 + num2;
            var NewFunction = new Fraction(NewNumerator, NewDenominator);
            return NewFunction;
        }
        public Fraction minus(Fraction b)
        {
            int NewDenominator = Denominator * b.Denominator;
            int num1 = Numerator * b.Denominator;
            int num2 = b.Numerator * Denominator;
            int NewNumerator = num1 - num2;
            return new Fraction(NewNumerator, NewDenominator);
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
            double NewDenominator = Denominator * b.Denominator;
            Fraction total = new Fraction(Convert.ToInt32(NewNumerator), Convert.ToInt32(NewDenominator));
            return total;
        }

        public override string ToString()
        {
            return null;

        }


    }
}



