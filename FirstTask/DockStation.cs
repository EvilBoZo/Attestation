using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<string> Imeis { get; protected set; } = new List<string>();

        /// <summary> 
        /// Зарегистрировать телефон с полученным IMEI. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        public void RegisterPhone(string imei)
        {
            this.Imeis.Add(imei);
            Console.WriteLine("Зарегистрирован телефон");
        }

        /// <summary> 
        /// Обработать исходящий звонок с зарегистрированного телефона. 
        /// </summary> 
        /// <param name="Sender">Источник события.</param> 
        /// <param name="e">Параметры события.</param>
        public void DataProcessing(object sender, CallEventsArgs e)
        {
            foreach (string imei in this.Imeis)
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
