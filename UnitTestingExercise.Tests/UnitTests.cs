using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]//Add test data <-------
        [InlineData(0, 0, 0)]
        [InlineData(-1, -2, 1)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 2, 2)]//Add test data <-------
        [InlineData(100, 0, 0)]
        [InlineData(-3, 2, -6)]
        [InlineData(-3, -2, 6)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 2, 1)]//Add test data <-------
        [InlineData(6, -2, -3)]
        [InlineData(-6, -2, 3)]
        [InlineData(23, 0, 0)]
        [InlineData(0, 89, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            int actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
