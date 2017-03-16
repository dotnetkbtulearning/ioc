using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Интерфейс службы доставки (контракт)
    /// </summary>
    public interface IDeliveryService
    {
        /// <summary>
        /// Получение категории посылки
        /// </summary>
        /// <param name="package">Посылка</param>
        /// <returns>Категория</returns>
        PackageCategoryEnum GetPackageCategory(Package package);

        /// <summary>
        /// Отправить посылку относительно категории
        /// </summary>
        /// <param name="package">Посылка</param>
        /// <param name="category">Категория</param>
        /// <returns>Результат информации</returns>
        Task<string> SendPackage(Package package, PackageCategoryEnum category);
    }
}
