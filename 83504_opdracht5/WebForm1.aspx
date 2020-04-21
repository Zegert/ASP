<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_83504_opdracht5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Stel je eigen pizza samen:<br />
            Bodem 3 euro<br />
            <asp:CheckBox ID="CheckBox1" runat="server" />Tomatensaus   1 euro<br />
            <asp:CheckBox ID="CheckBox2" runat="server" />Salami        2 euro<br />
            <asp:CheckBox ID="CheckBox3" runat="server" />Pepperoni     2 euro<br />
            <asp:CheckBox ID="CheckBox4" runat="server" />Ham           2 euro<br />
            <asp:CheckBox ID="CheckBox5" runat="server" />Carpaccio     2.5 euro<br />
            <asp:CheckBox ID="CheckBox6" runat="server" />Paprika       2 euro<br />
            <asp:CheckBox ID="CheckBox7" runat="server" />Knoflook      1 euro<br />
            <asp:CheckBox ID="CheckBox8" runat="server" />Champignons   2 euro<br />

            <asp:Button ID="Button1" runat="server" Text="Bestel!" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="Totale prijs..."></asp:Label><br />
        </div>
    </form>
</body>
</html>
