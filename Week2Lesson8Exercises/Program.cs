﻿using System;

namespace Week2Lesson8Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            Exercise1();

            #endregion
        }

        private static void Exercise1()
        {
            bool isPrimeNumber = true;

            for(int i = 0; i <= 100; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine($"{i} isn't a prime number.");
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
                    Console.WriteLine($"{i} is a prime number.");
                else
                    Console.WriteLine($"{i} isn't a prime number.");

                isPrimeNumber = true;
            }
        }
    }
}