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
    /// Реализация поставщика (почта)
    /// </summary>
    public class PostProvider : IProvider
    {
        public async Task<string> Send(Package package)
        {
            /*
             * For example we send to one server
             */

            Thread.Sleep(5000);

            return "Sended by Post";
        }
    }
}
