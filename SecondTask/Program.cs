using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstTask;
using System.Reflection;

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

            // Определение функции получения информации об объектах
            void GetObjectsInfo(object first, object second)
            {
                try
                {
                    try
                    {
                        Type firstType = first.GetType();
                        Type secondType = second.GetType();
                        Type firstBaseType = firstType.BaseType;
                        Type secondBaseType = secondType.BaseType;

                        if (firstType == secondType)
                            Console.WriteLine("Оба переданных объекта являются экземлярами класса {0}", firstType.Name);
                        else if (firstBaseType == secondType)
                            Console.WriteLine("Класс {0} является предком класса {1}", secondType.Name, firstType.Name);
                        else if (secondBaseType == firstType)
                            Console.WriteLine("Класс {0} является предком класса {1}", firstType.Name, secondType.Name);
                        else
                            throw new ArgumentException();
                    }
                    catch (NullReferenceException)
                    {
                        throw new ArgumentNullException();
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
            }

            // Тестовые вызовы функции получения информации об объектах
            GetObjectsInfo(firstPhone, secondPhone);
            GetObjectsInfo(firstPhone, phone3G);
            GetObjectsInfo(firstPhone, nullPhone);
            GetObjectsInfo(firstPhone, "text");
            GetObjectsInfo(firstPhone, dockStation);
            Console.ReadKey();
        }
    }
}
