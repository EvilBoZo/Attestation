using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Событие звонка". 
    /// </summary>
    public class CallEventsArgs : EventArgs
    {
        /// <summary> 
        /// Значение IMEI телефона, с которого осуществляется вызов. 
        /// </summary>
        public string Imei { get; }

        /// <summary> 
        /// Номер телефона, по которому осущетсвляется вызов. 
        /// </summary>
        public string Number { get; }

        /// <summary> 
        /// Создать экземпляр класса на основе переданных значениq IMEI и номера телефона. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        /// <param name="number">Номер телефона.</param>
        public CallEventsArgs(string imei, string number)
        {
            this.Imei = imei;
            this.Number = number;
        }
    }
}
