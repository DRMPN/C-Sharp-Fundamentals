using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateMeanOf7();
            SumOfMinMaxRandom15();
            Sort5asc5desc();
            AmountOfOddPositiveNumbersInEvenIndexes();
            TwoDimensionalArraysPattern();
            IsNEnteredMatrixMagic();
            Console.ReadKey();
        }

        static void CalculateMeanOf7()
        {
            // Сформировать одномерный массив из 7 элементов.
            // Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
            double[] numbers = new double[7];
            Console.WriteLine("Please write 7 numbers to calculate its mean:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter {0} number: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Mean is {0}", numbers.Sum() / 7);
        }

        static void SumOfMinMaxRandom15()
        {
            // Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
            // Определить сумму максимального и минимального элементов массива.
            double sum;
            double min = 0, max = 0;
            Random random = new Random();
            double[] randomNumbers = new double[15];
            for (int i = 0; i < 15; i++)
            {

                double num = random.NextDouble() * 50;
                randomNumbers[i] = num;
                if (i == 0)
                {
                    min = max = num;
                }
                if (min > num) min = num;
                if (max < num) max = num;
            }
            Console.WriteLine("Min: {0:f2} Max: {1:f2}", min, max);
            sum = min + max;
            Console.WriteLine("Sum of min/max random number is: {0:f2}", sum);
        }

        static void Sort5asc5desc()
        {
            // Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
            // Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            int[] frstNums = new int[5];
            int[] scndNums = new int[5];
            Random random = new Random();
            Console.Write("Array: ");
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(-50, 50);
                if (i < 5)
                {
                    frstNums[i] = num;
                }
                else
                {
                    scndNums[i % 5] = num;
                }
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Array.Sort(frstNums);
            Array.Sort(scndNums);
            Console.Write("First 5 in ascending order: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", frstNums[i]);
            }
            Console.WriteLine();
            Console.Write("Last 5 in descending order: ");
            for (int i = 4; i != -1; i--)
            {
                Console.Write("{0} ", scndNums[i]);
            }
            Console.WriteLine();
        }

        static void AmountOfOddPositiveNumbersInEvenIndexes()
        {
            // Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
            // Определить количество нечетных положительных элементов, стоящих на четных местах.
            Random random = new Random();
            int[] nums = new int[20];
            int amount = 0;
            Console.Write("Array: ");
            for (int i = 0; i < 20; i++)
            {
                int num = random.Next(-50, 50);
                nums[i] = num;
                if (num > 0 && num % 2 != 0 && i % 2 == 0)
                {
                    amount++;
                }
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine("Amount of random odd positive numbers in even indexes: {0}", amount);
        }

        static void TwoDimensionalArraysPattern()
        {
            // Запросить у пользователя целочисленное значение N.
            // Сформировать двумерный массив размера NxN следующего вида:
            // 10101
            // 01010
            // 10101
            // 01010
            // 10101
            Console.Write("Write size for pattern: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] pattern = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        pattern[i, j] = 1;
                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        pattern[i, j] = 1;
                    }
                    Console.Write(pattern[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void IsNEnteredMatrixMagic()
        {
            Console.Write("Enter size of square matrix: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[n, n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter value at {0}, {1}: ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            double diagSum = 0;
            double antiDiagSum = 0;
            double rowSum = 0;
            double colSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        diagSum += matrix[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        antiDiagSum += matrix[i, j];
                    }
                    rowSum += matrix[i, j];
                }
            }
            Console.WriteLine("{0}, {1}", diagSum, antiDiagSum);
            if (diagSum != antiDiagSum)
            {
                Console.WriteLine("Matrix is not magic");
            }
            else
            {
                Console.WriteLine("Matrix is magic");
            }
        }

    }
}
