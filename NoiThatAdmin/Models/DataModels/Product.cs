namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [StringLength(20)]
        public string ProductCode { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }

        [StringLength(12)]
        public string Price { get; set; }

        [StringLength(12)]
        public string PriceSale { get; set; }

        public int? CategoryIDParent { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(100)]
        public string Images { get; set; }

        [StringLength(100)]
        public string ImagesThumb { get; set; }

        [StringLength(400)]
        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public bool? InStock { get; set; }

        public bool? IsSale { get; set; }

        public bool? IsNew { get; set; }

        public int? Rating { get; set; }

        public bool? IsActive { get; set; }

        public int? CountView { get; set; }

        public DateTime? Created { get; set; }

        public int? CreatedBy { get; set; }

        [StringLength(200)]
        public string SEOTitle { get; set; }

        [StringLength(200)]
        public string SEOUrlRewrite { get; set; }

        [StringLength(200)]
        public string SEOKeywords { get; set; }

        public string SEOMetadescription { get; set; }

        public virtual Category Category { get; set; }

        public virtual Category Category1 { get; set; }
    }
}
