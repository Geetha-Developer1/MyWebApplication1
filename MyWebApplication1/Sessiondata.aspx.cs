using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebApplication1
{
    public partial class Sessiondata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                if(Session["Firstname"] == null && Session["Lastname"]==null)
                {
                    Session["Firstname"] = "ABC";
                    Session["Lastname"] = "XYZ";
                    lblstring.Text = Session["Firstname"] + " " + Session["Lastname"];
                }
                else
                {
                    lblstring.Text =  Session["Firstname"] + " " + Session["Lastname"];
                    lblfname.Text = Session["Firstname"].ToString();
                    lbllname.Text = Session["Lastname"].ToString();
                }
            }
        }
    }
}