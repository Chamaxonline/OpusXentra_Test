using System;
using System.Collections.Generic;
using System.Text;

namespace SmartERP.Domain.Models
{
    public class ApplicationUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginEmail { get; set; }
        public string PhoneNumber { get; set; }
        public int SecurityProfileId { get; set; }
    }
}
