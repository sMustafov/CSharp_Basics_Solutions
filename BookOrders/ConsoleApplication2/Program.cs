using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstLine = 0;
            double secondLine = 0;
            for (int i = 0; i < n; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int perPacket = int.Parse(Console.ReadLine());
                double price = double.Parse(Console.ReadLine());

                if (packets > 9 && packets < 20)
                {
                    price = price * 0.95;
                }
                else if (packets > 19 && packets < 30)
                {
                    price = price * 0.94;
                }
                else if (packets > 29 && packets < 40)
                {
                    price = price * 0.93;
                }
                else if (packets > 39 && packets < 50)
                {
                    price = price * 0.92;
                }
                else if (packets > 49 && packets < 60)
                {
                    price = price * 0.91;
                }
                else if (packets > 59 && packets < 70)
                {
                    price = price * 0.90;
                }
                else if (packets > 69 && packets < 80)
                {
                    price = price * 0.89;
                }
                else if (packets > 79 && packets < 90)
                {
                    price = price * 0.88;
                }
                else if (packets > 89 && packets < 100)
                {
                    price = price * 0.87;
                }
                else if (packets > 99 && packets < 110)
                {
                    price = price * 0.86;
                }
                else if (packets > 109)
                {
                    price = price * 0.85;
                }

                int allBooks = packets * perPacket;
                double allBooksCosts = allBooks * price;

                firstLine += allBooks;
                secondLine += allBooksCosts;
            }

           
            Console.WriteLine(firstLine);
            Console.WriteLine("{0:0.00}",secondLine);
        }
    }
}
