using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string blank = new string(' ', n - 1);
            string dots = new string(':', n);
            Console.WriteLine("{0}{1}",blank,dots);
            for (int i = 0; i < n - 2; i++)
            {
                string slashes = new string ('/', n - 2);
                string blankk = new string (' ',2 * n - (n - 2) - i - 4);
                string xxx = new string('X',i);
                Console.WriteLine("{0}:{1}:{2}:",blankk,slashes,xxx);
            }
            string dotss = new string(':', n);
            string xx = new string('X', n - 2);
            Console.WriteLine("{0}{1}:",dotss,xx);
            for (int i = n - 3; i >= 0; i--)
            {
                string xxxx = new string ('X',i);
                string b = new string(' ', n - 2);
                Console.WriteLine(":{0}:{1}:",b,xxxx);
            }
            string d = new string(':', n);
            Console.WriteLine("{0}",d);
        }
    }
}
