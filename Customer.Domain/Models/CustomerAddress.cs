using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer_address")]
    public class CustomerAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int customer_id { get; set; }

        [ForeignKey("customer_id")]
        public virtual ICollection<Customer> Customers { get; set; }

        public int id_address_type { get; set; }

        [ForeignKey("id_address_type")]
        public virtual MSAddressType MSAddressType { get; set; }

        [StringLength(100)]
        public string? building_name { get; set; }

        [StringLength(200)]
        public string street_address { get; set; }

        public int id_kelurahan { get; set; }

        [ForeignKey("id_kelurahan")]
        public virtual ICollection<MSKelurahan> MSKelurahans { get; set; }

        [StringLength(50)]
        public string? kelurahan_lainnya { get; set; }

        public int id_kecamatan { get; set; }

        [ForeignKey("id_kecamatan")]
        public virtual ICollection<MSKecamatan> MSKecamatans { get; set; }

        [StringLength(50)]
        public string? kecamatan_lainnya { get; set; }

        public int id_kota { get; set; }

        [ForeignKey("id_kota")]
        public virtual ICollection<MSKota> MSKotas { get; set; }

        [StringLength(50)]
        public string? kota_lainnya { get; set; }

        public int id_provinsi { get; set; }

        [ForeignKey("id_provinsi")]
        public virtual ICollection<MSProvinsi> MSProvinsis { get; set; }

        [StringLength(50)]
        public string? provinsi_lainnya { get; set; }

        public int id_negara { get; set; }

        [ForeignKey("id_negara")]
        public virtual ICollection<MSNegara> MSNegaras { get; set; }

        [StringLength(50)]
        public string? negara_lainnya { get; set; }

        public int id_kode_pos { get; set; }

        [ForeignKey("id_kode_pos")]
        public virtual ICollection<MSKodepos> MSKodepos { get; set; }

        [StringLength(10)]
        public string? kode_pos_lainnya { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string? last_updated_by { get; set; }

        public bool is_main_address { get; set; }
    }
}
