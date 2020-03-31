namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductRating")]
    public partial class ProductRating
    {
        [Key]
        public int ReviewID { get; set; }

        public int? ProductID { get; set; }

        public int? PValue { get; set; }

        public int? PQuality { get; set; }

        public int? PPrice { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(400)]
        public string Comment { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(100)]
        public string Reviewer { get; set; }

        [StringLength(100)]
        public string EmailReview { get; set; }

        public bool? Confirmed { get; set; }

        public DateTime? Created { get; set; }

        public virtual Product Product { get; set; }
    }
}
