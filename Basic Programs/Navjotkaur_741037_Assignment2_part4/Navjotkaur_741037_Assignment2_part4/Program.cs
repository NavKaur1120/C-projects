using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navjotkaur_741037_Assignment2_part4
{
    //Name: Navjot Kaur Student_id:741037 Assignment2
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables of days,totalwages,hours and total hours and assigning the variables too.
            double days, totalWage=0, hours=0, thours=0;
            Console.WriteLine("Enter the number of  days you worked in last week ");
            days = double.Parse(Console.ReadLine());

            //using repetetive statement to get number of hours in each day and then get total pay.
            for (double a = 0; a< days; a++)
            {
                Console.WriteLine("Enter the number of hours per day ");
                hours = double.Parse(Console.ReadLine());
                thours += hours;

            }
            for(double a=0;a< days; a++)
            {
                //using conditional statement to get the total wage and extra pay
                if( hours <=8)
                {
                    totalWage = thours * 14;
                }
                else
                {
                    totalWage = (8 * 14) + ((thours - 8) * 1.5) * 14;
                }
                
            }

            Console.WriteLine("your total wage is ${0}", totalWage);
            Console.ReadKey();

        }
    }
}
