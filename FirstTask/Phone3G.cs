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

        /// <summary> 
        /// Установить соединение с базовой станцией станцией c 3G. 
        /// </summary> 
        /// <param name="dockStation3G">Базовая станция.</param> 
        protected override void ConnectToDockStation(DockStation dockStation)
        {
            DockStation3G dockStation3G = (DockStation3G)dockStation;
            dockStation3G.RegisterPhone(this.Imei, this.PropertyFor3G);
            this.Called += dockStation3G.DataProcessing;
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
        public Phone3G(string imei, DockStation dockStation, string propertyFor3G) : this(imei, propertyFor3G)
        {
            this.ConnectToDockStation(dockStation);
        }
    }
}
