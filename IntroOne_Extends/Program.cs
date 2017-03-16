using IntroOne_Extends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne_Extends
{
    class Program
    {
        static void Main(string[] args)
        {
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "My post",
                Weight = 70
            };

            // монолитный класс
            var srv1 = new DeliverServiceOne();
            var res1 = srv1.Send(package);

            // разбитый класс
            var srv2 = new DeliverServiceTwo();
            var res2 = srv2.Send(package);

        }
    }
}
