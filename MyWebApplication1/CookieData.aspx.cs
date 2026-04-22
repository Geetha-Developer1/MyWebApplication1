using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class CookieData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie ucookie = Request.Cookies["UserId"];
            if(ucookie!=null)
            {
                lbluname.Text = ucookie["Username"];
                lblpw.Text=ucookie["Password"];
            }

        }
    }
}