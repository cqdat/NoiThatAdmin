namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolesUser")]
    public partial class RolesUser
    {
        public int RolesUserID { get; set; }

        public int? RoleID { get; set; }

        public int? UserID { get; set; }

        public DateTime? Created { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
