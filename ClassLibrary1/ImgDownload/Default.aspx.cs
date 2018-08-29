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
                if (!user.IsErrorTimesNull() && !user.IsLastErrorTimeNull())//判断是否不为空
                {
                    double timespan = (DateTime.Now - user.LastErrorTime).TotalMinutes;
                    if (user.ErrorTimes > 5 && timespan <= 30)
                    {
                        lblErrorMsg.Text = "密码错误次数超过五次，请半个小时后再登录";
                        lblErrorMsg.Visible = true;
                        //btnLogin.Visible = false;
                        return;
                    }
                }

                if (user.Password == txtPassword.Text)
                {
                    adapter.ResetErrorTimes(user.Id);
                    //adapter.Update(user);
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
                    //if (string.IsNullOrEmpty(user.LastErrorTime.ToString()) || string.IsNullOrEmpty(user.ErrorTimes.ToString()) || user.ErrorTimes == 0)
                    //{
                    //    user.LastErrorTime = DateTime.Now;
                    //    user.ErrorTimes = 0;
                    //}

                    //DateTime lastErrorTime = user.LastErrorTime;
                    //DateTime nowTime = DateTime.Now;
                    //TimeSpan timespan = nowTime - lastErrorTime;
                    //if (timespan.Seconds < 1800)
                    //{
                    //    user.LastErrorTime = nowTime;
                    //    user.ErrorTimes = user.ErrorTimes + 1;

                    //}

                    user.LastErrorTime = DateTime.Now;
                    user.ErrorTimes = user.ErrorTimes + 1;
                    adapter.Update(user);

                    lblErrorMsg.Text = "密码错误，登录失败";
                    lblErrorMsg.Visible = true;
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}