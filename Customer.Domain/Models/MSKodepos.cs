using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_kodepos")]
    public class MSKodepos
    {
        [Key]
        public int id { get; set; }

        public int id_kelurahan { get; set; }

        [ForeignKey("id_kelurahan")]
        public virtual MSKelurahan MSKelurahan { get; set; }

        [StringLength(10)]
        public string postal_code { get; set; }
    }
}
