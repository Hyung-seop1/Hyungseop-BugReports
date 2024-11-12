using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hlee8291_a4.Pages
{
    public partial class makeGuess : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {
            string userMaxNum = Request.Cookies["userMaxNum"].Value;
            rangeHeader.InnerText = "Guessing Range: 1 to " + userMaxNum;

            if (!IsPostBack)
            {
                int getMaxNum;
                if (int.TryParse(userMaxNum, out getMaxNum))
                {
                    Random random = new Random();
                    int randomNumber = random.Next(1, getMaxNum + 1); // Include 1 to getMaxNum range

                    // Store random number in ViewState for access during postbacks
                    ViewState["RandomNumber"] = randomNumber;
                }
                else
                {
                    // Handle the case where the max number is not valid
                    rangeHeader.InnerText = "Invalid max number in cookie.";
                }
            }
        }

        protected void guessNumSubmit_Click (object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("winPage.aspx");
                //make sure empty the error message
                guessNumError.InnerText = string.Empty;
            }

        }
        protected void userGuessValidator_ServerValidate (object source, ServerValidateEventArgs args)
        {
            //check if name is empty or has white space
            if (args.Value == "" || args.Value.Trim() == "")
            {
                args.IsValid = false;
                guessNumError.InnerText = "Please type valid guess number !!";
                return;
            }

            string inputNum = (args.Value.ToString());
            int guessNum;
            int.TryParse(inputNum, out guessNum);

            int randomNumber = (int)ViewState["RandomNumber"];
            string userMaxNum = Request.Cookies["userMaxNum"].Value;
            int getMaxNum;
            int.TryParse (userMaxNum, out getMaxNum);

            if (guessNum == randomNumber)
            {
                args.IsValid = true;
            }
            else if (guessNum > 0 && guessNum <= getMaxNum)
            {
                if (guessNum < randomNumber)
                {
                    guessNumError.InnerText = "Your guess is too low. Guess between " + (guessNum + 1) + " and " + getMaxNum;
                }
                else if (guessNum > randomNumber)
                {
                    guessNumError.InnerText = "Your guess is too high. Guess between " + (randomNumber - 1) + " and " + getMaxNum;
                }
                args.IsValid = false;
            }
            else if (guessNum > getMaxNum)
            {
                args.IsValid = false;
                guessNumError.InnerText = "Number should be less than or equal to" + getMaxNum + ". Guess between 1 and " + getMaxNum;
            }
            else if (guessNum < 1)
            {
                args.IsValid = false;
                guessNumError.InnerText = "Guess number must be greater than 1. Guess between 1 and " + getMaxNum;
            }
            else
            {
                args.IsValid = false;
                guessNumError.InnerText = "Please type a valid guess number!";
            }

        }
    }
}