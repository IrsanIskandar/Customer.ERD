using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_Kelurahan")]
    public class MSKelurahan
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(20)]
        public string slik_code { get; set; }

        [StringLength(20)]
        public string? lapbulCode { get; set; }

        public int id_kecamatan { get; set; }

        [ForeignKey("id_kecamatan")]
        public virtual MSKecamatan MSKecamatan { get; set; }
    }
}
