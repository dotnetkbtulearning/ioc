using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Core.Models
{
    /// <summary>
    /// Посылка
    /// </summary>
    public class Package
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public float Weight { get; set; }
    }
}