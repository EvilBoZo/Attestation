using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Контакт". 
    /// </summary>
    public sealed class Contact
    {
        /// <summary> 
        /// Имя контакта. 
        /// </summary>
        public string Name { get; set; }

        /// <summary> 
        /// Список номеров контакта. 
        /// </summary>
        public List<string> Numbers { get; set; }

        /// <summary> 
        /// Создать экземпляр класса на основе переданных значений имени и списка номеров.
        /// </summary> 
        /// <param name="name">Имя контакта.</param>
        /// <param name="numbers">Список номеров контакта.</param>
        public Contact(string name, List<string> numbers)
        {
            this.Name = name;
            this.Numbers = numbers;
        }
    }
}
