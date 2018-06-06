using ImgDownload.DAL.DataSetPicTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImgDownload
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            T_UsersTableAdapter adapter = new T_UsersTableAdapter();
            var data = adapter.GetDataByName(txtUserName.Text);
            if (data.Count <= 0)
            {
                lblErrorMsg.Text = "查无此人";
                lblErrorMsg.Visible = true;
            }
            else
            {
                var user = data.Single();//linq中的single方法，返回唯一一条数据，如果数据为0或多条，则抛出异常
                if (user.Password == txtPassword.Text)
                {
                    Session["IsLogin"] = true;
                    Session["UserId"] = user.Id;
                    //lblErrorMsg.Text = "登录成功";
                    //lblErrorMsg.Visible = true;
                    //登录成功，将用户重定向到download图片页面
                    Response.Redirect("Download.html");
                    //重定向到下载页面
                }
                else
                {
                    lblErrorMsg.Text = "密码错误，登录失败";
                    DateTime lastErrorTime = user.LastErrorTime;
                    DateTime nowTime = DateTime.Now;
                    TimeSpan timespan = nowTime - lastErrorTime;
                    if (timespan.Seconds < 1800)
                    {
                        user.LastErrorTime = nowTime;
                        user.ErrorTimes = user.ErrorTimes + 1;
                        lblErrorMsg.Visible = true;
                    }
                    else
                    {
                        user.ErrorTimes = 0;
                    }
                    

                }
            }
        }
    }
}