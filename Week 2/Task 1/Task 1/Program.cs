using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            string s = sr.ReadToEnd();
            int a = 1;
            int b = s.Length;
            for(int i=0; i<s.Length;i++)
            {
                if (s[i] != s[b - i-1])
                {
                    a++;
                }
                    
            }
            if (a==1)
            {
                sw.WriteLine("Yes");
            }
            else
            {
                sw.WriteLine("No");
            }
            sr.Close();
            sw.Close();
         
            Console.ReadKey();
        }
    }
}
