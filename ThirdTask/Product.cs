using System.Collections.Generic;
using System.Linq;

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
        internal string Name { get; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        internal int Price { get; }

        /// <summary> 
        /// Конструктор. 
        /// </summary> 
        /// <param name="name">Название.</param> 
        /// <param name="price">Цена.</param> 
        internal Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
