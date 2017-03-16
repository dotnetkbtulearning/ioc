using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace IntroOne_DI
{
    /*
     * Данная реализация с DI
     * Консольное приложение имеет ссылки на Core | BL проекты
     * Так же можно проверить проект тесты
     */

    class Program
    {
        static void Main(string[] args)
        {
            // вызов бутстрапера для мапинга зависимостей
            Models.Bootstrapper.Bootstrap();

            // получаем сервис
            var srv = Models.Bootstrapper.Container.Resolve<IDeliveryService>();

            // создаем пакет
            // Weight < 50 ---> normal
            // Weight < 50 ---> normal
            // Weight < 150 ---> Exception Provider not implimented!
            // Weight > 150 ---> Exception to much value!
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "My post",
                Weight = 90
            };

            // определить категорию
            var category = srv.GetPackageCategory(package);

            // отправить посылку
            var task = srv.SendPackage(package, category);
            
            Console.WriteLine("Res: " + task.Result);
        }
    }
}
