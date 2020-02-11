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
        public string PropertyFor3G { get; }

        public override string GetRegInfo()
        {
            return base.GetRegInfo() + this.PropertyFor3G;
        }

        /// <summary> 
        /// Конструктор. 
        /// </summary>
        public Phone3G(string imei, string propertyFor3G) : base(imei)
        {
            this.PropertyFor3G = propertyFor3G;
        }

        /// <summary> 
        /// Конструктор. 
        /// </summary>
        public Phone3G(string imei, IRegisterable dockStation, string propertyFor3G) : this(imei, propertyFor3G)
        {
            this.ConnectToDockStation(dockStation);
        }
    }
}
