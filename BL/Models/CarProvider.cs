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
    /// Реализация поставщика (авто)
    /// </summary>
    public class CarProvider: IProvider
    {
        public async Task<string> Send(Package package)
        {
            /*
             * Send to another server
             */

            //throw new NotImplementedException();

            Thread.Sleep(3500);
            return "Sended by Car";
        }
    }
}
