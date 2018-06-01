using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for Hello
    /// </summary>
    public class Hello : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string userName = context.Request["userName"];
            context.Response.Write("Hello World");
            context.Response.Write(userName);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}