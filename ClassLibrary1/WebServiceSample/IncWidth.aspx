<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncWidth.aspx.cs" Inherits="WebServiceSample.IncWidth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnIncrease" runat="server" Text="自增" OnClick="btnIncrease_Click" />
        </div>
    </form>
</body>
</html>
