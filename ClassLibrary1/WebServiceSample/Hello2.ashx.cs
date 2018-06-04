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

            //string userName = context.Request["userName"];
            //判断是不是提交进入，根据一个隐藏字段ispostback
            string ispostback = context.Request["ispostback"];
            string userName = context.Request["userName"];
            string msg = "";
            if (ispostback == "true")
            {
                context.Response.Write("提交进入");
                msg = "Hello " + userName;
            }
            else
            {
                context.Response.Write("直接进入");
                userName = "";
                msg = "";
            }
            string path = context.Server.MapPath("Hello2.html");
            string con = File.ReadAllText(path);
            con = con.Replace("@value", userName);
            con = con.Replace("@msg", msg);
            context.Response.Write(con);

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