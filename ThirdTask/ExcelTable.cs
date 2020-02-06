using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ThirdTask
{
    /// <summary> 
    /// Класс "Таблица Excel". 
    /// </summary>
    internal static class ExcelTable
    {
        /// <summary> 
        /// Создать таблицу Excel и заполнить ее отсортированными данными. 
        /// </summary> 
        /// <param name="price">Значение цены товара для сортировки.</param> 
        /// <param name="products">Список товаров.</param> 
        internal static void CreateExcelTable(int price, List<Product> products)
        {
            // Инициализация COM-объекта документа Excel
            Application excelApp = new Application();
            excelApp.Visible = true;
            Workbook book = excelApp.Workbooks.Add(1);
            Worksheet sheet = book.Sheets[1];
            sheet.Name = "Товары стоимостью ниже " + price;

            // Выборка подходящих товаров из списка
            IEnumerable<Product> selectedProducts = from product in products
                                             where product.Price < price
                                             orderby product.Name
                                             select product;

            // Заполнение таблицы Excel выбранными данными
            int cellsCount = 0;
            foreach (Product product in selectedProducts)
            {
                cellsCount++;
                sheet.Cells[cellsCount, 1] = product.Name;
                sheet.Cells[cellsCount, 2] = product.Price;
            }
        }
    }
}
