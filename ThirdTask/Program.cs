using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание и заполнение списка товаров тестовыми данными
            List<Product> products = new List<Product>();
            for (int i = 10; i > 0; i--)
            {
                products.Add(new Product("Товар №" + i, 9995 + i));
            }

            // Проверка корректности работы класса ExcelTable
            Console.WriteLine("Введите стоимость:");
            ExcelTable.CreateExcelTable(Convert.ToInt16(Console.ReadLine()), products);
        }
    }
}
