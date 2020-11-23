using Jose;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using SQLModel.Models;


namespace WebApiDemo.Controllers
{
    [RoutePrefix("api/WebApiToken")]
    public class TokenController : ApiController
    {
        string secret = "Hello";
        [Route("TokenPostUser")]
        [HttpPost]
        public object PostUser([FromBody]JObject loginData)
        {
            if (loginData["FormID"].ToObject<string>() == "Allen" && loginData["Password"].ToObject<string>() == "0814")
            {
                JwtAuthObject payload = new JwtAuthObject();
                payload.ID = "Alien";
                return new
                {
                    Result = true,
                    token = Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS256)
                };
            }else
            {
                return new
                {
                    Result = false,
                    Error = new UnauthorizedAccessException("帳號密碼錯誤")
            };
                
            }
        }

    }
}
