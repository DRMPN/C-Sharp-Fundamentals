using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // Создать класс для моделирования счета в банке.
        // Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
        // Класс должен быть объявлен как обобщенный.
        // Универсальный параметр T должен определять тип номера счета.
        // Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
        // Создать  несколько экземпляров класса, параметризированного различными типам.
        // Заполнить его поля и вывести на экран информацию об экземпляре класса.
        static void Main(string[] args)
        {
            BankAccount<int> ba1 = new BankAccount<int>();
            ba1.Number = 1;
            ba1.Balance = 10.01;
            ba1.FullName = "Alice Walter";
            BankAccount<string> ba2 = new BankAccount<string>();
            ba2.Number = "AB0123B";
            ba2.Balance = 15.15;
            ba2.FullName = "Dan Scott";
            BankAccount<double> ba3 = new BankAccount<double>();
            ba3.Number = 1.11112;
            ba3.Balance = 1923874.0982347;
            ba3.FullName = "James Oliver";
            BankAccount<bool> ba4 = new BankAccount<bool>();
            ba4.Number = true;
            ba4.Balance = -0.213;
            ba4.FullName = "Adam Van Clief";
            Console.WriteLine($"Account number: {ba1.Number}\n\tFull Name: {ba1.FullName}\n\tBalance: {ba1.Balance} M $");
            Console.WriteLine($"Account number: {ba2.Number}\n\tFull Name: {ba2.FullName}\n\tBalance: {ba2.Balance} M $");
            Console.WriteLine($"Account number: {ba3.Number}\n\tFull Name: {ba3.FullName}\n\tBalance: {ba3.Balance} M $");
            Console.WriteLine($"Account number: {ba4.Number}\n\tFull Name: {ba4.FullName}\n\tBalance: {ba4.Balance} M $");
            Console.ReadLine();
        }
    }
}
