using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Qrerystringpage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uname = Request.QueryString["Username"];
            string pw = Request.QueryString["Password"];
            lblmsg.Text = "Welcome " + uname + " " + pw;
        }
    }
}