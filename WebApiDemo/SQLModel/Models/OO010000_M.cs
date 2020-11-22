namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO010000_M
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string FormID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string FormNo { get; set; }

        [Required]
        [StringLength(4)]
        public string CustType { get; set; }

        [Required]
        [StringLength(4)]
        public string Com { get; set; }

        [Required]
        [StringLength(10)]
        public string ComName { get; set; }

        [Required]
        [StringLength(400)]
        public string DealAddr { get; set; }

        [Required]
        [StringLength(10)]
        public string DealDate { get; set; }

        [Required]
        [StringLength(10)]
        public string DealUserId { get; set; }

        [Required]
        [StringLength(10)]
        public string OpenSales { get; set; }

        [Required]
        [StringLength(20)]
        public string OpenSalesName { get; set; }

        [Required]
        [StringLength(10)]
        public string CustIDNo { get; set; }

        [Required]
        [StringLength(30)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
