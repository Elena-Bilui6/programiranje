using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguess2727
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";
            do
            {
                Console.WriteLine("1. Zadatak");
                Console.WriteLine("2. Zadatak");
                Console.WriteLine("3. Zadatak");
                Console.WriteLine("0. Kraj");

                Console.WriteLine("Unesite broj zadataka: ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1":
                        Zad01();
                        break;
                    case "2":
                        Zad02();
                        break;
                    case "3":
                        Zad03();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("nepoznat izbor");
                        break;
                }
            } while (izbor != "0");
        }

        static double PovršinaPravokutnika(double a, double b)
        {
            return a * b;
        }   

        static void Zad01()
        {
            Console.WriteLine("Zad1");
        }
        static void Zad02()
        {
            Console.WriteLine("Zad2");
        }

        static void Zad03()
        {
            Console.WriteLine("==========Zadatak 3==========");
            Console.WriteLine("Unesi Stranicu Pravokutnika A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi Stranicu Pravokutnika B: ");
            double b = double.Parse(Console.ReadLine());
            double povrsina = PovršinaPravokutnika(a, b);
            Console.WriteLine($"Povrsina Pravokutnika je: {povrsina}");
        }
    }
}
