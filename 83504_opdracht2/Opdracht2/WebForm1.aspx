<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Opdracht2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:TextBox ID="Getal1" runat="server"></asp:TextBox>
        <asp:TextBox ID="Getal2" runat="server"></asp:TextBox><br />

        <asp:Button ID="plus" runat="server" Text="+plus" OnClick="plus_Click" />
        <asp:Button ID="min" runat="server" Text="-min" OnClick="min_Click" />
        <asp:Button ID="keer" runat="server" Text="*keer" OnClick="keer_Click" />
        <asp:Button ID="deel" runat="server" Text="/gedeeld" OnClick="deel_Click" /><br />

        <asp:TextBox ID="Antwoordbox" runat="server"></asp:TextBox>
        <div>

        </div>
    </form>
</body>
</html>
