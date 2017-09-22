<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GameChoicePage.aspx.cs" Inherits="PagesOfGame_GameChoicePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 251px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="Black" Text="Game Directory"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonGuessGame" runat="server" Height="40px" OnClick="ButtonGuessGame_Click" Text="GuessingGame" Width="200px" />
        <br />
        <br />
        <asp:Button ID="ButtonTicTacToe" runat="server" Height="40px" OnClick="ButtonTicTacToe_Click" Text="2Player Tic-Tac-Toe" Width="200px" />
        <br />
        <br />
        <asp:Button ID="ButtonLogout" runat="server" Height="40px" OnClick="ButtonLogout_Click" Text="Logout" Width="200px" />
    
    </div>
    </form>
</body>
</html>
