<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicTacToe.aspx.cs" Inherits="PagesOfGame_TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 46px;
        }
        .auto-style3 {
            width: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 772px">
        
        <asp:Button style="float:right;" ID="ButtonGameDirectory" runat="server" Text="Game Directory" OnClick="ButtonGameDirectory_Click" />
        <asp:Button style="float: right;" ID="ButtonLogout" runat="server" Text="Logout" OnClick="ButtonLogout_Click" />
        <asp:Label ID="Label2" runat="server" Text="Welcome to Tic-Tac-Toe, would you like to be Red or Blue?"></asp:Label>
        <br />
        <asp:Button ID="ButtonRed" runat="server" OnClick="ButtonRed_Click" Text="Red" Width="100px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBlue" runat="server" OnClick="ButtonBlue_Click" Text="Blue" Width="100px" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="ButtonYes" runat="server" OnClick="ButtonReset_Click" Text="Yes" Visible="False" Width="100px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonNo" runat="server" Text="No" Visible="False" Width="100px" OnClick="ButtonNo_Click" />
        <br />
    
        <table style="width: 11%;">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button00" runat="server" BorderColor="Black" OnClick="Button_Click" Height="50px" Text="          " Visible="False" Width="50px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button01" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button02" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button10" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button11" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button12" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button20" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button21" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button22" runat="server" BorderColor="Black" Height="50px" OnClick="Button_Click" Visible="False" Width="50px" />
                </td>
            </tr>
        </table>
    
    </div>
        <p>
            <asp:Button ID="ButtonReset" runat="server" OnClick="ButtonReset_Click" Text="Reset" Width="100px" />
        </p>
    </form>
</body>
</html>