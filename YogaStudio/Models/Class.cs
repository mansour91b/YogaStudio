using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YogaStudio.Areas.Identity.Data;

namespace YogaStudio.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string   Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public int PackageID { get; set; }
        public virtual Package Package { get; set; }

    }
}
