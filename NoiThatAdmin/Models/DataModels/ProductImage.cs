namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        [Key]
        public int ImageID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string URLImage { get; set; }

        [StringLength(100)]
        public string ImagesThumb { get; set; }

        public DateTime? Created { get; set; }

        public virtual Product Product { get; set; }
    }
}
