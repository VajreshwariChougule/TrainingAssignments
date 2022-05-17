using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TenMarks
    {
        public void tenmarks()
        {
            int n;
            Console.WriteLine("Enter array size");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter your marks");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your enterd marks is ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Total Marks is : " + arr.Sum());
            Console.WriteLine("Your Average Marks is : " + arr.Average());
            Console.WriteLine("your minimum marks is :" + arr.Min());
            Console.WriteLine("your maximum marks is :" + arr.Max());
            Array.Sort(arr);
            Console.WriteLine("After array sort");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("array values assending order");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}