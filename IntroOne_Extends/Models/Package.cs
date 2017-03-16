using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne_Extends.Models
{
    public enum PackageCategoryEnum
    {
        Small,
        Normal,
        Big
    }

    public class Package
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public float Weight { get; set; }
    }
}
