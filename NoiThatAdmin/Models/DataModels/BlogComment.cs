namespace NoiThatAdmin.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlogComment")]
    public partial class BlogComment
    {
        [Key]
        public int CommentID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Images { get; set; }

        public string Content { get; set; }

        public int? BlogID { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(100)]
        public string Commenter { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
