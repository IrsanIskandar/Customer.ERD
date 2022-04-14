using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("ms_customer_relationship")]
    public class MSCustomerRelationship
    {
        [Key]
        public int id { get; set; }

        public string description { get; set; }
    }
}
