using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        // Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать.
        // Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом.
        // Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз.
        // Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево.
        // Если садовник видит, что участок сада уже выполнен другим садовником, он идет дальше.
        // Садовники должны работать параллельно.
        // Создать многопоточное приложение, моделирующее работу садовников.
        static int x = 10;
        static int y = 10;
        static int[,] field = new int[x, y];
        
        static void Main(string[] args)
        {
            for (int i = 0; i < x; i++)
            {
                for (int n = 0; n < y; n++)
                {
                    field[i, n] = 0;
                }
            }

            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardener2();

            for (int i = 0; i < x; i++)
            {
                for (int n = 0; n < y; n++)
                {
                    Console.Write($"{ field[i, n]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Gardener1()
        {
            for (int i = 0; i < x; i++)
            {
                for (int n = 0; n < y; n++)
                {
                    if (field[i, n] == 0)
                    {
                        field[i, n] = 1;
                        Thread.Sleep(2);
                    }
                }
            }
        }

        static void Gardener2()
        {
            for (int i = y-1; i >= 0; i--)
            {
                for (int n = x-1; n >= 0; n--)
                {
                    if (field[n, i] == 0)
                    {
                        field[n, i] = 2;
                        Thread.Sleep(1);
                    }
                }
            }
        }

    }
}
