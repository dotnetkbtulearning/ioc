using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne_Extends.Models
{
    public class DeliverServiceOne
    {
        public async Task<string> Send(Package package)
        {
            var category = GetCategory(package);

            var res = await SendBy(package, category);

            return res;
        }

        private PackageCategoryEnum GetCategory(Package package)
        {
            if (package.Weight < 10)
                return PackageCategoryEnum.Small;
            else if (package.Weight < 50)
                return PackageCategoryEnum.Normal;
            else
                return PackageCategoryEnum.Big;
        }

        private async Task<string> SendBy(Package package, PackageCategoryEnum category)
        {
            if (category == PackageCategoryEnum.Small)
                return await SendByPost(package);
            else if (category == PackageCategoryEnum.Normal)
                return await SendByCar(package);
            else if (category == PackageCategoryEnum.Big)
                return await SendByPlance(package);
            else
                throw new ArgumentException("Не правильно передана категория");
        }

        private async Task<string> SendByPost(Package package)
        {
            return "Sended by post";
        }

        private async Task<string> SendByCar(Package package)
        {
            return "Sended by car";
        }

        private async Task<string> SendByPlance(Package package)
        {
            return "Sended by plane";
        }

    }
}
