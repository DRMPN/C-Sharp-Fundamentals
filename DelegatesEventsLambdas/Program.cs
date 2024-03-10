using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdas
{
    delegate double MyDelegate(double R);
    class Program
    {
        // В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        //  - метод получает входным параметром переменную типа double;
        //  - метод возвращает значение типа double, которое является результатом вычисления.
        
        // Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        //  - длину окружности по формуле D = 2 * π * R;
        //  - площадь круга по формуле S = π* R²;
        //  - объем шара.Формула V = 4 / 3 * π * R³.
        // Методы должны быть объявлены как статические.
        static void Main(string[] args)
        {
            MyDelegate dlg = GetCircumference;
            dlg += GetArea;
            dlg += GetVolume;
            Console.WriteLine(dlg(2));
            Console.ReadKey();
        }

        static double GetCircumference(double R) => 2 * Math.PI * R;

        static double GetArea(double R) => Math.PI * Math.Pow(R, 2);

        static double GetVolume(double R) => 4.0 / 3 * Math.PI * Math.Pow(R, 3);

    }
}
