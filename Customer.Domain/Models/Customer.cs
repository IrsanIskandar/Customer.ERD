using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }

        public int customer_no { get; set; }

        [StringLength(100)]
        public string customer_name { get; set; }

        [StringLength(100)]
        public string mnemonic { get; set; }

        public int kode_bentuk_badan_usaha { get; set; }

        [ForeignKey("kode_bentuk_badan_usaha")]
        public MSBentukBadanUsaha MSBentukBadanUsaha { get; set; }

        //[ForeignKey("")]
        //public int id_tempat_pendirian { get; set; }

        //[ForeignKey("")]
        //public int id_last_sub_sector { get; set; }

        [StringLength(10)]
        public string sub_sector { get; set; }

        public bool use_old_sector { get; set; }

        public int id_customer_relationship { get; set; }

        [ForeignKey("id_customer_relationship")]
        public virtual MSCustomerRelationship MSCustomerRelationship { get; set; }

        public int id_soe_status { get; set; }

        [ForeignKey("id_soe_status")]
        public virtual MSSoeStatus MSSoeStatus { get; set; }

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
        public HubunganPelapor HubunganPelapor { get; set; }

        [StringLength(8)]
        public char id_golongan_debitur { get; set; }

        [ForeignKey("id_golongan_debitur")]
        public GolonganPihakKetiga GolonganPihakKetiga { get; set; }

        public int id_last_customer_status { get; set; }

        [ForeignKey("id_last_customer_status")]
        public virtual MSCustomerStatus MSCustomerStatus { get; set; }

        [StringLength(10)]
        public string sam_account { get; set; }
    }
}
