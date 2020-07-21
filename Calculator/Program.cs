using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculatron

            Console.WriteLine("\t\tAll Hail Calculatron!\r");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\t\t  I----------I\r");
            Console.WriteLine("\t\t I (--)  (--) I\r");
            Console.WriteLine("\t\t  I----------I\r");
            Console.WriteLine("\t\t      IIII     \r");
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("------------------------------------------------");
        
            //First number
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine().Replace(",","."));

            //Operation
            Console.Write("Enter Operator ( +, -, *, /,): ");
            string op = Console.ReadLine();

            //First number
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine().Replace(",", "."));

            // If statements for operators selected

            Console.Write("Result: ");

            if (op == "+")
            {
                Console.WriteLine($"{num1}+{num2}={num1 + num2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{num1}-{num2}={num1 - num2}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{num1}/{num2}={num1 / num2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{num1}*{num2}={num1 * num2}");
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press any key to close...");
            Console.WriteLine("------------------------------------------------");
            Console.ReadKey();
        }
    }
}