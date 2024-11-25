using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board.dto;

namespace board
{
    public class UserDto : BaseDto
    {
        public string userId { get; set; }
        public string userPassword { get; set; }
        public string joinDttm { get; set; }
        public string birthday { get; set; }
        public string phoneNo { get; set; }
        public string authorityType { get; set; }
    }
}
