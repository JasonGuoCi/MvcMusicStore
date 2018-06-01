using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for Hello2
    /// </summary>
    public class Hello2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            string con = context.Server.MapPath("Hello2.html");
            context.Response.Write(File.ReadAllText(con));
            string userName = context.Request["userName"];
            if (string.IsNullOrEmpty(userName))
            {
                context.Response.Write("直接进入");
            }
            else
            {
                context.Response.Write("提交进入");
            }

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