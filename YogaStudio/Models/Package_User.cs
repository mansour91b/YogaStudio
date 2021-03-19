using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YogaStudio.Models
{
    public class Package_User
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string TrainerID { get; set; }
        public int PackageID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
