namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuImage")]
    public partial class MenuImage
    {
        public int MenuImageID { get; set; }

        [StringLength(100)]
        public string IName { get; set; }

        [StringLength(100)]
        public string ImageURL { get; set; }

        public bool? IsActive { get; set; }

        public int? Sort { get; set; }
    }
}
