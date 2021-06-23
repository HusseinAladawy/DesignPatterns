using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Refresh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = ConfigurationManager.AppSettings["Interval"];
        this.Page.Controls.Add(meta);

        // ConfigurationManager.AppSettings.GetValues(0);
       // TextBox1.Text = DateTime.Now.Millisecond.ToString();
     //   TextBox1.Text = ConfigurationManager.AppSettings["Station"];//
    }
    
}