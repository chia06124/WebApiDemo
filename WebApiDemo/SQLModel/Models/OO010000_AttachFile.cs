namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO010000_AttachFile
    {
        [Key]
        public int AttachFileId { get; set; }

        [Required]
        [StringLength(10)]
        public string FormID { get; set; }

        [Required]
        [StringLength(12)]
        public string FormNo { get; set; }

        [Required]
        [StringLength(4)]
        public string AttachFileType { get; set; }

        [Required]
        [StringLength(30)]
        public string AttachFileName { get; set; }

        [Required]
        public byte[] AttachFileBody { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
