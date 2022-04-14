using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("go_public_map")]
    public class GoPublicMap
    {
        [Key]
        [StringLength(1)]
        public char id { get; set; }

        [StringLength(3)]
        public string public_listed { get; set; }
    }
}
