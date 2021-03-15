using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skills { get; set; }
    }
}
