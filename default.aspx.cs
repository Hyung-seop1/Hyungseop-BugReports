using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hlee8291_a4
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {

        }

        protected void nameSubmit_Click (object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                HttpCookie conatinName = new HttpCookie("userName");
                conatinName.Value = name.Text;
                //adding cookie in response
                Response.Cookies.Add(conatinName);

                //move to next page
                Response.Redirect("Pages/maxNumPage.aspx");
            }
            else
            {
                //if name is invlaid return error message
                nameError.InnerText = "Please put valid name !!";
            }
        }

        protected void nameValidator_ServerValidate (object source, ServerValidateEventArgs args)
        {
            //check if name is empty or has white space
            if (args.Value == "" || args.Value.Trim() == "")
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}