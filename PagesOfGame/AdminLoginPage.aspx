<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLoginPage.aspx.cs" Inherits="AdminLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; font-size: large">
    
        <strong><span class="auto-style1">
        <br />
        <asp:Image ID="Image1" runat="server" Height="76px" ImageUrl="http://www.iconhot.com/icon/png/rrze/720/user-admin-1.png" style="margin-right: 0px" Width="76px" />
        Admin Login</span></strong><br />
        <br />
        Admin Username: <asp:TextBox ID="AdminUsernameTextBox" runat="server"></asp:TextBox>
        <br />
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="AdminPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
        <br />
        <asp:Button ID="AdminLoginButton" runat="server" OnClick="AdminLoginButton_Click" Text="Login" Width="87px" />
    
    </div>
    </form>
</body>
</html>
