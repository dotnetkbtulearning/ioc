using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class PackageCategoryManager : IPackageCategoryManager
    {
        public PackageCategoryEnum GetCategory(Package package)
        {
            return Convert(package.Weight);
        }

        private PackageCategoryEnum Convert(float weight)
        {
            if (0 < weight && weight < 50)
                return PackageCategoryEnum.Small;
            else if (weight < 100)
                return PackageCategoryEnum.Normal;
            else if (weight < 150)
                return PackageCategoryEnum.Big;
            else
                throw new ArgumentException("Weight is too much!");

        }

    }
}
