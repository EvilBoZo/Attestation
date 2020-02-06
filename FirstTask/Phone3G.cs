using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    /// <summary> 
    /// Класс "Телефон с 3G". 
    /// </summary>
    public class Phone3G : Phone
    {
        /// <summary> 
        /// Специальное свойство для телефона с 3G. 
        /// </summary>
        public string PropertyFor3G { get; set; }

        /// <summary> 
        /// Установить соединение с базовой станцией станцией c 3G. 
        /// </summary> 
        /// <param name="dockStation3G">Базовая станция.</param> 
        public void ConnectToDockStation(DockStation3G dockStation3G)
        {
            dockStation3G.RegisterPhone(this.Imei, this.PropertyFor3G);
        }

        /// <summary> 
        /// Создать экземпляр класса на основе переданного значений IMEI
        /// и специального свойства для телефона с 3G. 
        /// </summary> 
        /// <param name="imei">IMEI устройства.</param>
        /// <param name="propertyFor3G">Специальное свойство для телефона с 3G.</param>
        public Phone3G(string imei, string propertyFor3G) : base(imei)
        {
            this.PropertyFor3G = propertyFor3G;
        }
    }
}
