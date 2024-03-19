using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        // Сформировать массив случайных целых чисел (размер  задается пользователем).
        // Вычислить сумму чисел массива и максимальное число в массиве.
        // Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Task<int[]> task = new Task<int []>(() => CreateArrayOfRandoms(size));
            Task<int> task2 = task.ContinueWith<int>((t) => ArraySize(t.Result));
            Task<int> task3 = task.ContinueWith<int>((t) => ArrayMax(t.Result));
            
            task.Start();
            Console.WriteLine($"Size: {task2.Result}");
            Console.WriteLine($"Max: {task3.Result}");

            Console.WriteLine("DONE");
            Console.ReadKey();
        }

        static int[] CreateArrayOfRandoms(int size)
        {
            Console.WriteLine("Start CreateArrayOfRandoms");
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 100);
                Thread.Sleep(random.Next(0, 10));            
            }
            Console.WriteLine("End CreateArrayOfRandoms");
            return arr;
        }

        static int ArraySize(int[] arr)
        {
            Console.WriteLine("Start ArraySize");
            int size = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                size++;
                Thread.Sleep(100);
            }
            Console.WriteLine("End ArraySize");
            return size;
        }

        static int ArrayMax(int[] arr)
        {
            Console.WriteLine("Start ArrayMax");
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    Thread.Sleep(5);
                }
            }
            Console.WriteLine("End ArrayMax");
            return max;
        }
    }
}
