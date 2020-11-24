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
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [RoutePrefix("api/WebApiToken")]
    public class TokenController : ApiController
    {

        private TokenManager _tokenManager;
        public TokenController()
        {
            _tokenManager = new TokenManager();
        }
        //紀錄 Refresh Token，需紀錄在資料庫
        private static Dictionary<string, User> refreshTokens = new Dictionary<string, User>();


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

            }
            else
            {
                return new
                {
                    Result = false,
                    Error = new UnauthorizedAccessException("帳號密碼錯誤")
            };
                
            }
        }


        [Route("TokenSignIn")]
        [HttpPost]
        public Token SignIn(User user)
        {
            //模擬從資料庫取得資料
            //if (!(model.UserId == "abc" && model.Password == "123"))
            //{
            //    throw new Exception("登入失敗，帳號或密碼錯誤");
            //}
            //var user = new User
            //{
            //    Id = 1,
            //    UserId = "abc",
            //    UserName = "小明"
            //};
            //產生 Token
            var token = _tokenManager.Create(user);
            //需存入資料庫
            refreshTokens.Add(token.refresh_token, user);
            return token;
        }

    }
}
