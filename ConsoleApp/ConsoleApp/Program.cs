using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write any number: ");
            int abc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You wrote number: {0}", abc);
            Console.ReadKey();
        }
    }
}
