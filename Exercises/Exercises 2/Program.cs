using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace Exercises_2
{
    class Program
    {
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
                        Math.GetCircleValues();
                        break;
                    case "b":
                        Math.CalcCircleArea();
                        break;
                    case "c":
                        Math.GetSquareValues();
                        break;
                    case "d":
                        Math.CalcSquareArea();
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

    class Math
    {
        public static int GetCircleValues()
        {
            Console.WriteLine("Enter the circles radius:");
            return int.Parse(Console.ReadLine());
        }

        public static void CalcCircleArea(int rad)
        {
            return Math.Pow(3.14 * rad, 2.0);
        }

        public static int GetSquareValues(int w, int h)
        {
            Console.WriteLine("Enter the squares width:");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the squares height:");
            h = int.Parse(Console.ReadLine());
            return w;
        }

        public static void CalcSquareArea()
        {

        }
    }
}
