using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SuccessWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCookie"];
            if (cookie == null)
            {
                Response.Redirect("LoginWithStaySignedIn.aspx");
            }
            string Name = cookie["User"];
            Response.Write("<h3>Hello " + Name + ", welcome to the site.</h3>");
        }
    }
}