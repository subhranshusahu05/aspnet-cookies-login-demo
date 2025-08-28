using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FailureWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] == null || Request.Cookies["Count"] == null)
            {
                Response.Redirect("LoginWithStaySignedIn.aspx");
            }
            string Name = Request.Cookies["User"].Value;
            string Count = Request.Cookies["Count"].Value;
            Response.Write("<h3>Hello " + Name + ", you have failed all the " + Count + " attempts to login.</h3>");
        }
    }
}