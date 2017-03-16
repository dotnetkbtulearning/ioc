using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// Интерфейс менеджера категоризации посылок (контракт)
    /// </summary>
    public interface IPackageCategoryManager
    {
        /// <summary>
        /// Определить категорию посылки (по весу)
        /// </summary>
        /// <param name="package">Посылка</param>
        /// <returns>Категория</returns>
        PackageCategoryEnum GetCategory(Package package);
    }
}
