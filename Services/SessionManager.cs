using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartMedERP.Models;

namespace SmartMedERP.Services
{
    public static class SessionManager
    {
        public static UserSession CurrentUser { get; set; }
    }
}
