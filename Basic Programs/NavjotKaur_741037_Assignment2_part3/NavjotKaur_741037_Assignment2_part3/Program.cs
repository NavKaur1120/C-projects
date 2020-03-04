using System;

namespace NavjotKaur_741037_Assignment2_part3
{
    //Name: Navjot Kaur Student_id:741037 Assignment2
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variable to get your age
            int age;
            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());

            //using if condition to show that the age you enter is even or odd
            if(age%2==0)
            {
                Console.WriteLine("the age you entered is even number");

            }
            else
            {
                Console.WriteLine("the age you entered is odd number");   
            }
            Console.ReadKey();

        }
    }
}
