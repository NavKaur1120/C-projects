using System;


namespace Assignment1
{
    class Program
    {
     
        static DateTime thisDate = DateTime.Now;

        static void Main(string[] args)
        {
            //formatting background and forground
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            
                Console.WriteLine("<================The final Result of the student======================>"); 
         

            string studentName,studentId;
            Console.WriteLine("Enter your Name      ");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter your Student Id ");
            studentId = Console.ReadLine();
            
         

            Console.WriteLine("<====================================================================>");
                    double as1, as2, as3, as4, as5, as_total;                     //variables for assignment
            double t1, t2, t3 ,test_total;                                  //variables for test

            Console.WriteLine("Enter your 5 assignment marks out of 100\n");
            Console.WriteLine("Assignment 1 ");
            as1 =double.Parse(Console.ReadLine());

            Console.WriteLine("Assignment 2  ");
            as2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Assignment 3 ");
            as3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Assignment 4 ");
            as4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Assignment 5 ");
            as5 = double.Parse(Console.ReadLine());

            as_total = as1 * 0.05 + as2 * 0.05 + as3 * 0.05 + as4 * 0.05 + as5 * 0.05;
            Console.WriteLine("the total marks of 5 assignments are {0}", as_total);
            Console.WriteLine("<====================================================================>");


            Console.WriteLine("Enter your marks of three tests out of 100");
            Console.WriteLine("Test1 ");
            t1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Test 2 ");
            t2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Test3 ");
            t3 = double.Parse(Console.ReadLine());

            test_total = t1 * 0.25 + t2 * 0.25 + t3 * 0.25;
            Console.WriteLine(" the total marks of 3 tests are  {0}", test_total);
            Console.WriteLine($"<===================================================================>");

            double course_total;
            course_total = as_total + test_total;
            Console.WriteLine("your course_total is     {0}", course_total);
            Console.WriteLine("\n");

            string grade, gpa;

            if (course_total <= 100.00 && course_total > 94)
            {
                grade = "A+";gpa = "4.0";
                Console.WriteLine("you get {0} grade and {1} GPA",grade,gpa);
            }
            else if(course_total <= 93.99 && course_total >= 87)
            {
                grade = "A"; gpa = "3.7";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 86.99 && course_total >= 80)
            {
                grade = "A-"; gpa = "3.5";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);

            }
            else if (course_total <= 79.99 && course_total >= 77)
            {
                grade = "B+"; gpa = "3.2";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 76.99 && course_total >= 73)
            {
                grade = "B"; gpa = "3.0";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 72.99 && course_total >= 70)
            {
                grade = "B-"; gpa = "2.7";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 69.99 && course_total >= 67)
            {
                grade = "C+"; gpa = "2.3";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 66.99 && course_total >= 63)
            {
                grade = "C"; gpa = "2.0";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 62.99 && course_total >= 60)
            {
                grade = "C-"; gpa = "1.7";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else if (course_total <= 59.99 && course_total >= 50)
            {
                grade = "D"; gpa = "1.0";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa); ; ;
            }
            else if (course_total <= 49.99 && course_total >= 0)
            {
                grade = "F"; gpa = "0.0";
                Console.WriteLine("you get {0} grade and {1} GPA", grade, gpa);
            }
            else
            {
                Console.WriteLine("Invalid output");
            }

            Console.WriteLine("<===================================================================>");

           
            Console.WriteLine("the total fees paid for the semester is  {0:c} ", 1020);
            Console.WriteLine("The current date,day and time is   {0:f}", thisDate);




            Console.ReadKey();





            

        }
    }
}
