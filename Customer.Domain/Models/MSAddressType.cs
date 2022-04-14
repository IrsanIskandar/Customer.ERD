using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_address_type")]
    public class MSAddressType
    {
        [Key]
        public int id { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [StringLength(20)]
        public string name { get; set; }
    }
}
