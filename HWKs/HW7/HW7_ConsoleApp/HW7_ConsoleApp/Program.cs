using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace HW7_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("### Q1");
            Console.Write("Enter first letter: ");
            string firstLetter = Console.ReadLine();
            Console.Write("Enter second letter: ");
            string secondLetter = Console.ReadLine();
            Console.Write("Enter third letter: ");
            string thirdLetter = Console.ReadLine();

            Console.Write("Reversed entry: ");
            Console.WriteLine(thirdLetter + " " + secondLetter + " " + firstLetter);
            

            Console.WriteLine("### Q2");
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < width - i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine(); 
            }
            

            Console.WriteLine("### Q3");
            string userid = "123abc";
            string userInput = "";

            int count = 0;
            while(userInput != userid)
            {
                Console.Write("Enter User ID: ");
                userInput = Console.ReadLine();

                count += 1;
                if(userInput != userid)
                {
                    Console.WriteLine("ID is incorrect.You have {0} attempts left", 3 - count);
                }
                else
                {
                    Console.WriteLine("Access Granted");
                }
              
                if(count == 3)
                {
                    Console.WriteLine("Access Denied. You have been locked out.");
                    break;
                }
            }
            

            Console.WriteLine("### Q4");
            Console.Write("Enter first number: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation (+, -, x, /): ");
            string oper = Console.ReadLine();
            Console.Write("Enter second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            if(oper == "+")
            {
                int result = num_1 + num_2;
                Console.WriteLine("{0} {1} {2} = {3}", num_1, oper, num_2, result);
            }
            else if(oper == "-")
            {
                int result = num_1 - num_2;
                Console.WriteLine("{0} {1} {2} = {3}", num_1, oper, num_2, result);
            }
            else if (oper == "x")
            {
                int result = num_1 * num_2;
                Console.WriteLine("{0} {1} {2} = {3}", num_1, oper, num_2, result);
            }
            else if (oper == "/")
            {
                int result = num_1 / num_2;
                Console.WriteLine("{0} {1} {2} = {3}", num_1, oper, num_2, result);
            }
            else { Console.WriteLine("Invalid operation entered"); }
            

            Console.WriteLine("### Q5");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            // Compute
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            // Print
            Console.WriteLine("Area: {0} and Perimeter: {1}", Math.Round(area, 2), Math.Round(perimeter, 2));
            

            Console.WriteLine("### Q6");
            int y_val = -10;
            while ((y_val < -5) || (y_val > 5))
            {
                Console.Write("Enter y value: ");
                y_val = Convert.ToInt32(Console.ReadLine());
            }

            double x_val = Math.Pow(y_val, 2) + 2 * y_val + 1;

            Console.WriteLine("When y is {0}, x is {1}", y_val, x_val);
            */

            Console.WriteLine("### Q7");
            Console.Write("Enter distance in meters: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time in seconds: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double velocity = distance / time;

            Console.WriteLine("Your speed in meter/sec is {0}", Math.Round(velocity, 4));
            Console.WriteLine("Your speed in km/h is {0}", Math.Round(velocity * 3.6, 4));
            Console.WriteLine("Your speed in km/h is {0}", Math.Round(velocity * 3.6 * 0.621, 4));



        }
    }
}
