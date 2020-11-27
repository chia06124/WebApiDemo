using Newtonsoft.Json.Linq;
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
using SQLModel.Models;
using WebApiService;
using SQLModel.Connection;
using System.Data;
using WebApiDemo.AuthHelper;
using WebApiDemo.ActionFilter1;
using Newtonsoft.JsonResult;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace WebApiDemo.Controllers
{


    [RoutePrefix("api/WebApiTemp")]
    public class OAtempController : ApiController
    {
        [Route("SetApplyData")]
        [HttpPost]
        // [JwtAuthActionFilter]
        [IsAuthenticatedFilter]
        public HttpResponseMessage SetApplyDataPost([FromBody]JObject data)
        {

            HttpResponseMessage response = null;
            string message = string.Empty;
            using (TransactionScope scope = new TransactionScope())
            {
                ConnectionFactory Connection = new ConnectionFactory();
                SqlConnection conn = Connection.CreateConnection();
                try
                {
                    conn.Open();
                    if (data != null)
                    {
                        SMSDataService SMSData = new SMSDataService(conn);
                        SMSData.Create(data);

                        FUTDataService FUTData = new FUTDataService(conn);
                        FUTData.Create(data);
                    }

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


        [Route("GetApplyData")]
        [HttpPost]
        // [JwtAuthActionFilter]
        [IsAuthenticatedFilter]

        public List<OO_SMSData> GetApplyData([FromBody]JObject data)
        //public string GetApplyData([FromBody]JObject data)
        {
            string message = string.Empty;
            using (TransactionScope scope = new TransactionScope())
            {
                ConnectionFactory Connection = new ConnectionFactory();
                SqlConnection conn = Connection.CreateConnection();
                SMSDataService SMSData = null;
                try
                {
                    conn.Open();
                    if (data != null)
                    {

                        //SMSData = new SMSDataService(conn);
                        SMSData = new SMSDataService(conn);
                        

                    }
                }
                catch (Exception e)
                {
                    message = e.Message;
                    string rowString = SMSData.ToString();
                }
                //return SMSData.Get(data);
                return JsonConvert.DeserializeObject<List<OO_SMSData>>(SMSData.Get(data));
            }

        }

    }
}

