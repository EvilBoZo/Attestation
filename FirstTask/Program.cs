using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация входных данных для проверок
            DockStation firstDockStation = new DockStation();
            DockStation3G secondDockStation = new DockStation3G();
            Phone firstPhone = new Phone("123456789123456");
            Phone3G secondPhone = new Phone3G("023456789123456", "023456789123456");
            Contact contact = new Contact("Контакт", new List<string> { "123456789", "023456789" });
            firstPhone.AddContact(contact);
            secondPhone.AddContact(contact);

            // Тестовые вызовы регистрации телефонов на базовых станциях
            firstPhone.ConnectToDockStation(firstDockStation);
            firstPhone.ConnectToDockStation(secondDockStation);
            secondPhone.ConnectToDockStation(firstDockStation);
            secondPhone.ConnectToDockStation(secondDockStation);

            // Подписка на события звонков
            firstPhone.Called += firstDockStation.DataProcessing;
            firstPhone.Called += secondDockStation.DataProcessing;
            secondPhone.Called += firstDockStation.DataProcessing;
            secondPhone.Called += secondDockStation.DataProcessing;

            // Осуществление звонкнов в разных вариациях
            firstPhone.Call("Контакт");
            firstPhone.Call("123456780");
            secondPhone.Call("Контакт");
            secondPhone.Call("123456780");

            Console.ReadKey();
        }
    }
}
