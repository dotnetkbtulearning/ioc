using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;
using BL.Models;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class UnitTestDelieverService
    {
        private readonly IDeliveryService _srv;

        public UnitTestDelieverService()
        {
            _srv = new DelieverService(new MyCustomPackageManager(), 
                new MyCustomProvider(), 
                new MyCustomProvider(), 
                new MyCustomProvider());
        }

        [TestMethod]
        public void SendPackage()
        {
            var pck = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "My post",
                Weight = 0
            };

            var category = _srv.GetPackageCategory(pck);

            var task = _srv.SendPackage(pck, category);

            var res = Task.FromResult(task);

            Assert.IsTrue(res.IsCompleted);
        }
    }


    public class MyCustomPackageManager : IPackageCategoryManager
    {
        public PackageCategoryEnum GetCategory(Package package)
        {
            return PackageCategoryEnum.Normal;
        }
    }

    public class MyCustomProvider : IProvider
    {
        public async Task<string> Send(Package package)
        {
            return "Ok!";
        }
    }

}
