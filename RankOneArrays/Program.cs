using System;


namespace RankOneArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the length of the array: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int[] array = ReadArray(n);

                int indexofMin = ArrayUtilities.ArrayUtilities.ReturnIndexofMinimum(array);
                int indexOfMax = ArrayUtilities.ArrayUtilities.ReturnIndexofMaximum(array);
                int sumOfElements = ArrayUtilities.ArrayUtilities.SumOfArray(array);
                decimal arithmeticMean = ArrayUtilities.ArrayUtilities.ArithmeticMeanofElements(array);


                if (indexofMin == int.MinValue)
                {
                    Console.WriteLine("The array was not in a good format!");
                }
                else
                {
                    Console.WriteLine($"The array has its minimum at index no {indexofMin} ");
                    Console.WriteLine($"The array has its maximum at index no {indexOfMax} ");
                    Console.WriteLine($"The sum of the elements is {sumOfElements}");
                    Console.WriteLine($"The arithmetic mean of the elements is {arithmeticMean}");
                }
            }
            else
            {
                Console.WriteLine("please enter a valid number!");
            }

        }

        public static int[] ReadArray(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter a number for the array= ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    array[i] = input;
                }
                Console.WriteLine();
            }

            if (array.Length == 0 || array == null)
            {
                return new int[0];
            }

            return array;
        }
    }
}
