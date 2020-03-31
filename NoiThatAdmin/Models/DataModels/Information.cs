namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Information
    {
        [Key]
        public int InfoID { get; set; }

        [StringLength(8)]
        public string InfoCode { get; set; }

        [StringLength(200)]
        public string InfoContent { get; set; }
    }
}
