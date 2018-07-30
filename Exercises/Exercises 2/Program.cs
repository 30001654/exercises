using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_2
{
    class Program
    {
        static int rad;
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
                switch (menu)
                {
                    case "a":
                        rad = Calculations.GetCircleValues();
                        break;
                    case "b":
                        Calculations.CalcCircleArea(rad);
                        break;
                    case "c":
                        Calculations.GetSquareValues();
                        break;
                    case "d":
                        Calculations.CalcSquareArea();
                        break;
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Error. Not an option!");
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

        public static double CalcCircleArea(int rad)
        {
            return Math.Pow(3.14 * rad, 2);
        }

        public static Array[] GetSquareValues()
        {
            Console.WriteLine("Enter the squares width:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the squares height:");
            int h = int.Parse(Console.ReadLine());
            int[] square = new int[2];
            square[0] = w;
            square[1] = h;
            return square[];
        }

        public static int CalcSquareArea(int w, int h)
        {
            return w * h;
        }
    }
}