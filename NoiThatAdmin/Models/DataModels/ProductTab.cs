namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductTab")]
    public partial class ProductTab
    {
        [Key]
        public int TabID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(100)]
        public string TabTitle { get; set; }

        public string TabContent { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? Created { get; set; }

        public virtual Product Product { get; set; }
    }
}
