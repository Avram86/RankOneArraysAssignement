using System;
using Xunit;

namespace RankOneArrays.Tests
{
    public class ArrayUtilitiesTests
    {
        [Fact]
        public void ReturnIndexofMinimum_ShouldReturnIntMinValue_When_ArrayNull()
        {
            //Arrange
            int[] array = null;

            //Act
            int actual=ArrayUtilities.ArrayUtilities.ReturnIndexofMinimum(array);

            //Assert
            Assert.Equal(int.MinValue, actual);
        }

        [Fact]
        public void ReturnIndexofMinimum_ShouldReturnIntMinValue_When_ArrayEmpty()
        {
            //Arrange
            int[] array = new int[0];

            //Act
            int actual = ArrayUtilities.ArrayUtilities.ReturnIndexofMinimum(array);

            //Assert
            Assert.Equal(int.MinValue, actual);
        }

        [Fact]
        public void ReturnIndexofMinimum_ShouldReturnIndexOfMinvalue_When_ArrayNotNullorEmpty()
        {
            //Arrange
            int[] array = { 1, -10, 50, 200,-250 };

            //Act
            int actual = ArrayUtilities.ArrayUtilities.ReturnIndexofMinimum(array);

            //Assert
            Assert.Equal(4, actual);
        }


        [Fact]
        public void ReturnIndexofMaximum_ShouldReturnIntMinValue_When_ArrayNull()
        {
            //Arrange
            int[] array = null;

            //Act
            int actual = ArrayUtilities.ArrayUtilities.ReturnIndexofMaximum(array);

            //Assert
            Assert.Equal(int.MaxValue, actual);
        }

        [Fact]
        public void ReturnIndexofMaximum_ShouldReturnIntMinValue_When_ArrayEmpty()
        {
            //Arrange
            int[] array = new int[0];

            //Act
            int actual = ArrayUtilities.ArrayUtilities.ReturnIndexofMaximum(array);

            //Assert
            Assert.Equal(int.MaxValue, actual);
        }

        [Fact]
        public void ReturnIndexofMaximum_ShouldReturnIndexOfMaxvalue_When_ArrayNotNullorEmpty()
        {
            //Arrange
            int[] array = { 1, -10, 50, 200, -250 };

            //Act
            int actual = ArrayUtilities.ArrayUtilities.ReturnIndexofMaximum(array);

            //Assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void SumOfArray_ShouldReturnIntMinValue_When_ArrayNull()
        {
            //Arrange
            int[] array = null;

            //Act
            int actual = ArrayUtilities.ArrayUtilities.SumOfArray(array);

            //Assert
            Assert.Equal(int.MinValue, actual);
        }

        [Fact]
        public void SumOfArray_ShouldReturnIntMinValue_When_ArrayEmpty()
        {
            //Arrange
            int[] array = new int[0];

            //Act
            int actual = ArrayUtilities.ArrayUtilities.SumOfArray(array);

            //Assert
            Assert.Equal(int.MinValue, actual);
        }

        [Fact]
        public void SumOfArray_ShouldReturnSumOfElments_When_ArrayNotNullorEmpty()
        {
            //Arrange
            int[] array = { 1, -10, 50, 200, -250 };

            //Act
            int actual = ArrayUtilities.ArrayUtilities.SumOfArray(array);

            //Assert
            Assert.Equal(-9, actual);
        }


        [Fact]
        public void ArithmeticMeanOfElements_ShouldReturnIntMinValue_When_ArrayNull()
        {
            //Arrange
            int[] array = null;

            //Act
            decimal actual = ArrayUtilities.ArrayUtilities.ArithmeticMeanofElements(array);

            //Assert
            Assert.Equal(decimal.MinValue, actual);
        }

        [Fact]
        public void ArithmeticMean_ShouldReturnIntMinValue_When_ArrayEmpty()
        {
            //Arrange
            int[] array = new int[0];

            //Act
            decimal actual = ArrayUtilities.ArrayUtilities.ArithmeticMeanofElements(array);

            //Assert
            Assert.Equal(decimal.MinValue, actual);
        }

        [Fact]
        public void ArithmeticMean_ShouldReturnArithmeticMeanOfElments_When_ArrayNotNullorEmpty()
        {
            //Arrange
            int[] array = {0, 1, 3, 2, 4};

            //Act
            decimal actual = ArrayUtilities.ArrayUtilities.ArithmeticMeanofElements(array);

            //Assert
            Assert.Equal((decimal)2, actual);
        }


    }
}
