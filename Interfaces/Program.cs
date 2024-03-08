using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        // Разработать интерфейс ISeries генерации ряда чисел.
        // Интерфейс содержит следующие элементы:
        //      метод void SetStart(int x) - устанавливает начальное значение
        //      метод int GetNext() - возвращает следующее число ряда
        //      метод void Reset() - выполняет сброс к начальному значению
        // Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
        // В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
        static void Main(string[] args)
        {
            Console.WriteLine("Arith:");
            ArithProgression ap = new ArithProgression();
            ap.SetStep(5); 
            ap.SetStart(5);
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            ap.Reset();
            Console.WriteLine(ap.GetNext());
            Console.WriteLine("Geom:");
            GeomProgression gp = new GeomProgression();
            gp.SetStep(5);
            gp.SetStart(5);
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());
            gp.Reset();
            Console.WriteLine(gp.GetNext());
            Console.ReadKey();
        }
    }
}
