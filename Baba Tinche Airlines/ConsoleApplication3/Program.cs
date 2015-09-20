using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] line1 = input1.Split(' ');
            int firstClass = Convert.ToInt32(line1[0]);
            int FiCnumOfFF = Convert.ToInt32(line1[1]);
            int FCMeal = Convert.ToInt32(line1[2]);
            int cost1 = ((firstClass - FiCnumOfFF) * 7000) + (FiCnumOfFF * 2100) + (FCMeal * 35);
            int maxCost1 = (12 * 7000) + (12 * 35);

            string input2 = Console.ReadLine();
            string[] line2 = input2.Split(' ');
            int bussinessClass = Convert.ToInt32(line2[0]);
            int BussCnumOfFF = Convert.ToInt32(line2[1]);
            int BussCMeal = Convert.ToInt32(line2[2]);
            int cost2 = ((bussinessClass - BussCnumOfFF) * 3500) + (BussCnumOfFF * 1050) + (BussCMeal * 35/2);
            int maxCost2 = (28 * 3500) + (28 * 35/2);

            string input3 = Console.ReadLine();
            string[] line3 = input3.Split(' ');
            int economyClass = Convert.ToInt32(line3[0]);
            int EcClnumOfFF = Convert.ToInt32(line3[1]);
            int EcClMeal = Convert.ToInt32(line3[2]);
            int cost3 = ((economyClass - EcClnumOfFF) * 1000) + (EcClnumOfFF * 300) + (EcClMeal * 5);
            int maxCost3 = (50 * 1000) + (50 * 5);

            int sum = cost1 + cost2 + cost3;
            int maxSum = maxCost1 + maxCost2 + maxCost3;

            Console.WriteLine(sum);
            Console.WriteLine(maxSum - sum);
        }
    }
}
