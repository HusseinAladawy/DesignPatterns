using System;

public partial class CSharp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AbstratcionTest at = new AbstratcionTest();
        Response.Write(at.sum().ToString());

    }
}

