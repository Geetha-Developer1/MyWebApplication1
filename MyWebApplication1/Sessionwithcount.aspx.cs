using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Sessionwithcount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Clickscount"]==null)
            {
                Session["Clickscount"] = 0;
            }
            lblcount.Text="Clicks count" + Session["Clickscount"].ToString();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            int count = (int)Session["Clickscount"];
            count++;
            Session["Clickscount"] = count;
            lblcount.Text = "Clicks count" + Session["Clickscount"].ToString();
        }
    }
}