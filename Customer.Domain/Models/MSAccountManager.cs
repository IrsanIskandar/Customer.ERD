using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("ms_account_manager")]
    public class MSAccountManager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string username { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }

        public int id_team_leader { get; set; }

        [ForeignKey("id_team_leader")]
        public virtual MSAccountManager MSAccountManagers { get; set; }

        public int id_directorate { get; set; }

        [ForeignKey("id_directorate")]
        public virtual MSOrgDirectorate MSOrgDirectorate { get; set; }

        public int id_division { get; set; }

        [ForeignKey("id_division")]
        public virtual MSOrgDivision MSOrgDivision { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        public bool IsActive { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string? last_updated_by { get; set; }
    }
}
