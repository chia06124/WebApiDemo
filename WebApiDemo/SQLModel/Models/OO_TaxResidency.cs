namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_TaxResidency
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
        [StringLength(10)]
        public string NationCode { get; set; }

        [StringLength(50)]
        public string NationName { get; set; }

        [StringLength(20)]
        public string TaxID { get; set; }

        [StringLength(2)]
        public string ReasonID { get; set; }

        [StringLength(50)]
        public string ReasonDesc { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
