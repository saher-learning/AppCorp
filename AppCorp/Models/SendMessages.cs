using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCorp.Models
{
    public class SendMessages
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string MobileNumber { get; set; }

        public string Message { get; set; }
    }
}
