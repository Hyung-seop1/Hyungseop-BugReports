using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hlee8291_a4.NewFolder1
{
    public partial class new_page : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {
            string userName   = Request.Cookies["userName"].Value;
            welcomeComment.InnerText = "Welcome " + userName + ", Let's Play Hi-Lo Game !!";
        }

        protected void maxNumSubmit_Click (object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                HttpCookie containMaxNum = new HttpCookie("userMaxNum");
                containMaxNum.Value = maxNum.Text;
                Response.Cookies.Add(containMaxNum);

                Response.Redirect("makeGuess.aspx");

                //make sure empty the error message
                maxNumError.InnerText = string.Empty;
            }
            else 
            {
                maxNumError.InnerText = "Please type valid max number !!";
            }
        }

        protected void maxNumValidator_ServerValidate (object source, ServerValidateEventArgs args)
        {
            
            //check if name is empty or has white space
            if (args.Value == "" || args.Value.Trim() == "")
            {
                args.IsValid = false;
                return;
            }
           
            //convert string to integer
            string inputNum = (args.Value.ToString());
            int maxNum;
            int.TryParse(inputNum, out maxNum);

            if (maxNum > 0)
            {
                args.IsValid = true;
            }
            //check if value is dobule like 0.2
            else if (double.IsNaN(maxNum))
            {
                args.IsValid = false;
                return;
            }
            else
            {
                args.IsValid = false;
                return;
            }
           
        }
    }
}