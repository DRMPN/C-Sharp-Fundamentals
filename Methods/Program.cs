using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = ComputeAreaOfTriangle(1, 2, 3);
            double s2 = ComputeAreaOfTriangle(3, 3, 3);
            if (s1 > s2)
            {
                Console.WriteLine("Area of the first triangle is bigger");
            }
            else
            {
                Console.WriteLine("Area of the second triangle is bigger");
            }
            double a = 2;
            GetCubeParams(a, out double v, out double s);
            Console.WriteLine("Volume: {0:F2}, Area {1:F2} of the cube with side length of {2:F2}", v, s, a);
            Console.ReadKey();
        }

        static double ComputeAreaOfTriangle(double a, double b, double c)
        {
            // Два треугольника заданы длинами своих сторон.
            // Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
            // Для решения задачи можно использовать формулу Герона 
            double p = (a + b + c)/2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void GetCubeParams(double a, out double v, out double s)
        {
            // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            v = a * a * a;
            s = 6 * (a * a);
        }

    }
}
