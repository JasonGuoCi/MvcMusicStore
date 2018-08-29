<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImgDownload.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
            &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
            &nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="验证码："></asp:Label>
            &nbsp;<asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
            <asp:ImageButton ID="imgBtn" runat="server" ImageUrl="~/code.ashx" />
            <br />
            <asp:Label ID="lblErrorMsg" runat="server" BackColor="Red" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" />

            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="注册" />

        </div>
    </form>
</body>
</html>
