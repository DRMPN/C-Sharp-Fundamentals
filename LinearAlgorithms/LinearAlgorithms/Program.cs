using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle raduis and area: {0}", CircleAnalytics(5));
            Console.WriteLine("Rectangle perimeter and area: {0}", RectangleAnalytics(1,1, 8,7));
            Console.WriteLine("Triangle perimeter and area: {0}", TriangleAnalytics(-4,2, 0,-1, 3,3));
            Console.ReadKey();
        }

        public static (double, double) CircleAnalytics(double C)
        {
            // Дана длина L окружности.
            // Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
            double r = C / 2 * Math.PI;
            double area = Math.PI * Math.Pow(r, 2);
            return (r,area);
        }

        public static (double, double) RectangleAnalytics(double x1, double y1, double x2, double y2)
        {
            // Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2).
            // Стороны прямоугольника параллельны осям координат.
            // Найти периметр и площадь данного прямоугольника.
            double l = Math.Sqrt(Math.Pow(x2 - x1, 2));
            double w = Math.Sqrt(Math.Pow(y2 - y1, 2));
            double perimeter = 2*(l + w);
            double area = l*w;
            return (perimeter, area);
        }

        public static (double, double) TriangleAnalytics(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
            // Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости.
            // Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона.
            double AB = Math.Sqrt(Math.Pow(x1 - x2, 2)+ Math.Pow(y1 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double BC = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            double perimeter = AB + AC + BC;
            double p = perimeter / 2;
            double area = Math.Sqrt(p*(p-AB)*(p-AC)*(p-BC));
            return (perimeter, area);
        }
    }
}
