namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_NRLRelated
    {
        [Key]
        public int Serial { get; set; }

        [Required]
        [StringLength(10)]
        public string FormID { get; set; }

        [Required]
        [StringLength(12)]
        public string FormNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Cosy { get; set; }

        [Required]
        [StringLength(7)]
        public string CustAccount { get; set; }

        [Required]
        [StringLength(15)]
        public string Relationship { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
