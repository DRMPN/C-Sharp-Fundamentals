using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWordInSentence());
            Console.WriteLine(IsPalindrome());
            Console.WriteLine(RemoveTextInCurlyBrackets("don't {do} how {cringe} now {hello {hey} {you}}"));
            Console.ReadKey();
        }

        static string LongestWordInSentence()
        {
            // Ввести с клавиатуры предложение.
            // Предложение представляет собой слова, разделенные пробелом.
            // Знаки препинания не используются.
            // Найти самое длинное слово в строке.
            string input = Console.ReadLine();
            string[] words = input.Split();
            string longestWord = words[0];
            foreach (string w in words)
            {
                if (w.Length > longestWord.Length)
                {
                    longestWord = w;
                }
            }
            return longestWord;
        }

        static bool IsPalindrome()
        {
            // Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            // Знаки препинания не используются.
            // Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
            // (пример палиндрома – «А роза упала на лапу Азора»).
            bool isPalindrome = true;
            string input = Console.ReadLine();
            string words = String.Join("", input.Split()).ToLower();
            Console.WriteLine(words);
            for (int i = 0, j = words.Length-1; i < words.Length; i++, j--)
            {
                isPalindrome = isPalindrome && words[j] == words[i];
            }
            return isPalindrome;
        }

        static string RemoveTextInCurlyBrackets(string str)
        {
            // Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
            // В строке может быть несколько фрагментов, заключённых в фигурные скобки.
            // Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
            int count = 0;
            string clean = "";
            foreach (char c in str)
            {
                if (c == '{')
                {
                    count++;
                    clean += c;
                }
                else if (c == '}')
                {
                    count--;
                    clean += c;
                }
                else if (count == 0)
                {
                    clean += c;
                }
            }
            return clean;
        }

    }
}
