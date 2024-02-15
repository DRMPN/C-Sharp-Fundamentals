using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFiles();
            SumOfRandomNumbers();
            GetFileStatistics();
            Console.ReadKey();
        }

        static void PrintFiles()
        {
            // Выберите любую папку на своем компьютере, имеющую вложенные директории.
            // Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            string path = @"..\..\..\";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        static void SumOfRandomNumbers()
        {
            // Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            // Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
            string filename = "RemoveMe.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(filename))
            {
                for (int i = 0; i < 10; i++)
                {
                    int num = Convert.ToInt32(sr.ReadLine());
                    sum += num;
                }
                
            }
            Console.WriteLine(sum);
            File.Delete(filename);
        }

        static void GetFileStatistics()
        {
            // Вручную подготовьте текстовый файл с фрагментом текста.
            // Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
            int symbolCount = 0;
            int lineCount = 0;
            int wordCount = 0;
            string filename = "Task8.txt";
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) !=null)
                {
                    lineCount++;
                    for (int i = 0; i < line.Length; i++)
                    {
                        symbolCount++;
                    }
                    foreach (var word in line.Split(' '))
                    {
                        wordCount++;
                    }
                }
                
            }
            Console.WriteLine("Symbols: {0}, Lines: {1}, Words: {2}", symbolCount, lineCount, wordCount);
        }

    }
}
