using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Models
{
    [Table("ms_external_rating_agency")]
    public class MSExternalRatingAgency
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string description { get; set; }
    }
}
