using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        // Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
        // Проверить, корректно ли в ней расставлены скобки.
        // Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
        //
        // Указание: задача решается однократным проходом по символам заданной строки слева направо;
        // для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
        // каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
        // (при этом скобка с вершины стека снимается);
        // в конце прохода стек должен быть пуст.
        static void Main(string[] args)
        {
            string goodStr = "([]{})[]";
            string badStr = "([]]";
            string badStr1 = "(()))";
            Console.WriteLine(CheckBrackets(goodStr));
            Console.WriteLine(CheckBrackets(badStr));
            Console.WriteLine(CheckBrackets(badStr1));
            Console.ReadKey();
        }

        static bool CheckBrackets(string str)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' }, };

            Stack<char> st = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(dict[c]);
                }
                if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0 || c != st.Pop())
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
