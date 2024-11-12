<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maxNumPage.aspx.cs" Inherits="hlee8291_a4.NewFolder1.new_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="welcomeComment" runat="server"></h1>
            <label for="maxNum">Enter Max Number: </label>
            <asp:TextBox ID="maxNum" type="text" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="maxNumValidator" 
                runat="server" 
                ErrorMessage=""
                controltovalidate="maxNum"
                OnServerValidate="maxNumValidator_ServerValidate" ValidateEmptyText="True"
                ></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="maxNumSubmit" runat="server" Text="Submit" OnClick="maxNumSubmit_Click" />
            <p id="maxNumError" runat="server" style="color:red"></p>
        </div>
    </form>
</body>
</html>
