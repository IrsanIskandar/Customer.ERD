using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("golongan_pihak_ketiga")]
    public class GolonganPihakKetiga
    {
        [Key]
        [StringLength(8)]
        public char id { get; set; }

        [StringLength(120)]
        public string description { get; set; }
    }
}
