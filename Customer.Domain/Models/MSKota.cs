using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_kota")]
    public class MSKota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(4)]
        public char slik_code { get; set; }

        [StringLength(20)]
        public string? lapbul_code { get; set; }

        public int id_provinsi { get; set; }

        [ForeignKey("id_provinsi")]
        public virtual MSProvinsi MSProvinsi { get; set; }

    }
}
