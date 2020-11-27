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
using Newtonsoft.Json;
using Newtonsoft.JsonResult;

namespace SQLModel.Repository
{
    public class FUTDataRepository<TEntity> : IRepository<TEntity>
    {
        SqlConnection conn;
        public FUTDataRepository(SqlConnection connnection)
        {
            this.conn = connnection;
        }

        public void Create(TEntity entity)
        {
            string sqlStatement = @"insert into OO_FUTData (FormID,FormNo,ETradingFlag,SettlementWay,MarginCallTrading,MarketPrice,MarginEWay,SignDocVer,CreateUser,CreateDate) "
                + " values (@FormID,@FormNo,@ETradingFlag,@SettlementWay,@MarginCallTrading,@MarketPrice,@MarginEWay,@SignDocVer,@CreateUser,@CreateDate)";
            conn.Execute(sqlStatement, entity);
        }
        public string Get(JObject data)
        {
            string sqlStatement = @"select * from OO_FUTData where FormID=@FromID and FormNo=@FormNo";
            //return conn.Query<TEntity>(sqlStatement, data);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FormID", data["FormID"].ToString());
            parameters.Add("@FormNo", data["FormNo"].ToString());

            var tables = conn.Query<TEntity>(sqlStatement, parameters).ToList();
            return JsonConvert.SerializeObject(tables);
        }

    }
}
