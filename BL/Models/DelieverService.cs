using Core.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    /// <summary>
    /// Реализация службы доставки
    /// </summary>
    public class DelieverService : IDeliveryService
    {
        private IPackageCategoryManager _mngr;
        
        private IProvider _postProvider;
        private IProvider _carProvider;
        private IProvider _planeProvider;
        
        // конструктор с подгрузкой зависимостей
        public DelieverService(IPackageCategoryManager manager,
            [Dependency("postProvider")]IProvider postProvider,
            [Dependency("carProvider")]IProvider carProvider,
            [Dependency("planeProvider")]IProvider planceProvider)
        {
            _mngr = manager;
            _postProvider = postProvider;
            _carProvider = carProvider;
            _planeProvider = planceProvider;
        }

        public PackageCategoryEnum GetPackageCategory(Package package)
        {
            var category = _mngr.GetCategory(package);
            return category;
        }

        public async Task<string> SendPackage(Package package, PackageCategoryEnum category)
        {
            IProvider provider;

            if (category == PackageCategoryEnum.Small)
                provider = _postProvider;
            else if (category == PackageCategoryEnum.Normal)
                provider = _carProvider;
            else if (category == PackageCategoryEnum.Big)
                provider = _planeProvider;
            else
            {
                throw new NotImplementedException();
            }

            return await provider.Send(package);
        }
    }
}