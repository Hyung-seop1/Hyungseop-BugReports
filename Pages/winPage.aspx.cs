using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hlee8291_a4.Pages
{
    public partial class winPage : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {

        }

        protected void playAgain_Click (object sender, EventArgs e)
        {
            // delete the "userMaxNum" cookie
            HttpCookie deleteCookie = new HttpCookie("userMaxNum");
            deleteCookie.Expires = DateTime.Now.AddDays(-1);
            // Add the expired cookie to the response to remove it from the browser
            Response.Cookies.Add(deleteCookie);

            Response.Redirect("maxNumPage.aspx");
        }
    }
}