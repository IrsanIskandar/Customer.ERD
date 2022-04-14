using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("sector_subsector")]
    public class SectorSubsector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual ICollection<Customer> Customers { get; set; }

        public int id_sector { get; set; }

        [ForeignKey("id_sector")]
        public virtual ICollection<MSSector> MSSectors { get; set; }

        public int id_subsector { get; set; }

        [ForeignKey("id_subsector")]
        public virtual ICollection<MSSubsector> MSSubsectors { get; set; }

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
