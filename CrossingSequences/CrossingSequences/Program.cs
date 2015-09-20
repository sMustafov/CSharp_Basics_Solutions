using System;

namespace CrossingSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            int forth = 0;
            bool isNotEqual = true;
            int count = 0;
            int remFirst = 0;
            int remNumber = number;
            int remPos = pos;
            while (isNotEqual)
            {
                int counter = 0;
                number = remNumber;
                pos = remPos;
                count = remPos;
                forth = first + second + third;
                remFirst = first;
                first = second;
                second = third;
                third = forth;
                while (isNotEqual)
                {
                    number = number;
                    if (remFirst == number)
                    {
                        isNotEqual = false;
                        break;
                    }
                    if (first == number)
                    {
                        isNotEqual = false;
                        break;
                    }
                    if (second == number)
                    {
                        isNotEqual = false;
                        break;
                    }

                    if (forth == number)
                    {
                        isNotEqual = false;
                        break;
                    }
                    number += pos;
                    if (number > forth)
                    {
                        break;
                    }
                    count++;
                    counter++;
                    if (count % remPos == 0 && counter == 2)
                    {
                        pos = count;
                        counter = 0;
                    }
                }
                if (number >= 1000000 || number < 1 || forth < 1 || forth >= 1000000)
                {
                    Console.WriteLine("No"); break;
                }

            }
            if ((number <= 1000000 && number >= 1) && (forth >= 1 && forth <= 1000000))
            {
                Console.WriteLine(number);
            }
        }
    }
}
