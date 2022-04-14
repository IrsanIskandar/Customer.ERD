using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer")]
    public class CustomerAddress
    {
        [Key]
        public int id { get; set; }

        public int customer_id { get; set; }

        [ForeignKey("customer_id")]
        public virtual Customer Customer { get; set; }

        public int id_address_type { get; set; }

        [ForeignKey("id_address_type")]
        public virtual MSAddressType MSAddressType { get; set; }

        [StringLength(100)]
        public string? building_name { get; set; }

        [StringLength(200)]
        public string street_address { get; set; }

        public int id_kelurahan { get; set; }

        [ForeignKey("id_kelurahan")]
        public virtual MSKelurahan MSKelurahan { get; set; }

        [StringLength(50)]
        public string? kelurahan_lainnya { get; set; }

        public int id_kecamatan { get; set; }

        [ForeignKey("id_kecamatan")]
        public virtual MSKecamatan MSKecamatan { get; set; }

        [StringLength(50)]
        public string? kecamatan_lainnya { get; set; }

        public int id_kota { get; set; }

        [ForeignKey("id_kota")]
        public virtual MSKota MSKota { get; set; }

        [StringLength(50)]
        public string? kota_lainnya { get; set; }

        public int id_provinsi { get; set; }

        [ForeignKey("id_provinsi")]
        public virtual MSProvinsi MSProvinsi { get; set; }

        [StringLength(50)]
        public string? provinsi_lainnya { get; set; }

        public int id_negara { get; set; }

        [ForeignKey("id_negara")]
        public virtual MSNegara MSNegara { get; set; }

        [StringLength(50)]
        public string? negara_lainnya { get; set; }

        public int id_kode_pos { get; set; }

        [ForeignKey("id_kode_pos")]
        public virtual MSKodepos MSKodepos { get; set; }

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
