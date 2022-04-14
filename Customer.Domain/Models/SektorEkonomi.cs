using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("sektor_ekonomi")]
    public class SektorEkonomi
    {
        [Key]
        [StringLength(6)]
        public char id { get; set; }

        [StringLength(200)]
        public string description { get; set; }
    }
}
