using System;
using System.Collections.Generic;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация входных данных для проверок
            DockStation firstDockStation = new DockStation();
            DockStation3G secondDockStation = new DockStation3G();
            Phone firstPhone = new Phone("123456789123456", firstDockStation);
            Phone3G secondPhone = new Phone3G("023456789123456", secondDockStation, "023456789123456");
            Contact contact = new Contact("Контакт", new List<string> { "123456789", "023456789" });
            firstPhone.AddContact(contact);
            secondPhone.AddContact(contact);

            // Тестовые звонки
            firstPhone.Call("Контакт");
            firstPhone.Call("123456780");
            secondPhone.Call("Контакт");
            secondPhone.Call("123456780");

            Console.ReadKey();
        }
    }
}
