using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int customer_no { get; set; }

        [StringLength(100)]
        public string customer_name { get; set; }

        [StringLength(100)]
        public string mnemonic { get; set; }

        public int kode_bentuk_badan_usaha { get; set; }

        [ForeignKey("kode_bentuk_badan_usaha")]
        public virtual ICollection<MSBentukBadanUsaha> MSBentukBadanUsahas { get; set; }

        public int? id_tempat_pendirian { get; set; }

        [ForeignKey("id_tempat_pendirian")]
        public MSKota MSKota { get; set; }

        public int id_last_sub_sector { get; set; }

        [ForeignKey("id_last_sub_sector")]
        public virtual ICollection<MSSubsector> MSSubsectors { get; set; }

        [StringLength(10)]
        public string sub_sector { get; set; }

        public bool use_old_sector { get; set; }

        public int id_customer_relationship { get; set; }

        [ForeignKey("id_customer_relationship")]
        public virtual ICollection<MSCustomerRelationship> MSCustomerRelationships { get; set; }

        public int id_soe_status { get; set; }

        [ForeignKey("id_soe_status")]
        public virtual ICollection<MSSoeStatus> MSSoeStatuses { get; set; }

        [StringLength(50)]
        public string phone_no { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [StringLength(3)]
        public string public_listed { get; set; }

        [StringLength(2)]
        public char id_hubungan_pelapor { get; set; }

        [ForeignKey("id_hubungan_pelapor")]
        public virtual ICollection<HubunganPelapor> HubunganPelapors { get; set; }

        [StringLength(8)]
        public char id_golongan_debitur { get; set; }

        [ForeignKey("id_golongan_debitur")]
        public virtual ICollection<GolonganPihakKetiga> GolonganPihakKetigas { get; set; }

        public int id_last_customer_status { get; set; }

        [ForeignKey("id_last_customer_status")]
        public virtual ICollection<MSCustomerStatus> MSCustomerStatuses { get; set; }

        [StringLength(10)]
        public string sam_account { get; set; }
    }
}
