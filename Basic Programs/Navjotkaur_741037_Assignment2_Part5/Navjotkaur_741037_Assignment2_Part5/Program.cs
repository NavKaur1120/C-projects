using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navjotkaur_741037_Assignment2_Part5
{
    //Name: Navjot Kaur Student_id:741037 Assignment2
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a  variable y for age and assigning the variable y for incrementation 
            int x,y=0;
            Console.WriteLine("Enter your age ");
            x = int.Parse(Console.ReadLine());

            //using while condition to print the stars according to your age number in one line.
            while(y<x)
            {
                Console.Write("*");
                y++;

            }
            Console.ReadKey();
        }
    }
}
