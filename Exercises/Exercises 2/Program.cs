using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_2
{
    class Program
    {
        static float rad;
        static float sArea;
        static void Main(string[] args)
        {
            string menu;

            do
            {
                Console.WriteLine("'a' Input Circle Values");
                Console.WriteLine("'b' Calculate Circle Area");
                Console.WriteLine("'c' Input Square Values");
                Console.WriteLine("'d' Calculate Square Area");
                Console.WriteLine("'e' Exits the program");

                menu = Console.ReadLine();
                Console.WriteLine();
                switch (menu)
                {
                    case "a":
                        rad = Calculations.GetCircleValues();
                        Console.WriteLine();
                        break;
                    case "b":
                        Console.WriteLine(Calculations.CalcCircleArea(rad));
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        break;
                    case "c":
                        sArea = Calculations.GetSquareValues();
                        Console.WriteLine();
                        break;
                    case "d":
                        Console.WriteLine(Calculations.CalcSquareArea(sArea));
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        break;
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Error. Not an option!");
                        Console.WriteLine();
                        break;

                }
            } while (menu != "e");
        }
    }

    class Calculations
    {
        public static int GetCircleValues()
        {
            Console.WriteLine("Enter the circles radius:");
            return int.Parse(Console.ReadLine());
        }

        public static string CalcCircleArea(float rad)
        {
            double cArea =  Math.Pow(3.14 * rad, 2);
            return $"The area of a cirle with {rad} radius is {Math.Round(cArea, 2)}";
        }

        public static float GetSquareValues()
        {
            Console.WriteLine("Enter the squares width:");
            float w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the squares height:");
            float h = int.Parse(Console.ReadLine());
            float sArea = w * h;
            return sArea;
        }

        public static string CalcSquareArea(float sArea)
        {
            return $"The area of this square is {Math.Round(sArea, 2)}";
        }
    }
}