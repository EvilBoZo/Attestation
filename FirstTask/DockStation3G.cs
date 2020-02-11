using System;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Базовая станция с 3G". 
    /// </summary>
    public class DockStation3G : DockStation
    {
        public override void Register(ICallable phone)
        {
            foreach (ICallable currentPhone in this.phones)
            {
                if (currentPhone.GetRegInfo() == phone.GetRegInfo())
                {
                    Console.WriteLine("Данный телефон с 3G уже зарегистрирован");
                    return;
                }
            }
            this.phones.Add(phone);
            phone.Called += DataProcessing;
            Console.WriteLine("Зарегистрирован телефон с 3G");
        }
    }
}
