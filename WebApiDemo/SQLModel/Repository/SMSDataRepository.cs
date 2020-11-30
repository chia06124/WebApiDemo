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
using System.Collections;
using Newtonsoft.Json;

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

        public string Get(JObject data)
        {
            OO_SMSData OOSMSData = data.ToObject<OO_SMSData>();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FormID", data["FormID"].ToString());
            parameters.Add("@FormNo", data["FormNo"].ToString());
            System.Diagnostics.Debug.Write(data["FormID"].ToString());
            string sqlStatement = @"select * from OO_SMSData where FormID=@FormID and FormNo=@FormNo";
            var tables = conn.Query<TEntity>(sqlStatement, parameters).ToList();
            return JsonConvert.SerializeObject(tables);
        }

        public void Update(TEntity data)
        {
            string sqlStatement = @"update OO_SMSData "
                                + " set SettlementWay=@SettlementWay,ETradingFlag=@ETradingFlag,TDCCBookFlag=@TDCCBookFlag,@SignDocVer=SignDocVer,CreateUser=@CreateUser,CreateDate=@CreateDate "
                                + " where FormID=@FormID and FormNo=@FormNo ";
            conn.Execute(sqlStatement, data);
        }
        public void Delete(JObject data)
        {
            string sqlStatement = @"delete from OO_SMSData "
                + " where FormID = @FormID and FormNo=@FormNo";
            conn.Execute(sqlStatement, data);
        }
    }
}
