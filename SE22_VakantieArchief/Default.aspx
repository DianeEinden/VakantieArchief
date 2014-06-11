<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SE22_VakantieArchief.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vakantie Archief</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TbNaam" runat="server"></asp:TextBox>
        <asp:TextBox ID="TbWachtwoord" runat="server"></asp:TextBox>
        <asp:Button ID="BtInloggen" runat="server" OnClick="BtInloggen_Click" Text="Inloggen" />
        <asp:Button ID="BtAanmelden" runat="server" OnClick="BtAanmelden_Click" Text="Aanmelden" />
    </form>
</body>
</html>
