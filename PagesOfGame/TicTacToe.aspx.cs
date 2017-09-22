using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagesOfGame_TicTacToe : System.Web.UI.Page
{
    private List<Button[]> buttons;
    private int Turn;
    private List<Button[]> winningPossibilities;
    protected void Page_Load(object sender, EventArgs e)
    {
        buttons = new List<Button[]>() {
            new Button[] { Button00, Button01, Button02 },
            new Button[] { Button10, Button11, Button12 },
            new Button[] { Button20, Button21, Button22 } };

        winningPossibilities = new List<Button[]>() {
            new Button[] { Button00, Button01, Button02 },
            new Button[] { Button10, Button11, Button12 },
            new Button[] { Button20, Button21, Button22 },
            new Button[] { Button00, Button10, Button20 },
            new Button[] { Button01, Button11, Button21 },
            new Button[] { Button02, Button12, Button22 },
            new Button[] { Button00, Button11, Button22 },
            new Button[] { Button02, Button11, Button20 } };

        if (!IsPostBack)
        {
            Label2.Visible = true;
            ButtonReset.Visible = false;
            ButtonYes.Visible = false;
            ButtonNo.Visible = false;

            foreach (Button[] b in buttons)
                foreach (Button btn in b)
                {
                    btn.Visible = false;
                    btn.BackColor = System.Drawing.Color.White;
                }
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        Turn = (int)Session["turn"];
        Button b = (Button)sender;
        if (b.BackColor == System.Drawing.Color.White)
        {
            if (Turn % 2 == 1)
            {
                Label1.Text = "";
                b.BackColor = System.Drawing.Color.Red;
                if (gameWon() == 1)
                    RedWin();
                else if (gameWon() == 9)
                    Tie();
                Session["turn"] = ++Turn;
            }
            else
            {
                Label1.Text = "";
                b.BackColor = System.Drawing.Color.Blue;
                if (gameWon() == 2)
                    BlueWin();
                else if (gameWon() == 9)
                    Tie();
                Session["turn"] = ++Turn;
            }
        }
        else
        {
            Label1.Text = "This spot has already been chosen, please choose another spot";
            Turn--;
        }
        sender = b;
    }

    protected void ButtonRed_Click(object sender, EventArgs e)
    {
        Turn = 1;
        Setup();
    }

    protected void ButtonBlue_Click(object sender, EventArgs e)
    {
        Turn = 2;
        Setup();
    }

    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.RawUrl);
    }

    protected int gameWon()
    {
        int a = 0;
        int x = 0;
        foreach (Button[] b in winningPossibilities)
        {
            if (b[0].BackColor.Equals(System.Drawing.Color.Red) && b[1].BackColor.Equals(System.Drawing.Color.Red) && b[2].BackColor.Equals(System.Drawing.Color.Red))
            {
                a = 1;
                break;
            }
            else if (b[0].BackColor.Equals(System.Drawing.Color.Blue) && b[1].BackColor.Equals(System.Drawing.Color.Blue) && b[2].BackColor.Equals(System.Drawing.Color.Blue))
            {
                a = 2;
                break;
            }
            else
            {
                foreach (Button[] btns in buttons)
                    foreach (Button btn in btns)
                        if (btn.BackColor.Equals(System.Drawing.Color.Red) || btn.BackColor.Equals(System.Drawing.Color.Blue))
                            x++;
                if (x == 9)
                    a = x;
                else x = 0;
            }
        }
        return a;
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        Label1.Text = "Okay, Thanks for playing!";
        ButtonReset.Visible = false;
        ButtonYes.Visible = false;
        ButtonNo.Visible = false;
        foreach (Button[] b in buttons)
            foreach (Button btn in b)
                btn.Visible = false;
    }

    protected void RedWin()
    {
        Label1.Text = "Congratulations Red Won! Would you like to play again? (Yes or No)";
        ButtonYes.Visible = true;
        ButtonNo.Visible = true;
    }

    protected void BlueWin()
    {
        Label1.Text = "Congratulations Blue Won! Would you like to play again? (Yes or No)";
        ButtonYes.Visible = true;
        ButtonNo.Visible = true;
    }

    protected void Tie()
    {
        Label1.Text = "Nobody wins! It was a tie. Would you like to play again? (Yes or No)";
        ButtonYes.Visible = true;
        ButtonNo.Visible = true;
    }

    protected void Setup()
    {
        Session["turn"] = Turn;
        Label2.Visible = false;
        ButtonRed.Visible = false;
        ButtonBlue.Visible = false;
        ButtonReset.Visible = true;

        foreach (Button[] b in buttons)
            foreach (Button btn in b)
                btn.Visible = true;
    }

    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        Server.Transfer("LoginPage.aspx", true);
    }

    protected void ButtonGameDirectory_Click(object sender, EventArgs e)
    {
        Server.Transfer("GameChoicePage.aspx", true);
    }
}