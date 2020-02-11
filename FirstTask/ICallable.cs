using System;

namespace FirstTask
{
    /// <summary> 
    /// Интерфейс "Осуществляющий звонок". 
    /// </summary>
    public interface ICallable
    {
        /// <summary> 
        /// Получить регистрационную информацию. 
        /// </summary> 
        string GetRegInfo();

        /// <summary> 
        /// Событие на осуществление звонка. 
        /// </summary> 
        /// <remarks>Возникает при осуществлении звонка.</remarks> 
        event EventHandler Called;
    }
}
