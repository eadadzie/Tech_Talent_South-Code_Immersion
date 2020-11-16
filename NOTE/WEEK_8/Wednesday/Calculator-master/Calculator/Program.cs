using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneHalf = new Fraction(1, 2);
            var oneFourth = new Fraction(1, 4);
            Console.WriteLine(oneHalf.ToString());
            Console.WriteLine(oneFourth.ToString());

            Console.WriteLine(oneHalf.Add(oneFourth).ToString());
            Console.WriteLine((oneHalf + oneFourth).ToString());

            Console.WriteLine(oneHalf.Subtract(oneFourth).ToString());
            Console.WriteLine((oneHalf - oneFourth).ToString());

            Console.WriteLine(oneHalf.Multiply(oneFourth).ToString());
            Console.WriteLine((oneHalf * oneFourth).ToString());

            Console.WriteLine(oneHalf.Divide(oneFourth).ToString());
            Console.WriteLine((oneHalf / oneFourth).ToString());

            //Console.WriteLine(oneHalf);
            //Console.WriteLine(oneFourth);
        }
    }
}
