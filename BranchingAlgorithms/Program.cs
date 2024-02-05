using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            FindRectanglePoint(1, 3, 3, 3, 3, 1);
            FindRectanglePoint(1,1,3,1,3,3);
            FindRectanglePoint(1,3,1,1,3,1);
            FindRectanglePoint(3,3,1,1,1,3);
            FindClosestPoint(1, 1, 3, 3, 3, 1);
            FindClosestPoint(1, 1, 1, 3, 3, 1);
            AgeToText(19);
            AgeToText(70);
            AgeToText(20);
            AgeToText(33);
            AgeToText(42);
            AgeToText(63);
            AgeToText(69);
            NumToText(99);
            NumToText(1000);
            NumToText(123);
            NumToText(200);
            NumToText(550);
            NumToText(811);
            Console.ReadKey();
        }

        public static void FindRectanglePoint(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            // Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям.
            // Найти координаты его четвертой вершины.
            // Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,
            // параллельными координатным осям, вывести соответствующее сообщение.
            if ((x1 != x2) && (y1 != y2))
            {
                if ((x1 == x3) && (y1 != y3))
                {
                    Console.WriteLine("x4: {0}, y4: {1}", y3, x1);
                }
                else
                {
                    Console.WriteLine("x4: {0}, y4: {1}", x1, x3);
                }
            }
            else if ((x1 == x2) && (y1 != y2))
            {
                if ((x1 != x3) && (y1 == y3))
                {
                    Console.WriteLine("x4: {0}, y4: {1}", y1, x1);
                }
                else
                {
                    Console.WriteLine("x4: {0}, y4: {1}", x3, y1);
                }
            }
            else if ((x1 != x2) && (y1 == y2))
            {
                if ((x1 == x3) && (y1 != y3))
                {
                    Console.WriteLine("x4: {0}, y4: {1}", y3, y3);
                }
                else
                {
                    Console.WriteLine("x4: {0}, y4: {1}", x1, y3);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }

        public static void FindClosestPoint(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // На числовой оси расположены три точки: A, B, C.
            // Определить, какая из двух последних точек (B или C) расположена ближе к A,
            //  и вывести эту точку и ее расстояние от точки A.
            // Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А,
            //  совпадать с А или между собой - выдать соответствующее сообщение.
            double AB = Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2 - y1, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            if (AB > AC)
            {
                Console.WriteLine("Closest Point: {0} {1}, Distance: {2}", x3, y3, AC);
            }
            else if (AB < AC)
            {
                Console.WriteLine("Closest Point: {0} {1}, Distance: {2}", x2, y2, AB);
            }
            else
            {
                Console.WriteLine("No difference");
            }
        }

        public static void AgeToText(int age)
        {
            // Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
            // Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год»,
            //  например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».
            // Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
            if ((20 <= age) && (age <= 69))
            {
                int frstNum = age / 10;
                int scndNum = age % 10;
                string frstWord;
                string scndWord;
                switch (frstNum)
                {
                    case 2:
                        frstWord = "Двадцать";
                        break;
                    case 3:
                        frstWord = "Тридцать";
                        break;
                    case 5:
                        frstWord = "Пятьдесят";
                        break;
                    case 6:
                        frstWord = "Шестьдесят";
                        break;
                    default:
                        frstWord = "Сорок";
                        break;
                }
                switch (scndNum)
                {
                    case 1:
                        scndWord = "один год";
                        break;
                    case 2:
                        scndWord = "два года";
                        break;
                    case 3:
                        scndWord = "три года";
                        break;
                    case 4:
                        scndWord = "четыре года";
                        break;
                    default:
                        scndWord = "лет";
                        break;
                }
                Console.WriteLine("{0} {1}", frstWord, scndWord);
            }
            else
            {
                Console.WriteLine("Incorrect age: {0}, should be between 20 an 69", age);
            }
        }

        public static void NumToText(int num)
        {
            // Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа,
            //  например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
            // Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 
            if ((100 <= num) && (num <= 999))
            {
                int frstDigit = num/100;
                int scndDigit = num/10%10;
                int thrdDigit = num%10;
                string frstWord;
                string scndWord;
                string thrdWord;
                switch (frstDigit)
                {
                    case 1:
                        frstWord = "Сто";
                        break;
                    case 2:
                        frstWord = "Двести";
                        break;
                    case 3:
                        frstWord = "Триста";
                        break;
                    case 4:
                        frstWord = "Четыреста";
                        break;
                    case 5:
                        frstWord = "Пятьсот";
                        break;
                    case 6:
                        frstWord = "Шестьсот";
                        break;
                    case 7:
                        frstWord = "Семьсот";
                        break;
                    case 8:
                        frstWord = "Восемьсот";
                        break;
                    case 9:
                        frstWord = "Девятьсот";
                        break;
                    default:
                        frstWord = "";
                        break;
                }
                switch (scndDigit)
                {
                    case 1:
                        switch (thrdDigit)
                        {
                            case 1:
                                scndWord = "Одиннадцать";
                                break;
                            case 2:
                                scndWord = "Двенадцать";
                                break;
                            case 3:
                                scndWord = "Тринадцать";
                                break;
                            case 4:
                                scndWord = "Четырнадцать";
                                break;
                            case 5:
                                scndWord = "Пятнадцать";
                                break;
                            case 6:
                                scndWord = "Шестнадцать";
                                break;
                            case 7:
                                scndWord = "Семнадцать";
                                break;
                            case 8:
                                scndWord = "Восемнадцать";
                                break;
                            case 9:
                                scndWord = "Девятнадцать";
                                break;
                            default:
                                scndWord = "Десять";
                                break;
                        }
                        Console.WriteLine("{0} {1}", frstWord, scndWord);
                        return;
                    case 2:
                        scndWord = "Двадцать";
                        break;
                    case 3:
                        scndWord = "Тридцать";
                        break;
                    case 4:
                        scndWord = "Сорок";
                        break;
                    case 5:
                        scndWord = "Пятьдесят";
                        break;
                    case 6:
                        scndWord = "Шестьдесят";
                        break;
                    case 7:
                        scndWord = "Семьдесят";
                        break;
                    case 8:
                        scndWord = "Восемьдесят";
                        break;
                    case 9:
                        scndWord = "Девяносто";
                        break;
                    default:
                        scndWord = "";
                        break;
                }
                switch (thrdDigit)
                {
                    case 1:
                        thrdWord = "Один";
                        break;
                    case 2:
                        thrdWord = "Два";
                        break;
                    case 3:
                        thrdWord = "Три";
                        break;
                    case 4:
                        thrdWord = "Четыре";
                        break;
                    case 5:
                        thrdWord = "Пять";
                        break;
                    case 6:
                        thrdWord = "Шесть";
                        break;
                    case 7:
                        thrdWord = "Семь";
                        break;
                    case 8:
                        thrdWord = "Восемь";
                        break;
                    case 9:
                        thrdWord = "Девять";
                        break;
                    default:
                        thrdWord = "";
                        break;
                }
                Console.WriteLine("{0} {1} {2}", frstWord, scndWord, thrdWord);
            }
            else
            {
                Console.WriteLine("Incorrect number: {0}, should be between 100 an 999", num);
            }
        }
    }
}
