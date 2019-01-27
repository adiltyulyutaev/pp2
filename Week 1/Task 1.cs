using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a =int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            string[] s = new string[a];
            for (int i=0;i<arr.Length;i++)
            {
                string[]s = Console.ReadLine().Split( );
                arr[i] = int.Parse(s[i]);
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
