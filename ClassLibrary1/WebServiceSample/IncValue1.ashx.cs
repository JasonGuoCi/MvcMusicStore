using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for IncValue1
    /// </summary>
    public class IncValue1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            string ispostback = context.Request["ispostback"];
            string num = context.Request["number"];
            if (ispostback == "true")
            {
                num = (Int32.Parse(num) + 1).ToString();
            }
            else
            {
                num = "";
            }
            string path = context.Server.MapPath("IncValue1.html");
            string content = File.ReadAllText(path);
            content = content.Replace("@value", num);
            context.Response.Write(content);
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