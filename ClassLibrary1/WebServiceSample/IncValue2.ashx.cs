using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for IncValue2
    /// </summary>
    public class IncValue2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("Hello World");
            string ispostback = context.Request["ispostback"];
            string value = "0";
            if (ispostback == "true")
            {
                string num = context.Request["num"];
                value = (Int32.Parse(num) + 1).ToString();
            }

            string fullPath = context.Server.MapPath("IncValue2.html");
            string content = File.ReadAllText(fullPath);
            content = content.Replace("@value", value);
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