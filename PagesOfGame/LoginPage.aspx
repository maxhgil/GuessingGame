<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: 11pt;
        }
    </style>
</head>
<body style="width: 638px; background-color: #FFFFFF; height: 428px;">
    <form id="form1" runat="server">
    <div style="height: 513px">
        <img src ="https://pbs.twimg.com/profile_images/477174010283696131/pVwxB6St.png" style="height: 376px; width: 566px" />
        <br />
        <asp:Label ID="Label9" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-top: 0px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox4" TextMode ="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
    
        <br />
    
        <br />
        <span class="auto-style1">Don&#39;t have an account? Create one!<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
        </span>
        <asp:Button ID="CreateAccountButton" runat="server" OnClick="CreateAccountButton_Click" Text="CreateAccount" Height="25px" />
    
    </div>
    </form>
</body>
</html>
