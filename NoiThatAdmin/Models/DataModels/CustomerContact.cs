namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerContact")]
    public partial class CustomerContact
    {
        public int CustomerContactID { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(15)]
        public string CustomerPhone { get; set; }

        public string CustomerContent { get; set; }

        public DateTime? Created { get; set; }
    }
}
