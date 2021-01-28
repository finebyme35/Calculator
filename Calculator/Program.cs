using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A sayısını giriniz:");
            string A = Console.ReadLine();
            int A1 = int.Parse(A);
            Console.Write("B sayısını giriniz:");
            string B = Console.ReadLine();
            int B1 = int.Parse(B);
            Console.WriteLine("Hangi İşlemi Yapmak istiyorsun: Toplama (T),Çıkarma (C),Carpma (A), Bölme (D), Mod(M)");
            string Commit = Console.ReadLine();
            if (Commit == "T" || Commit == "C" || Commit == "A" || Commit == "D" || Commit == "M")
            {
                if (Commit == "T")
                {
                    Sum(A1, B1);


                }
                else if (Commit == "C")
                {
                    Minus(A1, B1);
                }
                else if (Commit == "A")
                {
                    Multiplication(A1, B1);
                }
                else if (Commit == "D")
                {
                    Divide(A1, B1);
                }
                else if (Commit == "M")
                {
                    Mod(A1, B1);
                }
            }
            else
            {
                Console.WriteLine("Lütfen toplama işlemi için \"T\", Çıkarma işlemi  için  \"C\", Çarpma işlemi  için  \"A\", Bölme işlemi  için  \"D\", Mod işlemi  için  \"M\" girin!");
            }


            Console.ReadLine();
        }

        static void Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        static void Minus(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        static void Mod(int a, int b)
        {
            int result = a % b;
            Console.WriteLine(result);
        }

    }
}

