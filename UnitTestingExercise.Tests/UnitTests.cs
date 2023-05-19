using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3,4,5,12)]//Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var test = new UnitTestMethods();
            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,1,1)]
        [InlineData(39,5,34)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,4,40)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,4,5)]
        [InlineData(45,9,5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
