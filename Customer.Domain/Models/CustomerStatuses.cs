using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("customer_statuses")]
    public class CustomerStatuses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual ICollection<Customer> Customers { get; set; }

        public int id_customer_status { get; set; }

        [ForeignKey("id_customer_status")]
        public virtual ICollection<MSCustomerStatus> MSCustomerStatuses { get; set; }

        public string customer_status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string last_updated_by { get; set; }
    }
}
