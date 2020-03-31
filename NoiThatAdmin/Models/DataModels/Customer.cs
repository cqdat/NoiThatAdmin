namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int CustomerID { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string CustomerImage { get; set; }

        public string CustomerContent { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? Created { get; set; }
    }
}
