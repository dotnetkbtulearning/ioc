using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne_Extends.Models
{
    public class DeliverServiceTwo
    {
        BaseProvider provider;

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
                provider = new CarProvider();
            else if (category == PackageCategoryEnum.Normal)
                provider = new CarProvider();
            else if (category == PackageCategoryEnum.Big)
                provider = new PlaneProvider();
            else
                throw new ArgumentException("Не правильно передана категория");

            return await provider.Send(package);
        }
    }

    public class BaseProvider
    {
        public async virtual Task<string> Send(Package package)
        {
            return "Sended by normal";
        }
    }

    public class PostProvider : BaseProvider
    {
        public async override Task<string> Send(Package package)
        {
            return "Sended by Post";
        }
    }

    public class CarProvider : BaseProvider
    {
        public async override Task<string> Send(Package package)
        {
            return "Sended by Car";
        }
    }

    public class PlaneProvider : BaseProvider
    {
        public async override Task<string> Send(Package package)
        {
            return "Sended by Plane";
        }
    }

}
