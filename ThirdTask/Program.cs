using System;
using System.Collections.Generic;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и заполнение списка товаров тестовыми данными
            ExcelTable excelTable = new ExcelTable();
            List<Product> products = new List<Product>();
            for (int i = 10; i > 0; i--)
            {
                products.Add(new Product("Товар №" + i, 9995 + i));
            }

            // Проверка корректности работы класса ExcelTable
            Console.WriteLine("Введите стоимость:");
            excelTable.Create(ExcelQuery.SelectProducts(Convert.ToInt16(Console.ReadLine()), products));
        }
    }
}
