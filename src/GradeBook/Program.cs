using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)  //static is associated to type but not class
        {

            // var p =new Program;
            // Program.Main(args);
            

            var book = new Book("Kimz Qur'an");
            book.AddGrade(82.1);
            book.AddGrade(90.2);
            book.AddGrade(82.2);
            book.AddGrade(52.7);
            book.AddGrade(65.9);

            var stats = book.GetStatistics();

            Console.WriteLine($"The highest number in the list is {stats.High}");
            Console.WriteLine($"The lowest number in the list is {stats.Low}");
            //Console.WriteLine($"Sum: {Math.Round(result, 1)}");
            //Console.WriteLine($"Average: {Math.Round(average, 2)}");
            Console.WriteLine($"Sum: {stats.Average:N1}");
            Console.WriteLine($"Average: {stats:N2}");
        }
    }
}
