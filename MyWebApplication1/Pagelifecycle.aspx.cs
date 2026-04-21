using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Pagelifecycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblpageload.Text = "HI Gita, Page Load Event<br>";
            btnsubmit.Visible=false;
        }
        protected void Page_PreInIT(object sender, EventArgs e)
        {
            lblpreint.Text = "HI Gita, Page PreInit Event <br>";
        }
        protected void Page_InIT(object sender, EventArgs e)
        {
            lblinit.Text = "HI Gita, Page Init Event <br>";
        }
        protected void Page_InITComplete(object sender, EventArgs e)
        {
            lblinitcomplete.Text = "HI Gita, Page InitComplete Event <br>";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            lblpageloadcomplete.Text = "HI Gita, Page LoadComplete Event <br>";
        }

        protected void txtuname_TextChanged(object sender, EventArgs e)
        {
            if(txtuname.Text.Length>3)
                btnsubmit.Visible=true;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (rbtelugu.Checked)
                lbltelugu.Text = "Selectde Language is Telugu";
            else if (rbhindi.Checked)
                lblhindi.Text = "Selected Language is English";
            else if (rbenglish.Checked)
                lblenglish.Text = "Selected Language is English";
        }

        protected void chkchess_CheckedChanged(object sender, EventArgs e)
        {
            string check = "";
            if (chkchess.Checked)
                check += "Chess,";
             if (chktennis.Checked)
                check += "Tennis, ";
             if (chkcricket.Checked)
                check += "Cricket.";

            lblchkmsg.Text = "You are Selected : "+check;
        }

    }
}