using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        public string Imei { get; }

        /// <summary> 
        /// Номер сим-карты. 
        /// </summary>
        public string SimNumber { get; private set; }

        /// <summary> 
        /// Список контактов. 
        /// </summary>
        private readonly List<Contact> contacts = new List<Contact>();

        /// <summary> 
        /// Список контактов. 
        /// </summary>
        public IReadOnlyCollection<Contact> Contacts
        {
            get
            {
                return new ReadOnlyCollection<Contact>(this.contacts);
            }
        }

        #endregion

        #region Методы

        /// <summary> 
        /// Добавить в список контактов новый контакт. 
        /// </summary> 
        /// <param name="contact">Новый контакт.</param>
        public void AddContact(Contact contact)
        {
            this.contacts.Add(contact);
        }

        /// <summary> 
        /// Добавить сим-карту в телефон. 
        /// </summary> 
        /// <param name="simNumber">Номер сим-карты.</param>
        public void AddSim(string simNumber)
        {
            this.SimNumber = simNumber;
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
                    this.Called?.Invoke(this, new CallEventsArgs(this.Imei, contact.GetNumber(1)));
                    return;
                }
            }
            Console.WriteLine("Вызов {0}", contactData);
            this.Called?.Invoke(this, new CallEventsArgs(this.Imei, contactData));
        }

        /// <summary> 
        /// Установить соединение с базовой станцией станцией. 
        /// </summary> 
        /// <param name="dockStation">Базовая станция.</param> 
        protected virtual void ConnectToDockStation(DockStation dockStation)
        {
            dockStation.RegisterPhone(this.Imei);
            this.Called += dockStation.DataProcessing;
        }

        #endregion

        #region Делегаты и события

        /// <summary> 
        /// Делегат события на осуществление звонка. 
        /// </summary> 
        /// <param name="Sender">Источник события.</param> 
        /// <param name="e">Параметры события.</param>
        protected delegate void EventHandler(object sender, CallEventsArgs e);

        /// <summary> 
        /// Событие на осуществление звонка. 
        /// </summary> 
        /// <remarks>Возникает при осуществлении звонка.</remarks> 
        protected event EventHandler Called;

        #endregion

        #region Конструкторы

        /// <summary> 
        /// Конструктор. 
        /// </summary> 
        public Phone(string imei)
        {
            this.Imei = imei;
        }

        /// <summary> 
        /// Конструктор. 
        /// </summary> 
        public Phone(string imei, DockStation dockStation) : this(imei)
        {
            this.ConnectToDockStation(dockStation);
        }

        #endregion
    }
}
