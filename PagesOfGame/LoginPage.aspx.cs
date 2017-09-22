using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel;

public partial class _Default : Page {

    private string user;
    private string pass;
    private static SqlConnection con = new SqlConnection(@"Data Source = PMGLAPC811\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Close();
            con.Open();
        }
    }
    protected void CreateAccountButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("NewUserCreationPage.aspx", true);
    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        user = TextBox3.Text;
        pass = TextBox4.Text;

        List<User> listid = new List<User>();
        string sql = "SELECT * FROM login;";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            User us = new User();
            us.Id = dr["id"].ToString();
            us.Password = dr["password"].ToString();
            us.Best_score = Convert.ToInt32(dr["best_score"]);
            listid.Add(us);
        }
        dr.Close();

        foreach (User u in listid)
        {
            if (!(u.Id.Equals(user)) || !(u.Password.Equals(pass)))
            {
                Label3.Text = "You have either entered an incorrect username or password";
            }
            else {
                Session["id"] = u.Id;
                Session["password"] = u.Password;
                Session["best_score"] = u.Best_score;
                Server.Transfer("GameChoicePage.aspx", true);
            }
        }
    }
}