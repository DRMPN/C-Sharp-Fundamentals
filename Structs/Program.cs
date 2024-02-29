using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        // Разработать структуру для решения линейного уравнения 0=kx+b.
        // Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        // Для решения уравнения предусмотреть метод Root.
        // Создать экземпляр разработанной структуры.
        // Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            LinearEquation le = new LinearEquation(5, 4);
            Console.WriteLine(le.Root());
            Console.ReadKey();
        }
    }
}
