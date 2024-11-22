using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board.common
{
    public static class Session
    {
        public static string UserId { get; set; }
        public static bool IsLoggedIn => !string.IsNullOrEmpty(UserId);

        public static string AuthorityType { get; set; }
    }
}
