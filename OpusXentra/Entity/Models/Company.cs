using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Website { get; set; }
    }
}
