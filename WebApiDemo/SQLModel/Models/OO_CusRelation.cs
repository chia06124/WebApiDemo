namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_CusRelation
    {
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
        public string RelationType { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationSerial { get; set; }

        [StringLength(15)]
        public string RelationChName { get; set; }

        [StringLength(30)]
        public string RelationEngName { get; set; }

        [StringLength(50)]
        public string RelationIDNo { get; set; }

        [StringLength(10)]
        public string RelationShip { get; set; }

        [StringLength(10)]
        public string RelationBirthday { get; set; }

        [StringLength(20)]
        public string RelationNationality { get; set; }

        [StringLength(10)]
        public string RegZip { get; set; }

        [StringLength(300)]
        public string RegAddr { get; set; }

        [StringLength(10)]
        public string RegTelArea { get; set; }

        [StringLength(20)]
        public string RegTelNumber { get; set; }

        [StringLength(10)]
        public string ComZip { get; set; }

        [StringLength(300)]
        public string ComAddr { get; set; }

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

        [StringLength(20)]
        public string MPhone { get; set; }

        [StringLength(20)]
        public string ServiceClass { get; set; }

        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
