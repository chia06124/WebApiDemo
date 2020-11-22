namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_TxnBank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Serial { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string FormID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string FormNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Currency { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepositWithdraw { get; set; }

        [Required]
        [StringLength(10)]
        public string BankBranchCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Account { get; set; }

        [Required]
        [StringLength(30)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
