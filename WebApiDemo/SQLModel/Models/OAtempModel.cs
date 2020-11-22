namespace SQLModel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OAtempModel : DbContext
    {
        public OAtempModel()
            : base("name=OAtempModel")
        {
        }

        public virtual DbSet<OO_CusBaseData> OO_CusBaseData { get; set; }
        public virtual DbSet<OO_CusCreditData> OO_CusCreditData { get; set; }
        public virtual DbSet<OO_CusRelation> OO_CusRelation { get; set; }
        public virtual DbSet<OO_FUTData> OO_FUTData { get; set; }
        public virtual DbSet<OO_NRLData> OO_NRLData { get; set; }
        public virtual DbSet<OO_NRLInsider> OO_NRLInsider { get; set; }
        public virtual DbSet<OO_NRLRelated> OO_NRLRelated { get; set; }
        public virtual DbSet<OO_PhotoData> OO_PhotoData { get; set; }
        public virtual DbSet<OO_SBKData> OO_SBKData { get; set; }
        public virtual DbSet<OO_SMSData> OO_SMSData { get; set; }
        public virtual DbSet<OO_TaxResidency> OO_TaxResidency { get; set; }
        public virtual DbSet<OO_TxnBank> OO_TxnBank { get; set; }
        public virtual DbSet<OO010000> OO010000 { get; set; }
        public virtual DbSet<OO010000_AttachFile> OO010000_AttachFile { get; set; }
        public virtual DbSet<OO010000_M> OO010000_M { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.Edu)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.RegZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.ComZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.RegTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.RegTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.ComTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.ComTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.CompTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.CompTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.CompTelExt)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.CustClass)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusBaseData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusCreditData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusCreditData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusCreditData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.RelationType)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.RegZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.RegTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.RegTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.ComZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.ComTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.ComTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.CompTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.CompTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.CompTelExt)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.ServiceClass)
                .IsUnicode(false);

            modelBuilder.Entity<OO_CusRelation>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_FUTData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_FUTData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_FUTData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLInsider>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLInsider>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLInsider>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLRelated>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLRelated>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLRelated>()
                .Property(e => e.Cosy)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLRelated>()
                .Property(e => e.CustAccount)
                .IsUnicode(false);

            modelBuilder.Entity<OO_NRLRelated>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_PhotoData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_PhotoData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_PhotoData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SBKData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SBKData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SBKData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SMSData>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SMSData>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_SMSData>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.NationCode)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.TaxID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.ReasonID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TaxResidency>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TxnBank>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TxnBank>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO_TxnBank>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.FormDate)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.ApplyType)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.RecordPhone)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.Com)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.OpenType)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.CustType)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.CustIDNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.CustTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.RegZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.ComZip)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.ComTelArea)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.ComTelNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.MPhone)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.DealUserId)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.SignCom)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.OpenSalesEmpNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_AttachFile>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_AttachFile>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_AttachFile>()
                .Property(e => e.AttachFileType)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_AttachFile>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.FormID)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.FormNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.CustType)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.Com)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.ComName)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.DealDate)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.DealUserId)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.OpenSales)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.CustIDNo)
                .IsUnicode(false);

            modelBuilder.Entity<OO010000_M>()
                .Property(e => e.CreateUser)
                .IsUnicode(false);
        }
    }
}
