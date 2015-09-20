using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bit = n & (1 << 3);
            bit = bit >> 4;
            Console.WriteLine(bit );
        }
    }
}
