using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    class Program
    {
        // Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        // метод, определяющий длину окружности по заданному радиусу;
        // метод, определяющий площадь круга по заданному радиусу;
        // метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.Circumference(3));
            Console.WriteLine(Circle.Area(3));
            Console.WriteLine(Circle.IsPointInCircle(1,1,2,0,0));
            Console.WriteLine(Circle.IsPointInCircle(5,5,4,0,0));
            Console.ReadKey();
        }
    }
}
