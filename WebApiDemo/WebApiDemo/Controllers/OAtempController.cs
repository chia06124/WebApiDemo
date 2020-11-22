﻿using Newtonsoft.Json.Linq;
using SQLModel.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Transactions;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    [RoutePrefix("api/WebApiTemp")]
    public class OAtempController : ApiController
    {
        [Route("SetApplyData")]
        [HttpPost]
        public HttpResponseMessage SetApplyDataPost([FromBody]JObject data)
        {
            //string sqlStatement = "";
            HttpResponseMessage response = null;
            string message = string.Empty;
            using (TransactionScope scope = new TransactionScope())
            {
                var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["OAtempModel"].ConnectionString);

                try
                {

                    conn.Open();
                    if (data != null)
                    {
                        SMSDataRepository sms = new SMSDataRepository(conn);
                        sms.Create(data);
                        FUTDataRepository fut = new FUTDataRepository(conn);
                        fut.Create(data);
                        //SBKDataRepository sbk = new SBKDataRepository();
                        //sbk.Create(data);
                        //scope.Complete();
                        //message = "Successfully";
                    }
                    //OO_SMSData OO_SMSData = data.ToObject<OO_SMSData>();
                    //OO_SMSData.CreateUser = "Lily";
                    //OO_SMSData.CreateDate = Convert.ToDateTime(DateTime.Now);
                    //sqlStatement = @"insert into OO_SMSData(FormID,FormNo,SettlementWay,ETradingFlag,TDCCBookFlag,SignDocVer,CreateUser,CreateDate) "
                    //   + " values(@FormID,@FormNo,@SettlementWay,@ETradingFlag,@TDCCBookFlag,@SignDocVer,@CreateUser,@CreateDate)";
                    ////conn.Execute(sqlStatement, entity, transaction);

                    //conn.Execute(sqlStatement, OO_SMSData);
                    //OO_FUTData OO_FUTData = data.ToObject<OO_FUTData>();
                    //OO_FUTData.CreateUser = "Lily";
                    //OO_FUTData.CreateDate = Convert.ToDateTime(DateTime.Now);
                    //sqlStatement = @"insert into OO_FUTData (FormID,FormNo,ETradingFlag,SettlementWay,MarginCallTrading,MarketPrice,MarginEWay,SignDocVer,CreateUser,CreateDate) "
                    //   + " values (@FormID,@FormNo,@ETradingFlag,@SettlementWay,@MarginCallTrading,@MarketPrice,@MarginEWay,@SignDocVer,@CreateUser,@CreateDate)";
                    //conn.Execute(sqlStatement, OO_FUTData);
                    scope.Complete();
                    message = "Successfully";
                }
                catch (Exception e)
                {

                    message = e.Message;
                }
                response = Request.CreateResponse<string>(HttpStatusCode.OK, message);
                return response;
            }

        }
    }
}
