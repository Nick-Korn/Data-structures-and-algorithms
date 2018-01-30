using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers(13);
            //Console.WriteLine(Fibo(5));
            //Console.WriteLine(Number(3));
            Console.WriteLine(Reku(int.Parse(Console.ReadLine())));
        }

        //Assignment 1 
        static void Numbers(int b)
        {
            int k = 0;
            List<int> a = new List<int>();
            a.Add(1);

            while (a.Count() <= b)
            {
                k = k + 1;
                a.Add(a[k - 1] + a[k - 1]);
            }

            foreach (var c in a)
            {
                Console.WriteLine(c);
            }
        }

        // Assignment 2
        static int Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return Fibo(n - 2) + Fibo(n - 1);
            }
        }

        static int Number(int n)
        {
            Console.WriteLine(n);
            return Fibo(n - 1) / Fibo(n);
        }

        // Assignment 3
        static int Reku(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return 1 / (1 + Reku(n - 1));
            } 
        }   
    }
}

