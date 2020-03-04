using System;

namespace NavjotKaur_741037_Assignment2_part1
{
    //Name: Navjot Kaur Student_id:741037 Assignment2
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the variables
            double  days,regular_days,extraDays;
            Console.WriteLine("Enter your rental car days");
            days = double.Parse(Console.ReadLine());
            
            //using if condition to get the car rent for regular and additional days.
            if(days <= 3.00)
            {
                regular_days = days * 30.00;
                Console.WriteLine("your car rent for 3 or less than 3 days is ${0}", regular_days);

            }
            else
            {
                extraDays = (3.00*30) + (days - 3) * (20.00);
                Console.WriteLine("the car rent with additional days is ${0}", extraDays);
            }
            Console.ReadKey();


        
        }
    }
}
