using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");
            try
            {
                Console.Write("Please enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the code for operation:\n\t1 - add\n\t2 - sub\n\t3 - mult\n\t4 - div");
                int operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your input: {0}", operation);
                if (operation < 0 || operation > 4)
                {
                    throw new Exception(String.Format("Error! Passed incorrect number: {0}", operation));
                }
                double result = 0;
                switch (operation)
                {
                    case 1:
                        result = a + b;
                        break;
                    case 2:
                        result = a - b;
                        break;
                    case 3:
                        result = a * b;
                        break;
                    case 4:
                        result = a / b;
                        break;
                }
                Console.WriteLine("Result: {0}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
