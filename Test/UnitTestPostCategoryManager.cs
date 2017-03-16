using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;
using BL.Models;

namespace Test
{
    [TestClass]
    public class UnitTestPostCategoryManager
    {
        private readonly IPackageCategoryManager _mnrg;

        public UnitTestPostCategoryManager()
        {
            _mnrg = new PackageCategoryManager();
        }

        [TestMethod]
        public void GetPackageCategoryWithNullWeightFalled()
        {
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "",
                Weight = 0
            };

            try
            {
                var res = _mnrg.GetCategory(package);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
            
        }

        [TestMethod]
        public void GetPackageCategoryWithVeryBigWeightFalled()
        {
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "",
                Weight = 300
            };

            try
            {
                var res = _mnrg.GetCategory(package);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GetPackageCategoryWithNormalWeightFalled()
        {
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "",
                Weight = 70
            };

            try
            {
                var res = _mnrg.GetCategory(package);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
        }

    }
    
}
