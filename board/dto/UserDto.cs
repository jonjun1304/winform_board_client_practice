using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    public class UserDto
    {
        public string userId { get; set; }
        public string userPassword { get; set; }
        public string joinDttm { get; set; }
        public string birthday { get; set; }
        public string phoneNo { get; set; }
        public string authorityType { get; set; }
    }
}
