using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("hubungan_pelapor")]
    public class HubunganPelapor
    {
        [Key]
        [StringLength(2)]
        public char Id { get; set; }

        [StringLength(40)]
        public string description { get; set; }
    }
}
