using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImgDownload
{
    /// <summary>
    /// Summary description for code
    /// </summary>
    public class code : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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