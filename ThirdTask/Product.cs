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

        internal static IEnumerable<Product> SelectProducts(int price, IEnumerable<Product> products)
        {
            return products.Where(product => product.Price < price).OrderBy(product => product.Name);
        }

        /// <summary> 
        /// Конструктор. 
        /// </summary> 
        internal Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
