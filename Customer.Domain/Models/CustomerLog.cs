using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("customer_log")]
    public class CustomerLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual ICollection<Customer> Customers { get; set; }

        public string data_json { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }
    }
}
