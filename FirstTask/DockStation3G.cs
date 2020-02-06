using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Базовая станция с 3G". 
    /// </summary>
    public class DockStation3G : DockStation
    {
        /// <summary> 
        /// Список специальных 3G свойств зарегестрированных телефонов. 
        /// </summary>
        public List<string> PropertysFor3G { get; private set; } = new List<string>();

        /// <summary> 
        /// Зарегистрировать телефон с полученным IMEI. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        public void RegisterPhone(string imei, string propertyFor3G)
        {
            this.Imeis.Add(imei);
            this.PropertysFor3G.Add(propertyFor3G);
            Console.WriteLine("Зарегистрирован телефон с 3G");
        }
    }
}
