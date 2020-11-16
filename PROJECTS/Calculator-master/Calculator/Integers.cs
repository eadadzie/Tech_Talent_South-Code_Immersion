using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Calculator
{
    public class Integers
    {
        public int Int_num { get; private set; }

        public Integers(int int_num)
        {
            Int_num = int_num;
        }

        public Integers Add(Integers integer)
        {
            return new Integers(Int_num + integer.Int_num);
        }

        public Integers Subtract(Integers integer)
        {
            return new Integers(Int_num - integer.Int_num);
        }

        public Integers Multiply(Integers integer)
        {
            return new Integers(Int_num * integer.Int_num);
        }

        public Integers Divide(Integers integer)
        {
            if (integer.Int_num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Integers(Int_num / integer.Int_num);
        }

        public static Integers operator +(Integers x, Integers y) => x.Add(y);

        public static Integers operator -(Integers x, Integers y) => x.Subtract(y);

        public static Integers operator *(Integers x, Integers y) => x.Multiply(y);

        public static Integers operator /(Integers x, Integers y) => x.Divide(y);

        public static implicit operator Integers(int integer) => new Integers(integer);

        public static implicit operator int(Integers integer) => integer.Int_num;


        public override string ToString()
        {
            return $"Integer: {Int_num}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            var integer = (Integers)obj;

            return integer.Int_num == Int_num;
        }
    }
}
