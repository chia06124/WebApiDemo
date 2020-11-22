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
using System.Data.Entity;
namespace SQLModel.Repository
{
    public class SMSDataRepository<TEntity> : IRepository<TEntity>
    {
        IDbConnection conn;
        public SMSDataRepository(SqlConnection connnection)
        {
            this.conn = connnection;
        }

        public void Create(TEntity entity)
        {
            //var transaction = conn.BeginTransaction();
            //OO_SMSData OO_SMSData = entity.ToObject<OO_SMSData>();
            //OO_SMSData.CreateUser = "Lily";
            //OO_SMSData.CreateDate = Convert.ToDateTime(DateTime.Now);
            string sqlStatement = @"insert into OO_SMSData(FormID,FormNo,SettlementWay,ETradingFlag,TDCCBookFlag,SignDocVer,CreateUser,CreateDate) "
                + " values(@FormID,@FormNo,@SettlementWay,@ETradingFlag,@TDCCBookFlag,@SignDocVer,@CreateUser,@CreateDate)";
            //conn.Execute(sqlStatement, entity, transaction);

            conn.Execute(sqlStatement, entity);

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
