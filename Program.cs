using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_array
{
    internal class Program
    {
        static void Result(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("array element: " + arr[i]);

            }

        }
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Result(arr);
            Console.ReadLine();

        }
    }
}
