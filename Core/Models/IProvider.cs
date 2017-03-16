using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Интерфейс Поставщиков (контракт)
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// Функция достаки
        /// </summary>
        /// <param name="package">Посылка</param>
        /// <returns>Информация о результате</returns>
        Task<string> Send(Package package);
    }
}
