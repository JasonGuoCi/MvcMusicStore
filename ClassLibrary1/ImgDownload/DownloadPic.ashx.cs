using ImgDownload.DAL.DataSetPicTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ImgDownload
{
    /// <summary>
    /// Summary description for DownloadPic
    /// </summary>
    public class DownloadPic : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {

            if (context.Session["IsLogin"] == null)
            {
                context.Response.Redirect("Default.aspx");
            }
            else
            {
                string fileName = context.Request["fileName"];

                context.Response.ContentType = "image/JPEG";
                string encodeFileName = HttpUtility.UrlEncode(fileName);
                context.Response.AddHeader("Content-Disposition", string.Format("attachment:filename=\"{0}\"", encodeFileName));

                int userId = (int)context.Session["UserId"];
                T_UsersTableAdapter adapter = new T_UsersTableAdapter();
                var data = adapter.GetDataById(userId);
                var user = data.Single();
                if (user.Type == 0)//普通用户
                {
                    using (Bitmap bitmap = new Bitmap(context.Server.MapPath("Imgs/" + fileName)))
                    {
                        using (Graphics g = Graphics.FromImage(bitmap))
                        {
                            g.DrawString("免费用户试用--" + user.UserName, new Font("宋体", 20), Brushes.Red, 0, 0);
                        }
                        bitmap.Save(context.Response.OutputStream, ImageFormat.Jpeg);//为了演示，效率不高
                    }
                }
                else//收费用户
                {
                    context.Response.WriteFile("Imgs/" + fileName);//有攻击漏洞
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