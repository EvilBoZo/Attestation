using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    /// <summary>
    /// Структура "Товар".
    /// </summary>
    internal struct Product
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        internal string Name { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        internal int Price { get; set; }

        /// <summary> 
        /// Создать экземпляр класса на основе переданных значений названия и цены. 
        /// </summary> 
        /// <param name="name">Название товара.</param> 
        /// <param name="price">Цена товара.</param> 
        /// <remarks>
        /// Данный конструктор позволяет при создании экземпляра класса 
        /// сразу проинициализировать его значениями указанных названия и цены.
        /// </remarks> 
        internal Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
