namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_CusBaseData
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
        [StringLength(50)]
        public string CustIDNo { get; set; }

        [StringLength(50)]
        public string CustTaxID { get; set; }

        [Required]
        [StringLength(15)]
        public string CustName { get; set; }

        [StringLength(30)]
        public string CustEngName { get; set; }

        [StringLength(10)]
        public string Birthday { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string BirthCountry { get; set; }

        [StringLength(50)]
        public string BirthCity { get; set; }

        [StringLength(50)]
        public string Edu { get; set; }

        [StringLength(10)]
        public string JobOcc { get; set; }

        [StringLength(20)]
        public string JobOccDesc { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [StringLength(10)]
        public string RegZip { get; set; }

        [StringLength(50)]
        public string RegAddr { get; set; }

        [StringLength(10)]
        public string ComZip { get; set; }

        [StringLength(50)]
        public string ComAddr { get; set; }

        [StringLength(200)]
        public string ResiAddr { get; set; }

        [StringLength(20)]
        public string MPhone { get; set; }

        [StringLength(10)]
        public string RegTelArea { get; set; }

        [StringLength(20)]
        public string RegTelNumber { get; set; }

        [StringLength(10)]
        public string ComTelArea { get; set; }

        [StringLength(20)]
        public string ComTelNumber { get; set; }

        [StringLength(10)]
        public string CompTelArea { get; set; }

        [StringLength(20)]
        public string CompTelNumber { get; set; }

        [StringLength(10)]
        public string CompTelExt { get; set; }

        [StringLength(10)]
        public string FaxArea { get; set; }

        [StringLength(20)]
        public string FaxNumber { get; set; }

        [StringLength(100)]
        public string EMail { get; set; }

        [StringLength(10)]
        public string DocWay { get; set; }

        [StringLength(5)]
        public string CustClass { get; set; }

        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
