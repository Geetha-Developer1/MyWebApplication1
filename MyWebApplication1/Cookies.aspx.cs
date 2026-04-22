using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie usercookie = new HttpCookie("UserId");
            usercookie["Username"]=txtuname.Text;
            usercookie["Password"]=txtpw.Text;
            usercookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(usercookie);
            Response.Redirect("~/CookieData.aspx");
        }
    }
}