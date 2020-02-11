using System;
using System.Collections.Generic;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Базовая станция". 
    /// </summary>
    public class DockStation : IRegisterable
    {
        /// <summary> 
        /// Список зарегистрированных телефонов. 
        /// </summary>
        protected List<ICallable> phones = new List<ICallable>();

        /// <summary> 
        /// Зарегистрировать телефон. 
        /// </summary> 
        /// <param name="phone">Телефон.</param>
        public virtual void Register(ICallable phone)
        {
            foreach (ICallable currentPhone in this.phones)
            {
                if (currentPhone.GetRegInfo() == phone.GetRegInfo())
                {
                    Console.WriteLine("Данный телефон уже зарегистрирован");
                    return;
                }
            }
            this.phones.Add(phone);
            phone.Called += DataProcessing;
            Console.WriteLine("Зарегистрирован телефон");
        }

        /// <summary> 
        /// Обработать исходящий звонок с зарегистрированного телефона. 
        /// </summary> 
        /// <param name="sender">Объект инициирующий событие.</param>
        /// <param name="e">Данные события.</param>
        protected void DataProcessing(object sender, EventArgs e)
        {
            foreach (ICallable phone in this.phones)
            {
                if (sender == phone)
                {
                    Console.WriteLine("Обработка исходящего вызова");
                    return;
                }
            }
            Console.WriteLine("Данный телефон не зарегистрирован");
        }
    }
}
