<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Leaderboard.aspx.cs" Inherits="PagesOfGame_Default" %>

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
<body style="height: 650px; width: 727px">
    <form id="form1" runat="server">
    <div class="auto-style1" style="float:left; width: 277px">
    
        <strong><asp:Image ID="Image1" runat="server" Height="250px" ImageUrl="https://badgeos.org/wp-content/uploads/edd/2013/11/leaderboard-300x300.png" Width="250px" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" SelectCommand="SELECT id, best_score FROM login WHERE (best_score &lt; 10 AND best_score &gt; 0) ORDER BY best_score ASC"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" style="font-size: medium" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="250px">
            <AlternatingItemStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                User:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                <br />
                Best Score:
                <asp:Label ID="best_scoreLabel" runat="server" Text='<%# Eval("best_score") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
        </strong>
    
    </div>
    <div style="float:right; width: 447px; height: 124px;">
        <asp:Button style="float:right; margin-left: 0px;" ID="LoginPage" runat="server" Text="Login Page" OnClick="LoginPage_Click" Height="40px" Width="180px" ToolTip="Logs you out and takes you back to the Login Page"></asp:Button>
        <br />
        <br />
        <br />
        <asp:Button style="float:right;" ID="GamePage" runat="server" Text="Game Page" OnClick="GamePage_Click" Height="40px" Width="180px" ToolTip="Takes you back to the Number Guessing Game Page"></asp:Button>
        <br />
        
    </div>
    </form>
</body>
</html>
