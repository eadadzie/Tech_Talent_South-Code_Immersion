using System;
using System.Reflection.Emit;

namespace ASSESS_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Q2");
            string name = "Dr. Evil";
            Console.WriteLine("Good Morning" + name);


            Console.WriteLine("Q3");
            int i = 0;
            if(i == 0)
            {
                goto label;
            }
            label: Console.WriteLine("HI...");
            Console.ReadLine();


            Console.WriteLine("Q4");
            int k = 0, j = 0;
            l1: while (i < 2)
            {
                i++;
                while (j < 3)
                {
                    Console.WriteLine("loop\n");
                    goto l1;
                }
            }
            Console.ReadLine();


            Console.WriteLine("Q5");
            string s1 = "Hello" + " I " + "Love" + " ComputerScience ";
            Console.WriteLine(s1);
            Console.ReadLine();
            */

            Console.WriteLine("Q9");
            Console.WriteLine(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine(Console.ReadLine());
            

            Console.WriteLine("Q10");
            int m = 5;
            DoTask(ref m);

            Console.WriteLine(m);
            

        }

        static void DoTask(ref int m)
        {
            m = 6;
        }
    }
}
