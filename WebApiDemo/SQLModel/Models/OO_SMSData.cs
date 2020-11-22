namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_SMSData
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
        [StringLength(10)]
        public string SettlementWay { get; set; }

        [Required]
        [StringLength(4)]
        public string ETradingFlag { get; set; }

        [Required]
        [StringLength(4)]
        public string TDCCBookFlag { get; set; }

        [Required]
        [StringLength(50)]
        public string SignDocVer { get; set; }

        [Required]
        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
