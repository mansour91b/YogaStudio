using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YogaStudio.Models
{
    public class Trainer_Package
    {
        public int ID { get; set; }
        public string TrainerID { get; set; }
        public string PackageID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public virtual Package Package { get; set; }
        public virtual YogaStudio.Areas.Identity.Data.YogaStudioUser Trainer { get; set; }
    }
}
