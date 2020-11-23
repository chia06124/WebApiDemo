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
        SqlConnection conn;
        public SMSDataRepository(SqlConnection connnection)
        {
            this.conn = connnection;
        }
        public void Create(TEntity entity)
        {
            
            string sqlStatement = @"insert into OO_SMSData(FormID,FormNo,SettlementWay,ETradingFlag,TDCCBookFlag,SignDocVer,CreateUser,CreateDate) "
                + " values(@FormID,@FormNo,@SettlementWay,@ETradingFlag,@TDCCBookFlag,@SignDocVer,@CreateUser,@CreateDate)";
            conn.Execute(sqlStatement, entity);
        }

        
    }
}
