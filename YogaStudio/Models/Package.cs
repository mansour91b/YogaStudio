using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YogaStudio.Models
{
    public class Package
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClassesCount { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
