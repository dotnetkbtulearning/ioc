using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL.Models
{
    /// <summary>
    /// Реализация поставщика (самолёт) (НЕ РЕАЛИЗОВАНО!)
    /// </summary>
    public class PlaneProvider : IProvider
    {
        /// <summary>
        /// Вызов данной функции вызовит исключение!
        /// </summary>
        /// <param name="package"></param>
        /// <returns></returns>
        public async Task<string> Send(Package package)
        {
            throw new NotImplementedException();
        }
    }
}
