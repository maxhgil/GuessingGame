using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagesOfGame_GameChoicePage : System.Web.UI.Page
{

    protected void ButtonGuessGame_Click(object sender, EventArgs e)
    {
        Server.Transfer("GamePage.aspx", true);
    }

    protected void ButtonTicTacToe_Click(object sender, EventArgs e)
    {
        Server.Transfer("TicTacToe.aspx", true);
    }

    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        Server.Transfer("LoginPage.aspx", true);
    }
}