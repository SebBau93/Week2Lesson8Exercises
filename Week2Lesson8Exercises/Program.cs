using System;

namespace Week2Lesson8Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            //Exercise1();

            #endregion

            #region Exercise 2

            //Exercise2();

            #endregion

            #region Exercise 3

            Exercise3();

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
            Console.WriteLine("0");
            Console.WriteLine("1");

            int previousValue = 0;

            for(int i = 1; i < 10000; i++)
            {

                int sum = i + previousValue;

                Console.WriteLine(sum);

                previousValue = sum;
            }
        }
    }
}
