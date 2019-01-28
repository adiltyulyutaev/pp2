using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int [] arr = new int [a];
            List<int> ans = new List<int>();
            string[] s = Console.ReadLine().Split( );
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(s[i]);
                int pr = 0;
                for(int j=2;j<=(int)Math.Sqrt(arr[i]);j++)
                {
                    if(arr[i]%j==0)
                    {
                        pr = 1;
                        break;
                    }

                }
                 if(pr==0 && arr[i]!=1)
                 {
                    ans.Add(arr[i]);
                 }
              
            }
            Console.WriteLine(ans.Count);
            for(int i=0;i<ans.Count;i++)
            {
                Console.Write(ans[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
