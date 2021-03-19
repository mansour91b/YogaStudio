using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace YogaStudio.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the YogaStudioUser class
    public class YogaStudioUser : IdentityUser
    {
        public int Hight { get; set; }
        public int Width { get; set; }
       /// <summary>
       /// ////////// 1:admin; 2:trainner; 3:user
       /// </summary>
        public short Type { get; set; }
    }
}
