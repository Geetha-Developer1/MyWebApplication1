using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Session["Firstname"] = txtfname.Text;
            Session["Lastname"] = txtlname.Text;
            Response.Redirect("~/Sessiondata.aspx");
        }
    }
}