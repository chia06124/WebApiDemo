using Jose;
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

namespace WebApiDemo.AuthHelper
{
    public class JwtAuthActionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var secret = "Hello";
            if (actionContext.Request.Headers.Authorization==null )
            {
                setErrorResponse(actionContext, "驗證錯誤");
            }
            else
            {
                try
                {
                    var jwtObject = JWT.Decode<JwtAuthObject>(actionContext.Request.Headers.Authorization.Scheme, Encoding.UTF8.GetBytes(secret),JwsAlgorithm.HS256);
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