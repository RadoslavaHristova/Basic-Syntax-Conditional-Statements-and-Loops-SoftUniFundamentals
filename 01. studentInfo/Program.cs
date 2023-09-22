using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*вход от конзолата 
             · student name
             · age
             · average grade
            изход
            : "Name: {student name}, Age: {student age}, Grade: {student grade}".*/

            string name=Console.ReadLine();
            int age=int.Parse(Console.ReadLine());
            double grade=double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
