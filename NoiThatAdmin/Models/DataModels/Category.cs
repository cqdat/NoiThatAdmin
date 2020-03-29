namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int CategoryID { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        public int? Parent { get; set; }

        public bool? DisplayMenu { get; set; }

        public bool? IsActive { get; set; }

        public int? Sort { get; set; }

        [StringLength(200)]
        public string SEOTitle { get; set; }

        [StringLength(200)]
        public string SEOUrlRewrite { get; set; }

        [StringLength(200)]
        public string SEOKeywords { get; set; }

        public string SEOMetadescription { get; set; }
    }
}
