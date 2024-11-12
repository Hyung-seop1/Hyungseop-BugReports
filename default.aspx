<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="hlee8291_a4._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to the Hi-Lo game !!</h1>
            <label for="name">Enter your name: </label>
            <asp:TextBox ID="name" type="text" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="nameValidator" 
                runat="server" 
                ErrorMessage="" 
                ControlToValidate="name" 
                OnServerValidate="nameValidator_ServerValidate" ValidateEmptyText="True" 
                ></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="nameSubmit" runat="server" Text="Submit" OnClick="nameSubmit_Click"/>
            <p id="nameError" runat="server" style="color:red"></p>
        </div>
    </form>
</body>
</html>
