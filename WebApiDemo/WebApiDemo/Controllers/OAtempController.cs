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

namespace WebApiDemo.Controllers
{
    

    [RoutePrefix("api/WebApiTemp")]
    public class OAtempController : ApiController
    {
        [Route("SetApplyData")]
        [HttpPost]
        public HttpResponseMessage SetApplyDataPost([FromBody]JObject data)
        {
           
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
    }


}
