using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new UnitTestMethods();
            var actual = test.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(5, 4, 1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            var test = new UnitTestMethods();
            var actual = test.Subtract(minuend,subtrhend);
            Assert.Equal(expected, actual);

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(8, 7, 56)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var test = new UnitTestMethods();
            var actual = test.Multiply(num1, num2);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 4, 2)]//Add test data <-------
        public void DivideTest(int one, int two, int expected)
        {
            var test = new UnitTestMethods();
            var actual = test.Divide(one, two);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void ReturnName()
        {
            var name = "TM";
            var test = new UnitTestMethods();
            var actual = test.ReturnName();
            Assert.Equal(name, actual);
        }
    }
}
