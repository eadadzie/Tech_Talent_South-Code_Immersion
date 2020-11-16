using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Decimals
    {
        public double Dec_num { get; private set; }

        public Decimals(double dec_num)
        {
            Dec_num = dec_num;
        }

        public Decimals Add(Decimals decimals)
        {
            return new Decimals(Dec_num + decimals.Dec_num);
        }

        public Decimals Subtract(Decimals decimals)
        {
            return new Decimals(Dec_num - decimals.Dec_num);
        }

        public Decimals Multiply(Decimals decimals)
        {
            return new Decimals(Dec_num * decimals.Dec_num);
        }

        public Decimals Divide(Decimals decimals)
        {
            if (decimals.Dec_num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Decimals(Dec_num / decimals.Dec_num);
        }
        
        public static Decimals operator +(Decimals x, Decimals y) => x.Add(y);

        public static Decimals operator -(Decimals x, Decimals y) => x.Subtract(y);

        public static Decimals operator *(Decimals x, Decimals y) => x.Multiply(y);

        public static Decimals operator /(Decimals x, Decimals y) => x.Divide(y);

        public static implicit operator Decimals(double decimals) => new Decimals(decimals);

        public static implicit operator double(Decimals decimals) => decimals.Dec_num;


        public override string ToString()
        {
            return $"Answer: {Dec_num}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            var decimals = (Decimals)obj;

            return decimals.Dec_num == Dec_num;
        }

    }
}
