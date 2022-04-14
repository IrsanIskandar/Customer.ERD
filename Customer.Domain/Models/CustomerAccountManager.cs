using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer_account_manager")]
    public class CustomerAccountManager
    {
        [Key]
        public int id { get; set; }

        public int id_account_manager { get; set; }

        [ForeignKey("id_account_manager")]
        public virtual MSAccountManager MSAccountManager { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual Customer Customer { get; set; }

        public bool is_active { get; set; }

        public bool is_team_leader { get; set; }

        [DataType(DataType.Date)]
        public DateTime start_date { get; set; }

        [DataType(DataType.Date)]
        public DateTime? end_date { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string? last_updated_by { get; set; }
    }
}
