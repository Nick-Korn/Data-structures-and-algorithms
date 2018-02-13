using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            /* 
            List<int> key = new List<int>(){1,3,0,4,2};
            List<int> message = new List<int>(){79,73, 75, 69, 65};
            int[] test = new int[5];
            test = Shuffle(message, key);
            foreach (int k in test)
            {
            int end = values.Length;
                Console.WriteLine(k);
            }

            int[] values = new int[8] {50, 70, 30, 2, 40, 24, 19, 60};
            int[] results = InsertionSort(values);
            foreach (int num in results)
            {
                Console.WriteLine(num);
            }
            
            List<int> Values = new List<int>(){9,3,11,2};
            List<int> result = Bubble(Values);
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
            */
            int[] temp = new int[10];
            int start = 0;
            int[] values = new int[]{60, 170, 30, 2, 11, 19, 24, 50, 3, 100};
            
            int end = values.Length;
            int[] result = MergeSort(values, temp, start, end - 1);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        private static int[] Shuffle(List<int> v, List<int> key)
        {
            int[] result = new int[5];
            for (int k = 0; k < v.Count; k++)
            {
                int temp = key[k];
                result[temp] = v[k];
            
            }
            return result;
        }


        private static int[] InsertionSort(int[] values)
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

        private static List<int> Bubble(List<int> values)
        {
            int i, j;

            for (i = 0; i < values.Count - 1; i++)
            {
                for(j = 0; j < values.Count - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j+1];   
                        values[j + 1] = temp;
                    }
                }
            }
            return values;
        }
        private static int[] MergeSort(int[] t, int[] l, int start, int end)
        {
            int[] merged = new int[10];
            return merged;
        }
    }
}
