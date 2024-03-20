using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        // Разработать асинхронный метод для вычисления факториала числа.
        // В методе Main выполнить проверку работы метода.
        static void Main(string[] args)
        {
            Console.Write("Enter value to calculate factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Factorial of {n} - ");
            FactorialAsync(n);

            Console.ReadKey();
        }

        static long Factorial(int n)
        {
            long s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
            }
            Thread.Sleep(200);
            return s;
        }

        static async void FactorialAsync(int n)
        {
            long r = await Task.Run(() => Factorial(n));
            Console.WriteLine(r);
        }
    }
}
