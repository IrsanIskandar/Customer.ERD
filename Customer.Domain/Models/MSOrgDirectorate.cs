using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_org_directorate")]
    public class MSOrgDirectorate
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string code { get; set; }

        [StringLength(20)]
        public string? code_findim { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
