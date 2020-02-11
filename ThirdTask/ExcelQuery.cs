using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    /// <summary> 
    /// Класс "Запрос к Excel". 
    /// </summary>
    internal static class ExcelQuery
    {
        /// <summary> 
        /// Выборка товаров ниже указанной цены. 
        /// </summary> 
        /// <param name="price">Цена.</param> 
        /// <param name="products">Список товаров.</param> 
        internal static IEnumerable<Product> SelectProducts(int price, IEnumerable<Product> products)
        {
            return products.Where(product => product.Price < price).OrderBy(product => product.Name);
        }
    }
}
