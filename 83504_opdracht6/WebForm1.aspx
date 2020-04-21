<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_83504_opdracht6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input id="Cijfer1" type="text" />
        <asp:Button ID="Submit" runat="server" Text="Toon Tafel" OnClick="Submit_Click" />
        <asp:Label ID="Antwoord" runat="server" Text="Hier komt uw antwoord."></asp:Label>
    </form>
</body>
</html>
