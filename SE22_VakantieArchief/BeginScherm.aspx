<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeginScherm.aspx.cs" Inherits="SE22_VakantieArchief.BeginScherm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="BtEuropa" runat="server" OnClick="BtEuropa_Click" Text="Europa" Width="110px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtAzie" runat="server" Text="Azië" Width="110px" OnClick="BtAzie_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtAfrika" runat="server" Text="Afrika" Width="110px" OnClick="BtAfrika_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtZAmerika" runat="server" Text="Zuid Amerika" Width="110px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtNAmerika" runat="server" Text="Noord Amerika" Width="111px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtOceanie" runat="server" Text="Oceanië" Width="110px" />
        <br />
        <br />
        <asp:ListBox ID="LbReizen" runat="server" Width="1463px"></asp:ListBox>
        <br />
    
    </div>
        <p>
            <asp:Button ID="BtBoekingOpvragen" runat="server" OnClick="BtBoekingOpvragen_Click" Text="Boeking opvragen" />
            <asp:ListBox ID="LbBoeking" runat="server" Width="1160px"></asp:ListBox>
        </p>
        <asp:Button ID="BtReisInzien" runat="server" Text="Reis inzien" Width="209px" OnClick="BtReisInzien_Click" />
        <br />
        <asp:ListBox ID="LbReis" runat="server" Width="1457px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtAccomodatieBekijken" runat="server" OnClick="BtAccomodatieBekijken_Click" Text="Accomodatie bekijken" />
        <br />
        <asp:ListBox ID="LbAccomodatie" runat="server" Width="1020px"></asp:ListBox>
    </form>
</body>
</html>
