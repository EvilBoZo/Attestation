namespace FirstTask
{
    /// <summary> 
    /// Интерфейс "Осуществляющий регистрацию". 
    /// </summary>
    public interface IRegisterable
    {
        /// <summary> 
        /// Зарегистрировать телефон. 
        /// </summary> 
        /// <param name="phone">Телефон.</param>
        void Register(ICallable phone);
    }
}
