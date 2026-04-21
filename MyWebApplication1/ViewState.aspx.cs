using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["Clickscount"] = 0;
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //count++;
            //lblmsg.Text= "Clicks count: " + count;
            int count = (int)ViewState["Clickscount"];
            count++;
            ViewState["Clickscount"] = count;
            lblmsg.Text = "Clicks count: " + count;
        }
    }
}