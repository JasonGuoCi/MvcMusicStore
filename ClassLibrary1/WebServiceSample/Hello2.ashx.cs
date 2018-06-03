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

            //string userName = context.Request["userName"];
            //判断是不是提交进入，根据一个隐藏字段ispostback
            string ispostback = context.Request["ispostback"];
            if (ispostback == "true")
            {
                context.Response.Write("提交进入");
            }
            else
            {
                context.Response.Write("直接进入");
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