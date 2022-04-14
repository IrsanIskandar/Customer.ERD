using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("customer_group")]
    public class CustomerGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual Customer Customer { get; set; }

        [StringLength(70)]
        public string name { get; set; }

        [StringLength(12)]
        public string created_by { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        [StringLength(12)]
        public string? updated_by { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }
    }
}
