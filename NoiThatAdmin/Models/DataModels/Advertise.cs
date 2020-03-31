namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Advertise")]
    public partial class Advertise
    {
        public int AdvertiseID { get; set; }

        [StringLength(100)]
        public string AdvertiseName { get; set; }

        [StringLength(100)]
        public string AdvertiseImage { get; set; }

        [StringLength(100)]
        public string AdvertiseURL { get; set; }

        public bool? IsActive { get; set; }
    }
}
