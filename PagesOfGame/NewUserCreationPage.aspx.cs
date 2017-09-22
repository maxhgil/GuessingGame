using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class PagesOfGame_Default : Page
{
    static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
    public string HumanCheck, HumanCheckAnswer, username, password, retypedPassword;
    private static SqlConnection con = new SqlConnection(@"Data Source = PMGLAPC811\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");


    protected void Page_Load(object sender, EventArgs e)
    {
        HumanCheckAnswer = HumanCheckTextBox.Text;

        //Creates the random string for the first time the page is loaded
        if (!IsPostBack)
        {
            con.Close();
            con.Open();

            var StringChars = new char[8];
            Random Rand = new Random();
            for (int x = 0; x < StringChars.Length; x++)
            {
                StringChars[x] = chars[Rand.Next(chars.Length)];
            }
            HumanCheck = new string(StringChars);
            HumanCheckLabel.Text = HumanCheck;
            Session["HumanCheck"] = HumanCheck;
        }
    }

    protected void CreateNewUserButton_Click(object sender, EventArgs e)
    {
        username = UsernameTextBox.Text;
        password = PasswordTextBox.Text;
        retypedPassword = ReTypedPasswordTextBox.Text;
        HumanCheck = (string)Session["HumanCheck"];
        bool b = true;

        //Connects to database and retrieves the information and makes 'Users' into a List
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

        //Checks to see if there are any users that already have that Id
        foreach (User a in listid)
        {
            if (a.Id.Equals(username) || string.IsNullOrWhiteSpace(username))
            {
                b = false;
                PasswordTextBox.Text = "";
                ReTypedPasswordTextBox.Text = "";
                WrongHumanCheckLabel.Text = "That username is either already taken or not a valid username"; break;
            }
        }

        //Checks to make sure all parameters are valid for a new account
        if ( password.Length > 0 && !(string.IsNullOrWhiteSpace(password)) && password == retypedPassword && b == true && HumanCheckAnswer.Equals(HumanCheck))
        {
            //automatically sets the 'best_score' to 11 because there are only 10 numbers you can only get above 10 if you guess the same number twice
            string sqlcmmnd = "INSERT INTO login (id,password,best_score) VALUES('" + username + "','" + password + "',11);";
            SqlCommand cmmd = new SqlCommand(sqlcmmnd, con);
            SqlDataReader datr = cmmd.ExecuteReader();
            datr.Close();
            Response.Write("<script>alert('Congratulations for making an account! Enjoy Playing!');</script>");
            Server.Transfer("LoginPage.aspx", true);
            
        }

        else
        {
            //Checks to see if the 'Human Checker' is the problem
            if (!(HumanCheckAnswer.Equals(HumanCheck)) || string.IsNullOrWhiteSpace(HumanCheckTextBox.Text))
            {
                PasswordTextBox.Text = "";
                ReTypedPasswordTextBox.Text = "";
                WrongHumanCheckLabel.Text = "The characters you entered did not match the Human Check";
            }

            //If the 'Human Checker' is right, then the problem is your username/Id
            else
            {
                PasswordTextBox.Text = "";
                ReTypedPasswordTextBox.Text = "";
                WrongHumanCheckLabel.Text = "The password or username you chose is invalid";
            }
            
        }
        //Creates the random string again
        var StringChars = new char[8];
        Random Rand = new Random();
        for (int x = 0; x < StringChars.Length; x++)
        {
            StringChars[x] = chars[Rand.Next(chars.Length)];
        }
        HumanCheck = new string(StringChars);
        HumanCheckLabel.Text = HumanCheck;
        Session["HumanCheck"] = HumanCheck;
    }
}