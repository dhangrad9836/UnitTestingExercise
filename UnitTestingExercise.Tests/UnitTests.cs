using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 20, 2, 32)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var testAddCalculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = testAddCalculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(6, 4, 2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var testSubtractCalculator = new Calculator();

            //Act
            //store results in actual variable
            var actual = testSubtractCalculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        [InlineData(4, 2, 8)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange - create the object
            var testMultiplyCalculator = new Calculator();

            //Act - store resuluts in actual
            var actual = testMultiplyCalculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(10, 5, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange - create object reference
            var testDivideCalculator = new Calculator();

            //Act - set actual variable to object method
            var actual = testDivideCalculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
