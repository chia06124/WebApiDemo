namespace SQLModel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OO_CusCreditData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string FormID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string FormNo { get; set; }

        [StringLength(10)]
        public string Bounced { get; set; }

        [StringLength(10)]
        public string OA { get; set; }

        [StringLength(200)]
        public string OAReason { get; set; }

        [StringLength(10)]
        public string OtherBrokersAcc { get; set; }

        [StringLength(10)]
        public string PersonalIncome { get; set; }

        [StringLength(10)]
        public string FamilyAnnualIncome { get; set; }

        [StringLength(10)]
        public string CompanyIncome { get; set; }

        [StringLength(10)]
        public string Immovables { get; set; }

        [StringLength(10)]
        public string ImmovablesVal { get; set; }

        [StringLength(10)]
        public string Arrears { get; set; }

        [StringLength(10)]
        public string ArrearsVal { get; set; }

        [StringLength(10)]
        public string AvgDeposit { get; set; }

        [StringLength(10)]
        public string OtherAssets { get; set; }

        [StringLength(200)]
        public string OtherAssetsName { get; set; }

        [StringLength(10)]
        public string OtherAssetsVal { get; set; }

        [StringLength(10)]
        public string TotalVal { get; set; }

        [StringLength(10)]
        public string TradingExp { get; set; }

        [StringLength(10)]
        public string TradingExpFY { get; set; }

        [StringLength(10)]
        public string TradingExpSY { get; set; }

        [StringLength(10)]
        public string TradingExpBY { get; set; }

        [StringLength(10)]
        public string TradingExpHY { get; set; }

        [StringLength(200)]
        public string TradingExpOtherN { get; set; }

        [StringLength(10)]
        public string TradingExpOtherY { get; set; }

        [StringLength(10)]
        public string TradingTerm { get; set; }

        [StringLength(10)]
        public string TradingFreq { get; set; }

        [StringLength(10)]
        public string FundsSources { get; set; }

        [StringLength(200)]
        public string FundsSourcesDsc { get; set; }

        [StringLength(10)]
        public string ComCapital { get; set; }

        [StringLength(10)]
        public string FundSize { get; set; }

        [StringLength(10)]
        public string ExpectedQuota { get; set; }

        [StringLength(10)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
