using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');
            string command;
            do
            {

                command = Console.ReadLine();
                string[] comm = command.Split(' ');

                string check = null;
                int numOfCheck = 0;
                int row = 0;
                string direction = null;
                int rotations = 0;

                int bitValue = 0;

                if (comm.Length == 2)
                {
                    check = comm[0];
                    numOfCheck = Convert.ToInt32(comm[1]);
                }
                else if (comm.Length == 3)
                {
                    row = Convert.ToInt32(comm[0]);
                    direction = comm[1];
                    rotations = Convert.ToInt32(comm[2]);
                }
                int count = 0;
                if (check == "check")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        int num = Convert.ToInt32(nums[i]);
                        bitValue = (num >> numOfCheck) & 1;
                        if (bitValue == 1)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }
                if (direction == "right")
                {
                    int num = Convert.ToInt32(nums[row]);
                    int rotations1 = rotations % 12;
                    int rotations2 = 12  - rotations1;
                    int mask1 = (num >> rotations1);
                    int mask2 = (num << rotations2);
                    num = mask1 | mask2;
                    int number = num & 4095;
                    nums[row] = Convert.ToString(number);
                }

                else if (direction == "left")
                {
                    int num = Convert.ToInt32(nums[row]);
                    int rotations1 = rotations % 12;
                    int rotations2 = 12 - rotations1;
                    int mask1 = (num << rotations1);
                    int mask2 = (num >> rotations2);
                    num = mask1 | mask2;
                    int number = num & 4095;
                    nums[row] = Convert.ToString(number);
                }
            } while (command != "end");
            for (int j = 0; j < 8; j++)
            {
                Console.Write(nums[j] + " ");
            }
        }
    }
}
