<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="makeGuess.aspx.cs" Inherits="hlee8291_a4.Pages.makeGuess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="rangeHeader" runat="server"></h1>
            <label for="userGuessNum">Enter Guess Number: </label>
            <asp:TextBox ID="userGuessNum" type="text" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="userGuessValidator" 
                runat="server" 
                ErrorMessage=""
                ControlToValidate="userGuessNum"
                ValidateEmptyText="True" 
                OnServerValidate="userGuessValidator_ServerValidate"
                ></asp:CustomValidator>
            <asp:TextBox ID="randomNum" type="text" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="guessNumSubmit" runat="server" Text="Submit" OnClick="guessNumSubmit_Click" />
            <p id="guessNumError" runat="server" style="color:red"></p>
        </div>
    </form>
</body>
</html>
