using System;
using FirstTask;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализаця входных данных для проверок
            Phone firstPhone = new Phone("123456789123456");
            Phone secondPhone = new Phone("123456789123456");
            Phone nullPhone = null;
            Phone3G phone3G = new Phone3G("123456789123456", "123456789123456");
            DockStation dockStation = new DockStation();

            // Тестовые вызовы функции получения информации об объектах
            try
            {
                Console.WriteLine(GetObjectsInfo(firstPhone, secondPhone));
                Console.WriteLine(GetObjectsInfo(firstPhone, phone3G));
                Console.WriteLine(GetObjectsInfo(phone3G, new object()));

                Console.WriteLine("Укажите тип проверки (1 - родство неопределено, 2 - не экземпляр класса, 3 - null):");
                string chekType = Console.ReadLine().ToString();

                if (chekType == "1")
                {
                    Console.WriteLine(GetObjectsInfo(firstPhone, dockStation));
                }
                else if (chekType == "2")
                {
                    Console.WriteLine(GetObjectsInfo(firstPhone, 10));
                }
                else if (chekType == "3")
                {
                    Console.WriteLine(GetObjectsInfo(firstPhone, nullPhone));
                }
                else
                {
                    Console.WriteLine("Тип проверки указан неверно");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        /// <summary> 
        /// Определить степень родства двух объектов. 
        /// </summary> 
        /// <param name="first">Первый объект.</param>
        /// <param name="second">Второй объект.</param>
        static string GetObjectsInfo(object first, object second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            else if (second == null)
                throw new ArgumentNullException(nameof(second));

            Type firstType = first.GetType();
            Type secondType = second.GetType();
            Type firstBaseType = firstType.BaseType;
            Type secondBaseType = secondType.BaseType;

            if (firstType == secondType)
            {
                return "Оба переданных объекта являются экземлярами класса " + firstType.Name;
            }
            else if (firstBaseType == secondType)
            {
                return "Класс " + secondType.Name + " является непосредственным предком класса " + firstType.Name;
            }
            else if (secondBaseType == firstType)
            {
                return "Класс " + firstType.Name + " является непосредственным предком класса " + secondType.Name;
            }
            else if (firstType.IsSubclassOf(secondType))
            {
                return "Класс " + secondType.Name + " является предком класса " + firstType.Name;
            }
            else if (secondType.IsSubclassOf(firstType))
            {
                return "Класс " + firstType.Name + " является предком класса " + secondType.Name;
            }
            else if (!firstType.IsClass || !secondType.IsClass)
            {
                throw new ArgumentException("Входной параметр не является экземпляром класса");
            }
            else
            {
                throw new ArgumentException("Родство входных параметров определить невозможно");
            }
        }
    }
}
