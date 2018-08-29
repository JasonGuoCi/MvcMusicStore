<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ImgDownload.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .error {
            color: red;
        }
    </style>
    <script src="scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript">

        $(function () {
            $("#<%=txtPassword.ClientID%>").blur(function () {
                var str = $(this).val();
                pwStrength(str);
            });
            $("#<%=txtPwdAgain.ClientID%>").blur(function () {
                var pwd1 = $("#<%=txtPassword.ClientID%>").val();
                var pwd2 = $("#<%=txtPwdAgain.ClientID%>").val();
                var flag = checkPwd(pwd1, pwd2);
                if (!flag) {
                    $("#pwdCheck").text("两次密码输入不一致，请重新输入！");
                    $("#<%=btnRegister.ClientID%>").css("display", "none");
                    return false;
                }
                else {
                    $("#pwdCheck").text("");
                    $("#<%=btnRegister.ClientID%>").css("display", "block");
                }
            });

        });

        //两次密码校验
        function checkPwd(str1, str2) {
            if (str1 == str2) {
                return true;
            }
            else {
                return false;
            }
        }


        //判断输入密码的类型    
        function charMode(iN) {
            if (iN >= 48 && iN <= 57) //数字    
                return 1;
            if (iN >= 65 && iN <= 90) //大写    
                return 2;
            if (iN >= 97 && iN <= 122) //小写    
                return 4;
            else
                return 8;
        }
        //bitTotal函数    
        //计算密码模式    
        function bitTotal(num) {
            modes = 0;
            for (i = 0; i < 4; i++) {
                if (num & 1) modes++;
                num >>>= 1;
            }
            return modes;
        }
        //返回强度级别    
        function checkStrong(sPW) {
            if (sPW.length < 6)
                return 0; //密码太短，不检测级别  
            Modes = 0;
            for (i = 0; i < sPW.length; i++) {
                //密码模式    
                Modes |= charMode(sPW.charCodeAt(i));
            }
            return bitTotal(Modes);
        }
        //显示颜色    
        function pwStrength(pwd) {
            //setColor = "#eeeeee";
            Dfault_color = "#eeeeee";     //默认颜色  
            L_color = "#FF0000";      //低强度的颜色，且只显示在最左边的单元格中  
            M_color = "#FF9900";      //中等强度的颜色，且只显示在左边两个单元格中  
            H_color = "#33CC00";      //高强度的颜色，三个单元格都显示  
            if (pwd == null || pwd == '') {
                Lcolor = Mcolor = Hcolor = Dfault_color;
            }
            else {
                S_level = checkStrong(pwd);
                switch (S_level) {
                    case 0:
                        Lcolor = Mcolor = Hcolor = Dfault_color;
                        break;
                    case 1:
                        // setColor = L_color;
                        Lcolor = L_color;
                        Mcolor = Hcolor = Dfault_color;
                        break;
                    case 2:
                        //setColor = M_color;
                        Lcolor = Mcolor = M_color;
                        Hcolor = Dfault_color;
                        break;
                    default:
                        Lcolor = Mcolor = Hcolor = H_color;
                }
            }
            document.getElementById("strength_L").style.background = Lcolor;
            document.getElementById("strength_M").style.background = Mcolor;
            document.getElementById("strength_H").style.background = Hcolor;
            return;
        }


    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server" Text="注册页面"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblUserName" runat="server" Text="用户名：" AssociatedControlID="txtUserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" OnTextChanged="txtUserName_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="lblUserCheck" runat="server" Text="用户名校验：" CssClass="error" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="密码：" AssociatedControlID="txtPassword"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <%--<asp:Label ID="lblPwdStrong" runat="server" Text="密码强度：" Visible="False"></asp:Label>--%>
        <table>
            <tr>
                <td width="40%" align="right ">密码强度:</td>
                <td width="20%" id="strength_L" bgcolor="#eeeeee">弱</td>
                <td width="20%" id="strength_M" bgcolor="#eeeeee">中</td>
                <td width="20%" id="strength_H" bgcolor="#eeeeee">强</td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblPwdAgain" runat="server" Text="重复密码：" AssociatedControlID="txtPwdAgain"></asp:Label>
        <asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password"></asp:TextBox>
        <%-- <asp:Label ID="lblPwdCheck" runat="server" Text="密码校验" Visible="False"></asp:Label>--%>
        <span id="pwdCheck"></span>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="邮箱:" AssociatedControlID="txtEmail"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="注册" />
    </form>
</body>
</html>
