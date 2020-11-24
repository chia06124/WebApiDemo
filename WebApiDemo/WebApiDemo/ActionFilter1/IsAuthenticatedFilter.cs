using Jose;
using Newtonsoft.Json.Linq;
using SQLModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApiDemo.Controllers;
using WebApiDemo.Models;

namespace WebApiDemo.ActionFilter1
{
    public class IsAuthenticatedFilter : ActionFilterAttribute
    {
        private TokenManager  _tokenManager = new TokenManager();
       
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //var secret = "Hello";
            if (actionContext.Request.Content == null)
            {
                setErrorResponse(actionContext, "驗證錯誤");
            }
            else
            {
                try
                {
                    var authoriaztion = HttpContext.Current.Request.Headers["Authoriaztion"];
                    //var temp = actionContext.ActionArguments["data"].ToString();
                    //IList<JToken> obj = JObject.Parse(authoriaztion);
                    //var Authorization = (((JProperty)obj[0]).Value).ToString();
                    var user = _tokenManager.GetUser(authoriaztion);
                    if (user == null)
                    {
                        setErrorResponse(actionContext, "帳號已過期");
                    }

                }
                catch (Exception ex)
                {
                    setErrorResponse(actionContext, ex.Message);
                }
            }
            base.OnActionExecuting(actionContext);
        }
        private static void setErrorResponse(HttpActionContext actionContext, string message)
        {
            var response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, message);
            actionContext.Response = response;
        }
    }
}