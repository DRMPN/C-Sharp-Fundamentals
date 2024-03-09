using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,
        // типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти,
        // объемом жесткого диска, объемом памяти видеокарты,
        // стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
        // Создать список, содержащий 6-10 записей с различным набором значений характеристик.
        //
        // Определить:
        // - все компьютеры с указанным процессором. Название процессора запросить у пользователя;
        // - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
        // - вывести весь список, отсортированный по увеличению стоимости;
        // - вывести весь список, сгруппированный по типу процессора;
        // - найти самый дорогой и самый бюджетный компьютер;
        // - есть ли хотя бы один компьютер в количестве не менее 30 штук?
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Id = 1, Brand = "HP", CPUType = "x64", CPUFrequency = 2.33, RAM = 8, VRAM = 2, VolumeSize = 500, Price = 10, Amount = 5 },
                new Computer() { Id = 2, Brand = "Lenovo", CPUType = "x86", CPUFrequency = 3.5, RAM = 16, VRAM = 4, VolumeSize = 250, Price = 15, Amount = 15 },
                new Computer() { Id = 3, Brand = "Xiaomi", CPUType = "x64", CPUFrequency = 3.3, RAM = 32, VRAM = 1, VolumeSize = 1000, Price = 10, Amount = 25 },
                new Computer() { Id = 4, Brand = "Apple", CPUType = "ARM", CPUFrequency = 4.5, RAM = 64, VRAM = 6, VolumeSize = 500, Price = 30, Amount = 15 },
                new Computer() { Id = 5, Brand = "Huawei", CPUType = "x64", CPUFrequency = 5.5, RAM = 32, VRAM = 2, VolumeSize = 250, Price = 50, Amount = 5 },
                new Computer() { Id = 6, Brand = "Lenovo", CPUType = "x86", CPUFrequency = 2.33, RAM = 8, VRAM = 1, VolumeSize = 750, Price = 30, Amount = 10 },
                new Computer() { Id = 7, Brand = "HP", CPUType = "x86", CPUFrequency = 3.3, RAM = 32, VRAM = 6, VolumeSize = 1200, Price = 20, Amount = 20 },
                new Computer() { Id = 8, Brand = "Apple", CPUType = "ARM", CPUFrequency = 4.2, RAM = 16, VRAM = 12, VolumeSize = 150, Price = 15, Amount = 25 }
            };

            Console.WriteLine("Write CPU type: ");
            string cpu = Console.ReadLine();
            computers.Where(c => c.CPUType == cpu);

            Console.WriteLine("Write RAM size in GB: ");
            int ram = Convert.ToInt32(Console.ReadLine());
            computers.Where(c => c.RAM >= ram);

            Console.WriteLine("Ordered by price:");
            List<Computer> sortedPrice = computers.OrderBy(c=>c.Price).ToList();
            foreach (Computer c in sortedPrice)
	        {
                Console.WriteLine($"{c.Id} {c.Brand} {c.Price}");
	        }

            Console.WriteLine("Group by CPU type:");
            List<IGrouping<string, Computer>> groupedByCPU = computers.GroupBy(c => c.CPUType).ToList();
            foreach (var c in groupedByCPU)
	        {
                Console.WriteLine(c.Key);
	        }

            computers.Max(c=> c.Price);
            computers.Min(c=> c.Price);

            computers.Any(c => c.Amount >= 30);

            Console.ReadKey();
        }
    }
}
