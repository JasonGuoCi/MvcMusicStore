using ImgDownload.DAL.DataSetPicTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImgDownload
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUserName_TextChanged(object sender, EventArgs e)
        {
            T_UsersTableAdapter adapter = new T_UsersTableAdapter();
            var user = adapter.GetDataByName(txtUserName.Text);
            if (user.Count > 0)
            {
                lblUserCheck.Text = "用户名已存在，请重新输入";
                lblUserCheck.Visible = true;
                return;
            }
            else
            {
                lblUserCheck.Visible = false;
            }
        }
    }
}