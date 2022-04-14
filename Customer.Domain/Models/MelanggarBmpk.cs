using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("melanggar_bmpk")]
    public class MelanggarBmpk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual ICollection<Customer> Customers { get; set; }

        [StringLength(1)]
        public char flag_langgar_bmpk { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime last_stamp { get; set; }
    }
}
