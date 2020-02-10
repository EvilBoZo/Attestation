using System;
using System.Collections.Generic;

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
        private List<string> PropertysFor3G = new List<string>();

        /// <summary> 
        /// Зарегистрировать телефон с полученным IMEI. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        internal void RegisterPhone(string imei, string propertyFor3G)
        {
            foreach (string currentImei in imeis)
            {
                if (currentImei == imei)
                {
                    Console.WriteLine("Данный телефон уже зарегистрирован");
                    return;
                }
            }
            this.imeis.Add(imei);
            this.PropertysFor3G.Add(propertyFor3G);
            Console.WriteLine("Зарегистрирован телефон с 3G");
        }
    }
}
