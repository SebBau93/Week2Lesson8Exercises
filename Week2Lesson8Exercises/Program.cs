using System;
using System.Collections.Generic;

namespace Week2Lesson8Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            Exercise1();

            #endregion

            #region Exercise 2

            Exercise2();

            #endregion

            #region Exercise 3

            Exercise3();

            #endregion

            #region Exercise 4

            Exercise4();

            #endregion

            #region Exercise 5

            Exercise5();

            #endregion

            #region Exercise 6

            Exercise6();

            #endregion

            #region Exercise 7

            Exercise7();

            #endregion

            #region Exercise 8

            Exercise8();

            #endregion

            #region Exercise 9

            Exercise9();

            #endregion

            #region Exercise 10

            Exercise10();

            #endregion
        }

        private static void Exercise1()
        {
            bool isPrimeNumber = true;
            int primeCounter = 0;

            for(int i = 0; i <= 100; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0 && j!= 1)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                if (isPrimeNumber)
                    primeCounter++;

                isPrimeNumber = true;
            }

            Console.WriteLine($"For range 0 - 100 are {primeCounter} numbers.");
        }

        private static void Exercise2()
        {
            int value = 0;

            do
            {
                if (value % 2 == 0)
                    Console.WriteLine(value);

                value++;
            } while (value <= 1000);
        }

        private static void Exercise3()
        {
            int count = 50;

            Console.WriteLine("0");
            Console.WriteLine("1");

            long previousValue = 0;
            long nextValue = 1;

            for (int i = 1; i <= count - 2; i++)
            {

                long sum = previousValue + nextValue;

                Console.WriteLine(sum);

                previousValue = nextValue;
                nextValue = sum;
            }
        }

        private static void Exercise4()
        {
            Console.WriteLine("Enter a number count:");

            Int32.TryParse(Console.ReadLine(), out int count);

            Console.WriteLine();

            int numbersInRow = 1;
            int numberToDisplay = 1;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < numbersInRow; j++)
                {
                    Console.Write(numberToDisplay + " ");
                    numberToDisplay++;
                }

                numbersInRow++;
                Console.WriteLine();
            }
        }

        private static void Exercise5()
        {
            byte count = 20;

            for (int i = 1; i <= count; i++)
                Console.WriteLine(Math.Pow(i, 3));
        }

        private static void Exercise6()
        {
            float sum = 0;
            for (float i = 1; i <= 20; i++)
            {
                sum += 1 / i;
                Console.WriteLine(sum);
            }
        }

        private static void Exercise7()
        {
            Console.WriteLine("Enter length for shorter diagonal:");
            Int32.TryParse(Console.ReadLine(), out int shorterDiagonalLength);

            int starsInRow = -1;
            int spacesInRow = Convert.ToInt32(Math.Round(Convert.ToDecimal(shorterDiagonalLength) / 2)) + 1;
            int shorterDiagonalRow = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(shorterDiagonalLength) / 2));

            for (int i = 0; i < shorterDiagonalLength; i++)
            {
                if (i < shorterDiagonalRow)
                {
                    starsInRow += 2;
                    spacesInRow--;

                    for (int j = 0; j < spacesInRow; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < starsInRow; k++)
                    {
                        Console.Write("*");
                    }
                   
                }
                else
                {
                    spacesInRow++;
                    starsInRow -= 2;

                    for (int j = 0; j < spacesInRow; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < starsInRow; k++)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }

        private static void Exercise8()
        {
            Console.WriteLine("Enter value to be reversed:");
            string value = Console.ReadLine();

            char[] array;

            array = value.ToCharArray(0, value.Length);

            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i]);
        }

        private static void Exercise9()
        {
            Console.WriteLine("Enter value to convert to binary value:");
            Int32.TryParse(Console.ReadLine(), out int numberToConvert);

            int divisionScore = numberToConvert;

            List<int> restOfDivision = new List<int>();

            do
            {
                restOfDivision.Add(divisionScore % 2);
                divisionScore = divisionScore / 2;
            } while (divisionScore > 0);

            restOfDivision.Reverse();

            foreach (int value in restOfDivision)
                Console.Write(value);
        }

        private static void Exercise10()
        {
            Console.WriteLine("Enter first number");
            Int32.TryParse(Console.ReadLine(), out int firstNumber);

            Console.WriteLine("Enter second number");
            Int32.TryParse(Console.ReadLine(), out int secondNumber);

            int restOfDivision;
            int firstNumberToDivide;
            int secondNumberToDivide;

            if (firstNumber > secondNumber)
            {
                firstNumberToDivide = firstNumber;
                secondNumberToDivide = secondNumber;
            }
            else
            {
                firstNumberToDivide = secondNumber;
                secondNumberToDivide = firstNumber;
            }

            do
            {
                restOfDivision = firstNumberToDivide % secondNumberToDivide;
                firstNumberToDivide = secondNumberToDivide;
                secondNumberToDivide = restOfDivision;
            } while (restOfDivision > 0);

            int greatestCommonDivisor = firstNumberToDivide;

            int leastCommonMultiple = (firstNumber * secondNumber) / greatestCommonDivisor;

            Console.WriteLine($"Least common multiple for {firstNumber} and {secondNumber} is {leastCommonMultiple}");
        }
    }
}