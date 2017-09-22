<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewUserCreationPage.aspx.cs" Inherits="PagesOfGame_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: 46pt;
        }
        .auto-style2 {
            font-size: large;
            font-weight: 700;
        }
        .auto-style3 {
            font-size: small;
            font-weight: normal;
        }
        .auto-style4 {
            font-size: 20pt;
            font-weight: 700;
        }
    </style>
</head>
<body style="height: 550px">
    <form id="form1" runat="server">
    <div style="height: 550px; font-size: xx-large; font-weight: 700">
    
        <h1 class="auto-style1">Create New User</h1>
        <br />
        <span class="auto-style2">Username:<asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        <br />
        Password: <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <br />
        Re-Type Password:<asp:TextBox ID="ReTypedPasswordTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        </span><span class="auto-style4">Human Check</span><span class="auto-style2"><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="HumanCheckLabel" runat="server"></asp:Label>
&nbsp;</span><span class="auto-style3">(8 characters in total including spaces)</span><span class="auto-style2"><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="HumanCheckTextBox" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="WrongHumanCheckLabel" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="CreateNewUserButton_Click" style="font-size: small" Text="Create New User" />
        </span>
    
    </div>
    </form>
</body>
</html>
