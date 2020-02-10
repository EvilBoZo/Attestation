using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace ThirdTask
{
    /// <summary> 
    /// Класс "Таблица Excel". 
    /// </summary>
    internal sealed class ExcelTable
    {
        /// <summary> 
        /// Приложение Excel. 
        /// </summary> 
        private Application app;

        /// <summary> 
        /// Книга Excel. 
        /// </summary> 
        private Workbook book;

        /// <summary> 
        /// Страница книги Excel. 
        /// </summary> 
        private Worksheet sheet;

        /// <summary> 
        /// Создать таблицу Excel и заполнить ее отсортированными данными. 
        /// </summary> 
        /// <param name="price">Значение цены товара для сортировки.</param> 
        /// <param name="products">Список товаров.</param> 
        internal void Create(IEnumerable<Product> selectedProducts)
        {
            app.Visible = true;
            book = app.Workbooks.Add(1);
            sheet = book.Sheets[1];

            int cellsCount = 0;
            foreach (Product product in selectedProducts)
            {
                cellsCount++;
                this.sheet.Cells[cellsCount, 1] = product.Name;
                this.sheet.Cells[cellsCount, 2] = product.Price;
            }
        }

        /// <summary> 
        /// Конструктор. 
        /// </summary> 
        internal ExcelTable()
        {
            app = new Application();
        }
    }
}
