namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_PhotoData
    {
        [Key]
        public int Serial { get; set; }

        [Required]
        [StringLength(10)]
        public string FormID { get; set; }

        [Required]
        [StringLength(12)]
        public string FormNo { get; set; }

        public int PType { get; set; }

        public int SType { get; set; }

        public int RoleCode { get; set; }

        public int RoleCodeSerial { get; set; }

        [Required]
        public byte[] Binary { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
