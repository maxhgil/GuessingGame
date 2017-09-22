<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <h1 style="width: 1551px"><strong style="text-align: left">ADMIN CONTROL PAGE<br />
&nbsp;<asp:Button ID="ReturnToLoginButton" runat="server" OnClick="ReturnToLoginButton_Click" Text="Return to Login Page" Width="225px" />
&nbsp;<asp:Button ID="ReturnToGamePageButton" runat="server" OnClick="ReturnToGamePageButton_Click" Text="Return to Game Page" Width="225px" />
            </strong></h1>
        <p class="auto-style2" style="text-align: left">
            Password Reset:</p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            Enter username:
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            Enter new password: <asp:TextBox ID="NewPasswordTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            Re-enter new password:
            <asp:TextBox ID="ReenteredNewPasswordTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            <asp:Button ID="ResetPasswordButton" runat="server" OnClick="ResetPasswordButton_Click" Text="Reset Password" Width="166px" />
        </p>
        <p class="auto-style2" style="text-align: left">
            Reset Score:</p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            Enter username: <asp:TextBox ID="Reset_1PersonScoreTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            <asp:Button ID="ResetScore_1PersonButton" runat="server" OnClick="ResetScore_1PersonButton_Click" Text="Reset Score" Width="166px" />
        </p>
        <p class="auto-style2" style="text-align: left">
            Reset All Scores:</p>
        <p style="text-align: left; font-size: medium; margin-left: 40px">
            <asp:Button ID="ResetAllScoresButton" runat="server" OnClick="ResetAllScoresButton_Click" Text="ResetAllScores" />
        </p>
    
    </div>
    </form>
</body>
</html>
