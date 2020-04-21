<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_83504_opdracht1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Wat is je voornaam? <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            Wat is je achternaam? <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Waar woon je? <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Welke klas zit je? <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
