using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(10, 10, 10, 30)]
        [InlineData(150, 150, 150, 450)]
        [InlineData(20, 20, 20, 60)]
        public void AddTest(int a, int b, int c, int expected)
        {
            //Start Step 3 here:
            //Arrange
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(a, b, c);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(20, 10, 10)]
        [InlineData(5,2, 3)]
        public void SubtractTest(int a, int b, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(a, b);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(9, 9, 81)]
        [InlineData(6, 6, 36)]
        [InlineData(7, 7, 49)]
        public void MultiplyTest(int a, int b, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(a, b);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 10, 10)]//Add test data <-------
        [InlineData(81, 9, 9)]
        [InlineData(16, 4, 4)]
        
        public void DivideTest(int a, int b, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(a, b);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
