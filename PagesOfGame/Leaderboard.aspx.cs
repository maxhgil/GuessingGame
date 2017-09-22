using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagesOfGame_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }

    protected void LoginPage_Click(object sender, EventArgs e)
    {
        Server.Transfer("LoginPage.aspx", true);
    }

    protected void GamePage_Click(object sender, EventArgs e)
    {
        Server.Transfer("GamePage.aspx", true);
    }
}