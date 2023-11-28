using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapa2._4.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            // список договорів на охорону квартир
            List<(int apartmentNumber, string owner, string phoneNumber, int alarmFee, int fine, int monthlyPayment,int Polic)> contracts = new List<(int, string, string, int, int, int,int)>();

           
            contracts.Add((101, "Михайло Володимирович", "123-456-7890", 100, 50, 500,2));
            contracts.Add((202, "Надія Григорівна", "987-654-3210", 150, 60, 600,1));
            contracts.Add((303, "Олег Андрійович", "111-222-3333", 120, 70, 550,3));
            contracts.Add((98, "Степан Михайлович", "145-345-4343", 30, 70, 550,4));
            contracts.Add((34, "Іванна Мирославівна", "239-897-5432", 30, 70, 550, 4));
            contracts.Add((111, "Христина Мирославівна", "505-606-6666", 140, 90, 690, 3));
            contracts.Add((112, "Оксана Петрівна", "987-654-3210", 150, 75, 700, 1));
            contracts.Add((99, "Ігор Ігорович", "555-123-4567", 200, 60, 600, 3));
            contracts.Add((23, "Наталія Василівна", "777-888-9999", 120, 40, 400, 1));
            contracts.Add((34, "Андрій Олександрович", "111-222-3333", 80, 30, 300, 2));
            contracts.Add((56, "Марія Павлівна", "333-777-1111", 250, 100, 800, 3));
            contracts.Add((107, "Олена Іванівна", "555-555-5555", 90, 20, 200, 1));
            contracts.Add((210, "Петро Петрович", "777-777-7777", 110, 45, 450, 2));
            contracts.Add((122, "Софія Олександрівна", "222-333-4444", 180, 70, 700, 1));
            contracts.Add((1, "Василь Васильович", "444-444-4444", 130, 55, 550, 3));

            Console.WriteLine("Введіть номер квартири для пошуку:");
            int searchfine = int.Parse(Console.ReadLine());
            int Polic = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (var contract in contracts)
            {
                if (contract.fine == searchfine)
                {
                    Console.WriteLine($"Номер квартири: {contract.apartmentNumber}");
                    Console.WriteLine($"Власник: {contract.owner}");
                    Console.WriteLine($"Телефон власника: {contract.phoneNumber}");
                    Console.WriteLine($"Оплата за встановлення сигналізації: {contract.alarmFee} грн");
                    Console.WriteLine($"Розмір штрафу за невчасне відключення сигналізації: {contract.fine} грн");
                    Console.WriteLine($"Щомісячна оплата за охорону квартири: {contract.monthlyPayment} грн");
                    Console.WriteLine($"Кількість виїздів патрульних: {contract.Polic}");

                    found = true;
                }
                else if (contract.Polic == searchfine)
                {
                    Console.WriteLine($"Номер квартири: {contract.apartmentNumber}");
                    Console.WriteLine($"Власник: {contract.owner}");
                    Console.WriteLine($"Телефон власника: {contract.phoneNumber}");
                    Console.WriteLine($"Оплата за встановлення сигналізації: {contract.alarmFee} грн");
                    Console.WriteLine($"Розмір штрафу за невчасне відключення сигналізації: {contract.fine} грн");
                    Console.WriteLine($"Щомісячна оплата за охорону квартири: {contract.monthlyPayment} грн");
                    Console.WriteLine($"Кількість виїздів патрульних: {contract.Polic}");

                    found = true;
                }
                
            }

            if (!found)
            {
                Console.WriteLine($"Договір для квартири з номером {searchfine} не знайдено.");
            }
        }
    }
}
    

