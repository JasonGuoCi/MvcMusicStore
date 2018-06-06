using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebServiceSample
{
    /// <summary>
    /// Summary description for YZM
    /// </summary>
    public class YZM : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/JPEG";
            using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(100, 50))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawString("腾讯视频", new System.Drawing.Font("宋体", 30), Brushes.Red, new System.Drawing.PointF(0, 0));
                    bitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
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