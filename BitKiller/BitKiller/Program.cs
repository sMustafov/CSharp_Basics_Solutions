using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitKiller
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte steps = byte.Parse(Console.ReadLine());
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < n * 8; i += 8)
            {
                byte number = byte.Parse(Console.ReadLine());
                string binary = Convert.ToString(number, 2).PadLeft(8, '0');
                bin = bin.Insert(i, binary);
            }
            StringBuilder newStr = new StringBuilder();
            Console.WriteLine(bin);
            int lenght = bin.Length;
            int index = 0;
            for (int j = 0; j < lenght; j++ )
            {
                if (j == 1)
                {
                   //bin = bin.Remove(j, 1);
                }
                else if ((j+1) % steps == 0 && j != 0)
                {
                   //bin = bin.Remove(steps, 1);
                }
                else if (bin[j] == '0' && j != 1 &&  (j+1) % steps == 1)
                {
                    newStr = newStr.Insert(index, '0');
                    index++;
                }
                else if (bin[j] == '1' && j != 1 && (j + 1) % steps == 1)
                {
                    newStr = newStr.Insert(index, '1');
                    index++;
                }
            }
            string result = newStr.ToString();
            if (result.Length <= 8)
            {
                result = result.PadRight(8, '0');
                Console.WriteLine(result);
                int num = Convert.ToInt32(result,2);
                Console.WriteLine(num);
            }
            StringBuilder final = new StringBuilder();
            if ( result.Length <= 16 && result.Length > 8)
            {
                int k = 0;
                result = result.PadRight(16, '0');
                for (int p = 0; p < 16; p++)
                {
                    int t = 0;
                    int ind = 1;
                    for (k = p; k < ind * 8; k++)
                    {
                        final = final.Insert(t, result[k]);
                        t++;
                    }
                    Console.WriteLine(final);
                    string ne = final.ToString();
                    int numb = Convert.ToInt32(ne, 2);
                    Console.WriteLine(numb);
                    p = ind * 7;
                    ind++;
                    
                }
            }
            if (result.Length <= 24 && result.Length > 16)
            {
                result = result.PadRight(24,'0');
            }
            if (result.Length <= 32 && result.Length > 24)
            {
                result = result.PadRight(32, '0');
            }
            Console.WriteLine(result);
                
        }
    }
}
