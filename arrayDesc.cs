using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    class arrayDesc
    {
        public static void Main()
        {
            int n = 0;
            // 1.get the size of the array from user
            Console.WriteLine("Enter the size of the array \n");           
            n = Convert.ToInt32(Console.ReadLine());

            // 2.get the array elements from user
            int[] arr = new int[n];
            Console.WriteLine("Enter the values for your array \n");
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            // 3.sort the array and the reverse it to get the values in descending
            Array.Sort(arr);
            Array.Reverse(arr);

            // 4.print the array
            Console.WriteLine("\n your array in descending order \n");
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}  ", arr[i]);

            Console.ReadKey();

        }
    }
}
