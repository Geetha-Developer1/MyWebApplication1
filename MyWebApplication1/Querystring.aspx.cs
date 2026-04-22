using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Querystring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Qrerystringpage2.aspx?Username=" + txtuname.Text + "&Password=" + txtpw.Text);
        }
    }
}