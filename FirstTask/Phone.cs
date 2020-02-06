using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Телефон". 
    /// </summary>
    public class Phone
    {
        #region Свойства

        /// <summary> 
        /// IMEI телефона. 
        /// </summary>
        public string Imei { get; private set; }

        /// <summary> 
        /// Номер сим-карты. 
        /// </summary>
        public string SimNumber { get; set; }

        /// <summary> 
        /// Список контактов. 
        /// </summary>
        public List<Contact> Contacts { get; private set; }

        #endregion

        #region Методы

        /// <summary> 
        /// Добавить в список контактов новый контакт. 
        /// </summary> 
        /// <param name="contact">Новый контакт.</param>
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        /// <summary> 
        /// Осуществить звонок по набранному имени контаката или номеру телефона. 
        /// </summary> 
        /// <param name="contactData">Имя контакта или номер телефона.</param>
        public void Call(string contactData)
        {
            foreach (Contact contact in this.Contacts)
            {
                if (contactData == contact.Name)
                {
                    Console.WriteLine("Вызов {0}", contact.Name);
                    // Набираем первый номер из списка возможных для найденного контакта
                    Called?.Invoke(this, new CallEventsArgs(this.Imei, contact.Numbers[0]));
                    return;
                }
            }

            Console.WriteLine("Вызов {0}", contactData);
            Called?.Invoke(this, new CallEventsArgs(this.Imei, contactData));
        }

        /// <summary> 
        /// Установить соединение с базовой станцией станцией. 
        /// </summary> 
        /// <param name="dockStation">Базовая станция.</param> 
        public void ConnectToDockStation(DockStation dockStation)
        {
            dockStation.RegisterPhone(this.Imei);
        }

        #endregion

        #region Делегаты и события

        /// <summary> 
        /// Делегат события на осуществление звонка. 
        /// </summary> 
        /// <param name="Sender">Источник события.</param> 
        /// <param name="e">Параметры события.</param>
        public delegate void CallHandler(object sender, CallEventsArgs e);

        /// <summary> 
        /// Событие на осуществление звонка. 
        /// </summary> 
        /// <remarks>Возникает при осуществлении звонка.</remarks> 
        public event CallHandler Called;

        #endregion

        #region Конструкторы

        /// <summary> 
        /// Создать экземпляр класса на основе переданного значения IMEI. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        public Phone(string imei)
        {
            this.Imei = imei;
            this.Contacts = new List<Contact>();
        }

        #endregion
    }
}
