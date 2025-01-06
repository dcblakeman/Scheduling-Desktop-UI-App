using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_Desktop_UI_App.Classes
{
    internal static class User
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static int Active { get; set; }
        public static DateTime CreateDate { get; set; }
        public static string CreatedBy { get; set; }
        public static DateTime LastUpdate { get; set; }
        public static string LastUpdateBy { get; set; }
    }
}
