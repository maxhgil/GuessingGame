using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public List<User> listid;
    public bool OkayToResetScore = true;
    public bool OkayToResetPassword = true;
    private static SqlConnection con = new SqlConnection(@"Data Source = PMGLAPC811\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Close();
            con.Open();
            string sql = "SELECT * FROM login;";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listid = new List<User>();
                User us = new User();
                us.Id = dr["id"].ToString();
                us.Password = dr["password"].ToString();
                us.Best_score = Convert.ToInt32(dr["best_score"]);
                listid.Add(us);
            }
            dr.Close();
        }
    }

    protected void ResetPasswordButton_Click(object sender, EventArgs e)
    {
        var NewPass = NewPasswordTextBox.Text;
        var Username = UsernameTextBox.Text;

        string sql = "UPDATE login SET password = '" + NewPass + "' WHERE CONVERT(varchar, id) = '" + Username + "';";

        if (OkayToResetPassword)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();

            Response.Write("<script>alert('" + UsernameTextBox.Text + " password has been reset');</script>");

            UsernameTextBox.Text = "";
            NewPasswordTextBox.Text = "";
            ReenteredNewPasswordTextBox.Text = "";
        }
    }

    protected void ResetScore_1PersonButton_Click(object sender, EventArgs e)
    {
        var Username = Reset_1PersonScoreTextBox.Text;
        string sql = "UPDATE login SET best_score = 11 WHERE CONVERT(varchar, id) = '" + Username + "';";
        
        if (OkayToResetScore)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();

            Response.Write("<script>alert('" + Username + " score has been reset');</script>");

            Reset_1PersonScoreTextBox.Text = "";
        }

        else { Response.Write("<script>alert('Invalid Username');</script>"); }

    }

    protected void ResetAllScoresButton_Click(object sender, EventArgs e)
    {
        string sql = "UPDATE login SET best_score = 11;";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Close();
        Session["best_score"] = 11;

        Response.Write("<script>alert('All scores have been reset');</script>");
    }

    protected void ReturnToLoginButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("LoginPage.aspx", true);
    }

    protected void ReturnToGamePageButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("GamePage.aspx", true);
        
    }    
}