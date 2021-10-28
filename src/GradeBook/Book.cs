using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)  //This is what we call an instant member of a class. Never used static keyword
        {                                    //Also AddGrade() is an instant member of the class Book.
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach(double grade in grades)
            {
               
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            
            }
            result.Average /= grades.Count;
            return result;
           
        }

        private List<Double> grades; //This is an instant field that is associated with class Book
        private string name;

        
    }
}