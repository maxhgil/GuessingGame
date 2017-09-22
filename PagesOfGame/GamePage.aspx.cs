using System;
using System.Data.SqlClient;

public partial class WebPageSeparated : System.Web.UI.Page
{
    private int randNum;
    private int theirGuess;
    private int numberOfGuesses;
    private static SqlConnection con = new SqlConnection(@"Data Source = PMGLAPC811\SQLEXPRESS; Initial Catalog = master; Integrated Security = True");


    protected void Page_Load(object sender, EventArgs e)
    {
        theirGuess = 0;
        numberOfGuesses = 1;
        Label2.Text = "Guessing game! Guess a number between [1,10) to see if you can get it right!";
        Label1.Text = "";

        if (!IsPostBack)
        {
            con.Close();
            con.Open();
        }

        string CurrentUser = (string)Session["id"];
        Label7.Text = CurrentUser;
        int CurrentBS = (int)Session["best_score"];

        if (CurrentBS > 10)
            Label8.Text = "n/a";
        else Label8.Text = CurrentBS.ToString();
        
    }

    protected void SubmitGuess_Click(object sender, EventArgs e)
    {
        randNum = (int)Session["random"];
        numberOfGuesses = (int)Session["guess"];

        try
        {
            theirGuess = Convert.ToInt32(TextBox1.Text);
            if (theirGuess != randNum)
            {
                Label1.Text = "Sorry, wrong number.  Please try again!";
                //numberOfGuesses++;
                Session["guess"] = ++numberOfGuesses;
            }

            if (theirGuess == randNum)
            {
                Label1.Text = "Correct! It took you " + numberOfGuesses + " guesses to get the correct answer.\nPress the button above to play again!";
                
                int prevBest = (int)Session["best_score"];           
                string id = (string)Session["id"];

                if(numberOfGuesses < prevBest)
                {
                    string sql = "UPDATE login SET best_score =" + numberOfGuesses + " WHERE CONVERT(varchar, id) = '" + id + "';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();

                    Session["best_score"] = numberOfGuesses;
                    string a = "SELECT * FROM login WHERE CONVERT(varchar, id) = '" + id + "';";
                    SqlCommand cmmd = new SqlCommand(a, con);
                    SqlDataReader dir = cmmd.ExecuteReader();
                    int b = 0;

                    while (dir.Read())
                    {
                        b = Convert.ToInt32(dir["best_score"]);
                    }
                    Label8.Text = b.ToString(); 
                }
                numberOfGuesses = 0;
            }
        }
        catch (FormatException)
        {
            Label1.Text = "Enter a number [1,10)";
        }
    }

    protected void GenNum_Click(object sender, EventArgs e)
    {
        randNum = new Random().Next(1, 10);
        Label1.Text = "Great, now you generated the random number, it is time to guess!";
        Session["random"] = randNum;
        Session["guess"] = numberOfGuesses;
    }

    protected void Leaderboard_Click(object sender, EventArgs e)
    {
        Server.Transfer("Leaderboard.aspx", true);
    }

    protected void LoginPage_Click(object sender, EventArgs e)
    {
        Server.Transfer("LoginPage.aspx", false);
    }

    protected void AdminLoginPageButton_Click(object sender, EventArgs e)
    {
        Server.Transfer("AdminLoginPage.aspx", true);
    }

    protected void ButtonGameChoicePage_Click(object sender, EventArgs e)
    {
        Server.Transfer("GameChoicePage.aspx", true);
    }
}
    