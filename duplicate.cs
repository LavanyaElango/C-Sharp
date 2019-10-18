using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code
{
    class duplicate
    {
        public static void Main()
        {
            int n = 0;
            // 1.get the size of the array from user
            Console.WriteLine("Enter the size of the array \n");
            n = Convert.ToInt32(Console.ReadLine());

            // 2.get the array elements from user
            int[] testArray = new int[n];
            Console.WriteLine("Enter the values for your array \n");
            for (int i = 0; i < n; i++)
                testArray[i] = Convert.ToInt32(Console.ReadLine());

            //3. get the distinct value of the array and compare the lengths. 
            if (testArray.Length > testArray.Distinct().ToArray().Length)
            {
                Console.WriteLine("has dupliactes");
            }
            else
                Console.WriteLine("no duplicates");

            Console.ReadKey();
        }
    }
}
