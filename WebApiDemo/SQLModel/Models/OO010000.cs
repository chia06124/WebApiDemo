namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO010000
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
        public string FormDate { get; set; }

        [Required]
        [StringLength(1)]
        public string ApplyType { get; set; }

        public DateTime ApplyDate { get; set; }

        [Required]
        [StringLength(20)]
        public string RecordPhone { get; set; }

        [Required]
        [StringLength(4)]
        public string Com { get; set; }

        [Required]
        [StringLength(30)]
        public string OpenType { get; set; }

        [Required]
        [StringLength(2)]
        public string CustType { get; set; }

        [Required]
        [StringLength(50)]
        public string CustName { get; set; }

        [Required]
        [StringLength(10)]
        public string CustIDNo { get; set; }

        [Required]
        [StringLength(20)]
        public string CustTaxID { get; set; }

        [Required]
        [StringLength(10)]
        public string Birthday { get; set; }

        [Required]
        [StringLength(10)]
        public string RegZip { get; set; }

        [Required]
        [StringLength(50)]
        public string RegCity { get; set; }

        [Required]
        [StringLength(50)]
        public string RegTown { get; set; }

        [Required]
        [StringLength(300)]
        public string RegAddr { get; set; }

        [Required]
        [StringLength(10)]
        public string ComZip { get; set; }

        [Required]
        [StringLength(50)]
        public string ComCity { get; set; }

        [Required]
        [StringLength(50)]
        public string ComTown { get; set; }

        [Required]
        [StringLength(300)]
        public string ComAddr { get; set; }

        [Required]
        [StringLength(5)]
        public string ComTelArea { get; set; }

        [Required]
        [StringLength(10)]
        public string ComTelNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string MPhone { get; set; }

        [Required]
        [StringLength(400)]
        public string DealAddr { get; set; }

        public DateTime DealDate { get; set; }

        [Required]
        [StringLength(10)]
        public string DealUserId { get; set; }

        [Required]
        [StringLength(4)]
        public string SignCom { get; set; }

        public int OpenSales { get; set; }

        [Required]
        [StringLength(10)]
        public string OpenSalesEmpNo { get; set; }

        [Required]
        [StringLength(400)]
        public string ApproveOpinion { get; set; }

        [Required]
        [StringLength(30)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
