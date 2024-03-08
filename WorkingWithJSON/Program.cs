using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace WorkingWithJSON
{
    class Program
    {
        // 1.   Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.
        //  Разработать класс для моделирования объекта «Товар».
        //  Предусмотреть члены класса
        //      «Код товара» (целое число),
        //      «Название товара» (строка),
        //      «Цена товара» (вещественное число).
        //  Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
        //  Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».
        //
        // 2.   Необходимо разработать программу для получения информации о товаре из json-файла.
        //  Десериализовать файл «Products.json» из задачи 1.
        //  Определить название самого дорогого товара.
        static void Main(string[] args)
        {
            const int amount = 5;
            const string fileName = "../../Products.json";

            // 1 Task
            Product[] products = new Product[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Enter code of the product: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of the product: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price of the product: ");
                double price = Convert.ToDouble(Console.ReadLine());
                products[i] = new Product() { Code = code, Name = name, Price = price };
                Console.WriteLine("Product Added!");
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(JsonSerializer.Serialize(products));
            }

            // 2 Task
            string jsonString;
            using (StreamReader sr = new StreamReader(fileName))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products1 = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product MVP = products1[0];
            foreach (Product p in products1)
            {
                if (p.Price > MVP.Price) {
                    MVP = p;
                }
            }
            Console.WriteLine($"Most valuable product is {MVP.Name}");
            Console.ReadKey();
        }
    }
}
