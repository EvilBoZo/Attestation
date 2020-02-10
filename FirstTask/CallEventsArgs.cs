using System;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Событие звонка". 
    /// </summary>
    public sealed class CallEventsArgs : EventArgs
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
        /// Конструктор. 
        /// </summary> 
        public CallEventsArgs(string imei, string number)
        {
            this.Imei = imei;
            this.Number = number;
        }
    }
}
