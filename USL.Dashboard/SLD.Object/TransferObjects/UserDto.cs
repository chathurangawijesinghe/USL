using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLD.Object.TransferObjects
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public int UserTypeId { get; set; }
        public string Country { get; set; }
        public string Designation { get; set; }
    }
}
