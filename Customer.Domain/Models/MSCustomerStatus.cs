using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_customer_status")]
    public class MSCustomerStatus
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string description { get; set; }
    }
}
