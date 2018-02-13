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
            List<int> temp = new List<int>();
            int start = 1;
            int end = temp.Count;
            List<int> Values = new List<int>(){60, 170, 30, 2, 11, 19, 24, 50, 60, 3, 100};
            List<int> result = MergeSort(Values, temp, start, end);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        static int[] Shuffle(List<int> v, List<int> key)
        {
            int[] result = new int[5];
            for (int k = 0; k < v.Count; k++)
            {
                int temp = key[k];
                result[temp] = v[k];
            
            }
            return result;
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

        static List<int> Bubble(List<int> values)
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
        static List<int> MergeSort(List<int> t, List<int> l, int start, int end)
        {

            if (start >= end) 
            {
                return t;
            }
                
            else if (start + 1 == end)
	        {
                if(t[start] < t[end])
                {
                    int temp = t[end];
                    t[end] = t[start];
                    t[start] = temp;
                }
	        }
            else 
            {
                int middle = (start + end)/2;
                MergeSort(t, l, start, middle);
                MergeSort(t, l, middle + 1, end);
            
                int i = start;
                int j = middle + 1;
                int k = start;

                while (k <= end)
                {
                    if (i > middle)
                    {
                        while (j <= end)
                        {
                            l[k] = t[j];
                            k = k + 1;
                            j = j + 1;
                        }

                    }

                    else if (j > end)
                    {
                        while (i <= middle)
                        {
                            l[k] = t[i];
                            k = k + 1;
                            i = i + 1;
                        }
                    }

                    else
                    {
                        if (t[i] > t[j])
                        {
                            l[k] = t[i];
                            i++;
                        }
                        else
                        {
                            l[k] = t[j];
                            j++;
                        }

                        k++;
                    }
                }

                for (int x = 0; x < end; x++)
                {
                    t[x] = l[x];
                }

               
            }
             return t;
        }
    }
}
