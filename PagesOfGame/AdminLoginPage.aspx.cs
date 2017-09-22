using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLoginPage : System.Web.UI.Page
{
    ///private static Dictionary<string, string> admins = new Dictionary<string, string>() { { "mgilbert@pmgnet.dev", "Maxwell$" }, { "maxwellgilbert99@gmail.com", "200409271Max*" } };
    ///This was what I used befoere I made a second database to hold the admin login information

    private static SqlConnection con = new SqlConnection(@"Data Source = PMGLAPC811\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Close();
            con.Open();
        }
    }

    protected void AdminLoginButton_Click(object sender, EventArgs e)
    {

        var adm_user = AdminUsernameTextBox.Text;
        var adm_pass = AdminPasswordTextBox.Text;

        List<AdminUser> listid = new List<AdminUser>();
        string sql = "SELECT * FROM admin_;";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            AdminUser us = new AdminUser();
            us.Id = dr["id"].ToString();
            us.Password = dr["password"].ToString();
            listid.Add(us);
        }
        dr.Close();
        foreach (AdminUser u in listid)
        {
            if(!(u.Id.Equals(adm_user)) || !(u.Password.Equals(adm_pass)))
            {
                ErrorLabel.Text = "Sorry, that is an incorrect username/password combination";
            }
            else
            {
                Server.Transfer("AdminPage.aspx", true);
            }
        }
    }
}