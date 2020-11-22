using SQLModel.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLModel.Models;
using Dapper;
using Newtonsoft.Json.Linq;


namespace SQLModel.Repository
{
    public class FUTDataRepository : IRepository
    {
        IDbConnection conn;
        public FUTDataRepository(SqlConnection connnection)
        {
            this.conn = connnection;
        }

        public void Create(JObject entity)
        {
            //var transaction = conn.BeginTransaction();
            OO_FUTData OO_FUTData = entity.ToObject<OO_FUTData>();
            OO_FUTData.CreateUser = "Lily";
            OO_FUTData.CreateDate = Convert.ToDateTime(DateTime.Now);
            string sqlStatement = @"insert into OO_FUTData (FormID,FormNo,ETradingFlag,SettlementWay,MarginCallTrading,MarketPrice,MarginEWay,SignDocVer,CreateUser,CreateDate) "
                + " values (@FormID,@FormNo,@ETradingFlag,@SettlementWay,@MarginCallTrading,@MarketPrice,@MarginEWay,@SignDocVer,@CreateUser,@CreateDate)";
            //conn.Execute(sqlStatement, entity, transaction);

            conn.Execute(sqlStatement, OO_FUTData);

        }

        //public void Dispose()
        //{
        //    this.Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (conn != null)
        //        {
        //            conn.Dispose();
        //            conn = null;
        //        }
        //    }
        //}
    }
}
