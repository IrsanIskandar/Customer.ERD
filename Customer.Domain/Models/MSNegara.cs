using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_negara")]
    public class MSNegara
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(20)]
        public string slik_code { get; set; }

        [StringLength(20)]
        public string? lapbul_code { get; set; }
    }
}
