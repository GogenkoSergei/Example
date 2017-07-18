using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the length of the array:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input the max element of the array:");
            int m = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            // пузырек
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(m);
                Console.WriteLine(arr[i]);
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("---------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("---------------");
            // вставка
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(m);
                Console.WriteLine(arr[i]);
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    int newel = arr[j];
                    int loc = j - 1;
                    while (loc >= 0 && arr[loc] > newel)
                    {
                        arr[loc+1] = arr[loc];
                        loc = loc - 1;
                    }
                    arr[loc + 1] = newel;
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
