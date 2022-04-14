using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("ms_org_division")]
    public class MSOrgDivision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_directorate { get; set; }

        [ForeignKey("id_directorate")]
        public virtual MSOrgDirectorate MSOrgDirectorate { get; set; }

        [StringLength(20)]
        public string code { get; set; }

        [StringLength(20)]
        public string? code_findim { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
