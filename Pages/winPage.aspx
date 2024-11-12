<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winPage.aspx.cs" Inherits="hlee8291_a4.Pages.winPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="winComment">You Win!!</h1>
            <p id="comment">If you want to play again press below button</p>
            <asp:Button ID="playAgain" runat="server" Text="Play Again" OnClick="playAgain_Click" />
        </div>
    </form>
</body>
</html>
