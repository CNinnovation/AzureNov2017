using BooksLib.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BooksLib.Tests.Controllers
{
    public class CalcControllerTests
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange  
            var calcController = new CalcController();
            int expected = 42;
            // Act  
            int actual = calcController.Add(38, 4);
            // Assert 
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestSubtract()
        {
            // Arrange  
            var calcController = new CalcController();
            int expected = 42;
            // Act  
            int actual = calcController.Subtract(44, 2);
            // Assert 
            Assert.Equal(expected, actual);

        }
    }
}
