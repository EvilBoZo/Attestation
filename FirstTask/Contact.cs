using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        public string Name { get; private set; }
        
        /// <summary> 
        /// Список номеров. 
        /// </summary>
        private readonly List<string> numbers = new List<string>();

        /// <summary> 
        /// Список номеров. 
        /// </summary>
        public IReadOnlyCollection<string> Numbers
        {
            get
            {
                return new ReadOnlyCollection<string>(this.numbers);
            }
        }
        
        /// <summary> 
        /// Изменить имя. 
        /// </summary> 
        /// <param name="name">Новое значение имени.</param>
        public void ChangeName(string name)
        {
            this.Name = name;
        }

        /// <summary> 
        /// Добавить новый номер. 
        /// </summary> 
        /// <param name="number">Новый номер.</param>
        public void AddNumber(string number)
        {
            this.numbers.Add(number);
        }

        /// <summary> 
        /// Получить значение согласно порядковому номеру. 
        /// </summary> 
        /// <param name="numberId">Порядковый номер.</param>
        public string GetNumber(int numberId)
        {
            return this.numbers[numberId];
        }

        /// <summary> 
        /// Конструктор.
        /// </summary> 
        public Contact(string name, List<string> numbers)
        {
            this.Name = name;
            this.numbers = numbers;
        }
    }
}
