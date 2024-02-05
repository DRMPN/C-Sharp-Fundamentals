using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareNum(9);
            CompareNumSequence();
            Console.WriteLine(SquareAmountInRectangle(3, 3, 1));
            Console.WriteLine(SquareAmountInRectangle(1, 1, 1));
            Console.WriteLine(SquareAmountInRectangle(1, 5, 2));
            Console.ReadKey();
        }

        static int SquareNum(int num)
        {
            // Ввести целое число N > 0.
            // Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1).
            // После добавления к сумме каждого слагаемого выводить текущее значение суммы
            //  (в результате будут выведены квадраты всех целых чисел от 1 до N).
            int square = 0;
            for (int i = 1; i <= 2 * num - 1; i += 2)
            {
                square += i;
                Console.WriteLine(square);
            }
            return square;
        }

        static void CompareNumSequence()
        {
            // Осуществить ввод последовательности целых чисел и сравнить, что больше,
            //  количество положительных или количество отрицательных.
            // Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
            int pos = 0;
            int neg = -1;
            int input = 0;
            Console.WriteLine("Compare sequence of numbers. Write 0 to finish input.");
            do
            {
                Console.Write("Please enter any number: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0) { pos++; }
                else { neg++; }
            } while (input != 0);
            if (pos == neg)
            {
                Console.WriteLine("Amount of positive and negative numbers is equal");
            }
            else
            {
                Console.WriteLine("Amount of {0} numbers is greater", pos > neg ? "positive" : "negative");
            }
        }

        static int SquareAmountInRectangle(int a, int b, int c)
        {
            // Ввести положительные числа A, B, C.
            // На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).
            // Найти количество квадратов, размещенных на прямоугольнике.
            // Операции умножения и деления не использовать.
            int amount = 0;
            int tmp_a = a;
            int tmp_b = b;
            while (a >= c)
            {
                a -= c;
                while (b >= c)
                {
                    b -= c;
                    amount++;
                }
                b = tmp_b;
            }
            return amount;
        }
    }
}
