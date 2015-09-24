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
            string[] line = input.Split('\\');
            string month = line[0];
            decimal money = decimal.Parse(line[1]);
            int hoursPerDay = int.Parse(line[2]);
            decimal priceOfTheItem = decimal.Parse(line[3]);

            decimal allMoney = 0m;

            if (month == "Jan" ||month == "March" ||month == "May" ||month == "July" ||month == "Aug" 
                || month == "Oct" || month == "Dec" )
            {
                allMoney = 21 * money * hoursPerDay;
            }
            else if (month == "Feb" )
            {
                allMoney = 18 * money * hoursPerDay;
            }
            else if (month == "Apr" ||month == "June" ||month == "Sept" ||month == "Nov" )
            {
                allMoney = 20 * money * hoursPerDay;
            }
            if(allMoney > 700)
            {
                allMoney += allMoney * 0.1m;
            }
            if (allMoney >= priceOfTheItem)
            {
                Console.WriteLine("Money left = {0:0.00} leva.",allMoney - priceOfTheItem);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:0.00} leva needed.", priceOfTheItem - allMoney);
            }
        }
    }
}
