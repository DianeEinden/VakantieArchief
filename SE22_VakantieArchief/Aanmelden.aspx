<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aanmelden.aspx.cs" Inherits="SE22_VakantieArchief.Aanmelden" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TbGebruikersnaam" runat="server"></asp:TextBox>
        <asp:TextBox ID="TbWachtwoord" runat="server"></asp:TextBox>
        <asp:Button ID="BtAanmelden" runat="server" OnClick="BtAanmelden_Click" Text="Maak account aan" />
    
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="LbAanmelden" runat="server" Text="Gebruikersnaam is al bekend!" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
