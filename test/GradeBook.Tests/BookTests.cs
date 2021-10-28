using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] //This is an attribute
        public void Test1()
        {
            //arrange
          var book = new Book("");
            book.AddGrade(45.1);
            book.AddGrade(76.3);
            book.AddGrade(46.5);


            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(56.0, result.Average, 1);
            Assert.Equal(76.3, result.High, 1);
            Assert.Equal(45.1, result.Low, 1);
            
        }
    }
}
