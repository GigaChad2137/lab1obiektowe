using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;









namespace lab1obiektowe
{
    public class Fraction
    {
        private double numerator { get; set; }      //licznik
        private double denominator { get; set; }     //mianownik

        public double p_denominator { get => denominator; }
        public double p_numerator { get => numerator; }

        //konstruktor
        public Fraction()
        {
            numerator = 1;
            denominator = 2;
        }

        //konstruktor dwu argumentowy
        public Fraction(double x, double y)
        {
            numerator = x;
            denominator = y;
        }
        //konstruktor kopiujący
        public Fraction(Fraction previousFraction)
        {
            numerator = previousFraction.numerator;
            denominator = previousFraction.denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static Fraction operator +(Fraction f1) => f1;
        public static Fraction operator -(Fraction f1) => new Fraction(-f1.numerator, f1.denominator);

        public static Fraction operator +(Fraction f1, Fraction f2) => new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator + f2.denominator);


        public bool IEquatable(Fraction other)
        {
            return denominator == other.denominator && denominator == other.denominator;
        }

        public double IComparable(Fraction other)
        {
            return (this - other).numerator;
        }
        /// zaokloglanie w dol

        public double ToIntFloor()
        {
            return (double)(denominator / denominator);
        }
        ///zaokloglanie w gore
        public double ToIntCeil()
        {

            return (double)Math.Ceiling((double)denominator / (double)denominator);
        }
    }
}
