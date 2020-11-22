namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_NRLInsider
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
        [StringLength(20)]
        public string StockId { get; set; }

        [Required]
        [StringLength(20)]
        public string RoleType { get; set; }

        [Required]
        [StringLength(10)]
        public string RelationShip { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
