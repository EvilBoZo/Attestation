using System;
using System.Collections.Generic;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Базовая станция". 
    /// </summary>
    public class DockStation
    {
        /// <summary> 
        /// Список зарегестрированных IMEI. 
        /// </summary>
        protected List<string> imeis = new List<string>();

        /// <summary> 
        /// Зарегистрировать телефон с полученным IMEI. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        internal void RegisterPhone(string imei)
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
            Console.WriteLine("Зарегистрирован телефон");
        }

        /// <summary> 
        /// Обработать исходящий звонок с зарегистрированного телефона. 
        /// </summary> 
        /// <param name="Sender">Источник события.</param> 
        /// <param name="e">Параметры события.</param>
        internal void DataProcessing(object sender, CallEventsArgs e)
        {
            foreach (string imei in this.imeis)
            {
                if (imei == e.Imei)
                {
                    Console.WriteLine("Идет обработка вызова {0}, телефоном с IMEI {1}", e.Number, e.Imei);
                    break;
                }
            }
        }
    }
}
