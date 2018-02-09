using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            List<int> key = new List<int>(){1,3,0,4,2};
            List<int> message = new List<int>(){79,73, 75, 69, 65};
            int[] test = new int[5];
            test = Shuffle(message, key);
            foreach (int k in test)
            {
                Console.WriteLine(k);
            }
            */
            int[] values = new int[8] {50, 70, 30, 2, 40, 24, 19, 60};
            int[] results = InsertionSort(values);
            foreach (int num in results)
            {
                Console.WriteLine(num);
            }
        }

        static int[] Shuffle(List<int> v, List<int> key)
        {
            int[] result = new int[5];
            for (int k = 0; k < v.Count; k++)
            {
                int temp = key[k];
                result[temp] = v[k];
            return result;
            }

        }

        static int[] InsertionSort(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                int loopage = 0;
                int x = values[i];
                int j = i - 1;
                while (j >= 0 && values[j] > x)
                {
                    values[j+1] = values[j];
                    j = j-1;
                    loopage++;
                }
                values[j + 1] = x;
                Console.WriteLine("Number of loops it took to sort index {0}: {1}", x, loopage);
            }
            return values;
        }
    }
}
