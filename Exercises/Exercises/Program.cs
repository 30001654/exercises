using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;

            do
            {
                Console.WriteLine("Enter an operation to begin [x, /, +, -] or type 'exit' to quit.");

                menu = Console.ReadLine();
                switch (menu)
                {
                    case "x":
                        Math.MultiplyNums();
                        break;
                    case "/":
                        Math.DivideNums();
                        break;
                    case "+":
                        Math.AddNums();
                        break;
                    case "-":
                        Math.SubtractNums();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Error. Not an option!");
                        break;

                }
            } while (menu != "exit");
        }
        
    }

    class Math
    {
        public static void MultiplyNums()
        {
            Console.WriteLine(EnterFirst("multiplied"));
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(EnterSecond("multiplied"));
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
        }

        public static void DivideNums()
        {
            Console.WriteLine(EnterFirst("divided"));
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(EnterSecond("divided"));
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
        }

        public static void AddNums()
        {
            Console.WriteLine(EnterFirst("added"));
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(EnterSecond("added"));
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
        }

        public static void SubtractNums()
        {
            Console.WriteLine(EnterFirst("subtracted"));
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(EnterSecond("subtracted"));
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
        }

        public static string EnterFirst(string enterMessage)
        {
            return $"Enter the first number to be {enterMessage}:";
        }

        public static string EnterSecond(string enterMessage)
        {
            return $"Enter the second number to be {enterMessage}:";
        }
    }
}
