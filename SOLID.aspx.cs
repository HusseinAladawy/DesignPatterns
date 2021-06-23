using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SOLID : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Converter c = new BinaryConverter(20);
        Response.Write(c.Convert());
    }
}