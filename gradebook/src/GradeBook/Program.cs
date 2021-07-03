using System; //Day 1
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)                                         //Main is method, entry point of applications
        {
                        var grades = new List<double>() {12.7,10.3,6.11,4.1};
            grades.Add(56.1);
           
            
            var result = 0.0;
            foreach(var number in grades) 
            {
                    result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !");                           //Put Input after first string
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
