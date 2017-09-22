<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamePage.aspx.cs" Inherits="WebPageSeparated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="width: 1000px; height: 500px;">
    <div style ="float:left; width:500px; height: 500px;">
    <img src="http://www.raulgonzalez.com/graphics/_lg_guessthenumber.png" width="414" height="290" />
        <br />
        <br />
    
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        Generate a Random Number <asp:Button ID="GenNum" runat="server" OnClick="GenNum_Click" Width="144px" Text="Generate Number" />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Try to guess the number: <asp:TextBox ID="TextBox1" runat="server" Height="24px"></asp:TextBox>
        <asp:Button ID="SubmitGuess" runat="server" OnClick="SubmitGuess_Click" Text="Submit Guess" Width="111px" />
        <br />
    </div>
    <div style ="float: right; width: 500px; height: 500px;">
        <asp:Button style="float:right; margin-left: 0px;" ID="LoginPage" runat="server" Text="Login Page" OnClick="LoginPage_Click" Height="40px" Width="180px" ToolTip="Logs you out and takes you back to the Login Page"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Button style="float:right;" ID="Leaderboard" runat="server" Text="Leaderboards" OnClick="Leaderboard_Click" Height="40px" Width="180px" ToolTip="Takes you to the Leaderboard Page"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Button style="float:right;" ID="ButtonGameChoicePage" runat="server" Text="Game Directory" Height="40px" Width="180px" OnClick="ButtonGameChoicePage_Click" />
        <br />
        <asp:Button ID="AdminLoginPageButton" runat="server" OnClick="AdminLoginPageButton_Click" Text="Admin" />
        <br />
        <strong>Current User:</strong>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <br />
        <strong>Best Score:</strong>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    </div>
    </div>
    </form>
</body>
</html>
