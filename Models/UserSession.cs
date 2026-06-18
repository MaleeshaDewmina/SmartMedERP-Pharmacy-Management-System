using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMedERP.Models
{
    public class UserSession
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string RoleName { get; set; }
    }
}