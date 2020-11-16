using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Calculator
{
    public class Complex
    {
        public double Real { get; private set; }
        public double Imag { get; private set; }

        public Complex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public Complex Add(Complex complex)
        {
            return new Complex(Real + complex.Real, Imag + complex.Imag);
        }

        public Complex Subtract(Complex complex)
        {
            return new Complex(Real - complex.Real, Imag - complex.Imag);
        }

        public Complex Multiply(Complex complex)
        {
            return new Complex((Real * complex.Real) - (Imag * complex.Imag), (Imag * complex.Real) + (Real * complex.Imag));
        }

        public Complex TrueDiv(Complex complex)
        {
            var res = Math.Pow(complex.Real, 2) + Math.Pow(complex.Imag, 2);

            return new Complex((Real * complex.Real + Imag * complex.Imag) / res, 
                                (Imag * complex.Real - Real * complex.Imag) / res);
        }

        public static Complex operator +(Complex x, Complex y) => x.Add(y);
        public static Complex operator -(Complex x, Complex y) => x.Subtract(y);
        public static Complex operator *(Complex x, Complex y) => x.Multiply(y);
        public static Complex operator /(Complex x, Complex y) => x.TrueDiv(y);

        public static implicit operator Complex(double complex) => new Complex(1.00, 1.00);

        public static implicit operator double(Complex complex) => complex.Real + complex.Imag;

        public override string ToString()
        {
            string result = "";

            if (Imag == 0)
            {
                result = $"{Math.Round(Real, 2)} + 0.00i";
            }
            else if (Real == 0)
            {
                if (Imag >= 0)
                {
                    result = $"00.00 + {Math.Round(Imag, 2)}i";
                }
                else
                {
                    result = $"00.00 - {Math.Abs(Math.Round(Imag, 2))}i";
                }
            }
            else if (Imag > 0)
            {
                result = $"{Math.Round(Real, 2)} + {Math.Round(Imag, 2)}i";
            }
            else
            {
                result = $"{Math.Round(Real, 2)} - {Math.Abs(Math.Round(Imag, 2))}i";
            }

            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            var complex = (Complex)obj;

            return Real == complex.Real && Imag == complex.Imag;
        }
    }
}
