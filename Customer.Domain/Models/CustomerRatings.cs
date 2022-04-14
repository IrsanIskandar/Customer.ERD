using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Domain.Models
{
    [Table("customer_ratings")]
    public class CustomerRatings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_customer { get; set; }

        [ForeignKey("id_customer")]
        public virtual Customer Customer { get; set; }

        public int? id_external_rating_agency { get; set; }

        [ForeignKey("id_external_rating_agency")]
        public virtual MSExternalRatingAgency MSExternalRatingAgency { get; set; }

        public int? id_external_rating_result { get; set; }

        [ForeignKey("id_external_rating_result")]
        public virtual MSExternalRating MSExternalRating { get; set; }

        [DataType(DataType.Date)]
        public DateTime? external_rating_date { get; set; }

        public int? id_iif_rating_model { get; set; }

        [ForeignKey("id_iif_rating_model")]
        public virtual MSRatingModel MSRatingModel { get; set; }

        public int? id_iif_rating_result { get; set; }

        [ForeignKey("id_iif_rating_result")]
        public virtual MSRiskRatingModel MSRiskRatingModel { get; set; }

        [DataType(DataType.Date)]
        public DateTime? iif_rating_date { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime created_datetime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? updated_datetime { get; set; }

        [StringLength(50)]
        public string created_by { get; set; }

        [StringLength(50)]
        public string? last_updated_by { get; set; }
    }
}
