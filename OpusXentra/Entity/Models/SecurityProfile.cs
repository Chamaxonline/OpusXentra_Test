using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Models
{
    public class SecurityProfile
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        public bool CreatedRight { get; set; }
        public bool ReaddRight { get; set; }
        public bool UpdateRight { get; set; }
        public bool DeleteRight { get; set; }
    }
}
