using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("ms_subsector")]
    public class MSSubsector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int sector_id { get; set; }

        [ForeignKey("sector_id")]
        public MSSector MSSector { get; set; }

        [StringLength(6)]
        public char code_slik { get; set; }

        [ForeignKey("code_slik")]
        public virtual ICollection<SektorEkonomi> SektorEkonomis { get; set; }

        public bool active { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_dtm { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_dtm { get; set; }
    }
}
