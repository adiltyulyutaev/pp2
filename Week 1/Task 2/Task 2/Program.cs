using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
                Console.Write(arr[i] + " " + arr[i] + " ");

            }
            Console.ReadKey();
        }
    }
}
