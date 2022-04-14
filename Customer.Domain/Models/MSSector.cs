using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("ms_sector")]
    public class MSSector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(255)]
        public string shortname { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public bool active { get; set; }

        public int sector_num { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_dtm { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_dtm { get; set; }
    }
}
