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

        
        public virtual DbSet<OO_SBKData> OO_SBKData { get; set; }
        public virtual DbSet<OO_SMSData> OO_SMSData { get; set; }
   

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
