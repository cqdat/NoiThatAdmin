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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
            Products1 = new HashSet<Product>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products1 { get; set; }
    }
}
