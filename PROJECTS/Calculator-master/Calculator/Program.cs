using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Section for Fraction Computations");
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


            // ################### DECIMALS #########################
            Console.WriteLine(" ");
            Console.WriteLine("*** Section for Decimal Computations");

            var dec_1 = new Decimals(2.25);
            var dec_2 = new Decimals(1.75);
            Console.WriteLine(dec_1.ToString());
            Console.WriteLine(dec_2.ToString());

            Console.WriteLine(dec_1.Add(dec_2).ToString());
            Console.WriteLine((dec_1 + dec_2).ToString());

            Console.WriteLine(dec_1.Subtract(dec_2).ToString());
            Console.WriteLine((dec_1 - dec_2).ToString());

            Console.WriteLine(dec_1.Multiply(dec_2).ToString());
            Console.WriteLine((dec_1 * dec_2).ToString());

            Console.WriteLine(dec_1.Divide(dec_2).ToString());
            Console.WriteLine((dec_1 / dec_2).ToString());


            // ################### COMPLEX #########################
            Console.WriteLine(" ");
            Console.WriteLine("*** Section for Complex Numbers Computations");

            var comp_1 = new Complex(2.5, 1.0);
            var comp_2 = new Complex(1.5, 2.0);
            Console.WriteLine(comp_1.ToString());
            Console.WriteLine(comp_2.ToString());

            Console.WriteLine(comp_1.Add(comp_2).ToString());
            Console.WriteLine((comp_1 + comp_2).ToString());

            Console.WriteLine(comp_1.Subtract(comp_2).ToString());
            Console.WriteLine((comp_1 - comp_2).ToString());

            Console.WriteLine(comp_1.Multiply(comp_2).ToString());
            Console.WriteLine((comp_1 * comp_2).ToString());

            Console.WriteLine(comp_1.TrueDiv(comp_2).ToString());
            Console.WriteLine((comp_1 / comp_2).ToString());

        }
    }
}
