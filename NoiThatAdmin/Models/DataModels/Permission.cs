namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permission")]
    public partial class Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permission()
        {
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int PermissionID { get; set; }

        [StringLength(20)]
        public string PermissionCode { get; set; }

        [StringLength(50)]
        public string PermissionName { get; set; }

        public DateTime? Created { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
