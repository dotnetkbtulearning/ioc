using BL.Models;
using Core.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne_DI.Models
{
    public class Bootstrapper
    {
        private static IUnityContainer _cntr;

        public static IUnityContainer Container
        {
            private set { _cntr = value; }
            get
            {
                if (_cntr == null)
                {
                    _cntr = new UnityContainer();
                }
                return _cntr;
            }
            
        }

        public static void Bootstrap()
        {
            Container.RegisterType<IDeliveryService, DelieverService>();
            Container.RegisterType<IPackageCategoryManager, PackageCategoryManager>();
            Container.RegisterType<IProvider, PostProvider>("postProvider");
            Container.RegisterType<IProvider, CarProvider>("carProvider");
            Container.RegisterType<IProvider, PlaneProvider>("planeProvider");
        }
    }
}
