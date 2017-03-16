using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;
using BL.Models;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class UnitTestCarProvider
    {
        private readonly IProvider _provider;

        public UnitTestCarProvider()
        {
            _provider = new CarProvider();
        }

        [TestMethod]
        public void CarProviderSendPackage()
        {
            var package = new Package()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "My post",
                Weight = 100
            };

            Task<string> task = null;

            try
            {
                task = _provider.Send(package);
            }
            catch (Exception ex)
            {

            }
            
            Assert.IsNull(task.Exception);
        }
    }
}
