using SQLModel.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLModel.Models;
using Newtonsoft.Json.Linq;
using Dapper;

namespace SQLModel.Repository
{
    public class SMSDataRepository : IRepository
    {
        IDbConnection conn;
        public SMSDataRepository(SqlConnection connnection)
        {
            this.conn = connnection;
        }

        public void Create(JObject entity)
        {
            //var transaction = conn.BeginTransaction();
            OO_SMSData OO_SMSData = entity.ToObject<OO_SMSData>();
            OO_SMSData.CreateUser = "Lily";
            OO_SMSData.CreateDate = Convert.ToDateTime(DateTime.Now);
            string sqlStatement = @"insert into OO_SMSData(FormID,FormNo,SettlementWay,ETradingFlag,TDCCBookFlag,SignDocVer,CreateUser,CreateDate) "
                + " values(@FormID,@FormNo,@SettlementWay,@ETradingFlag,@TDCCBookFlag,@SignDocVer,@CreateUser,@CreateDate)";
            //conn.Execute(sqlStatement, entity, transaction);

            conn.Execute(sqlStatement, OO_SMSData);

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
