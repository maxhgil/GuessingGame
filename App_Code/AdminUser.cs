using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Creates an 'AdminUser' class
/// </summary>
public class AdminUser
{
    private string id;
    private string password;

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
}