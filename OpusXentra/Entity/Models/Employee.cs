using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Models
{
   public  class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string LastName { get; set; }
        public int CompanyId { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Phone { get; set; }
        public string Skills { get; set; }
    }
}
