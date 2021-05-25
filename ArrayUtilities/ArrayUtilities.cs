using System;

namespace ArrayUtilities
{
    public static class ArrayUtilities
    {
        /// <summary>
        /// Returns the index of the minimum value.
        /// If array is null or empty, it return <see cref="int.MinValue"/>
        /// </summary>
        /// <param name="array"></param>
        /// <returns>An integer representing the index of the minimum value</returns>
        public static int ReturnIndexofMinimum(int[] array)
        {
            if(array==null || array.Length == 0)
            {
                return int.MinValue;
            }

            int indexOfMinimum = 0;
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexOfMinimum = i;
                }
            }

            // Console.WriteLine($"The minimum of the array is {min} located at index no {indexOfMinimum}");
            return indexOfMinimum;
        }

        /// <summary>
        /// Returns the index of the maximum value.
        /// If array is null or empty, it return <see cref="int.MaxValue"/>
        /// </summary>
        /// <param name="array"></param>
        /// <returns>An integer representing the index of the maximum value</returns>
        public static int ReturnIndexofMaximum(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return int.MaxValue;
            }

            int indexOfMaximum = 0;
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexOfMaximum = i;
                }
            }

            // Console.WriteLine($"The minimum of the array is {min} located at index no {indexOfMinimum}");
            return indexOfMaximum;
        }

        /// <summary>
        /// Returns the sum of the elements in a given array.
        /// it returns <see cref="int.MinValue"/> if arry is null or empty.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>An integer representing the sum of the elements of an array.</returns>
        public static int SumOfArray(int[] array)
        {
            if(array==null|| array.Length == 0)
            {
                return int.MinValue;
            }

            int sum = 0;
            foreach(int elemnt in array)
            {
                sum += elemnt;
            }

            return sum;
        }

        /// <summary>
        /// Returns the arithmetic mean of the elements of an array.
        /// Returns <see cref="decimal.MinValue"/> if array empty or null
        /// </summary>
        /// <param name="array"></param>
        /// <returns>a decimal value.</returns>
        public static decimal ArithmeticMeanofElements(int[] array)
        {
            if(array==null || array.Length == 0)
            {
                return decimal.MinValue;
            }
            decimal media = ((decimal)SumOfArray(array) / (decimal)array.Length);
            return media;
        }
    }
}
