using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        // Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        // Реализовать класс, в котором указанные значения представлены в виде свойств.
        // Для свойств предусмотреть проверку корректности данных.
        // Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
        // Создать объект на основе разработанного класса.
        // Осуществить использование объекта в программе.
        static void Main(string[] args)
        {
            Angle angle = new Angle(55, 45, 0);
            Console.WriteLine(angle.ToRadians());
            Console.ReadKey();
        }
    }
}
