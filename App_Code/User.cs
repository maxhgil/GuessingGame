using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Creates a 'User' class
/// </summary>
public class User
{
    private string id;
    private string password;
    private int best_score;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public int Best_score
    {
        get { return best_score; }
        set { best_score = value; }
    }
}