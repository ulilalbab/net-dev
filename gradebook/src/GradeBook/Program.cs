using System; //Day 1

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) //Main is method, entry point of applications
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !"); //Put Input after first string
            }
            else
            {
                Console.WriteLine("hello!");

            }
        }
    }
}
