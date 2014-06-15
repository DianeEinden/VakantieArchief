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
        <br />
        LAND TOEVOEGEN<br />
        Aantal inwoners:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbAantalInwoners" runat="server"></asp:TextBox>
        <br />
        Cultuur:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbCultuur" runat="server"></asp:TextBox>
        <br />
        Hoofdstad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbHoofdsdtad" runat="server"></asp:TextBox>
        <br />
        Landcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbLandcode" runat="server"></asp:TextBox>
        <br />
        Landnummer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbLandnummer" runat="server"></asp:TextBox>
        <br />
        Ligging:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DdlLigging" runat="server">
            <asp:ListItem>Europa</asp:ListItem>
            <asp:ListItem>Afrika</asp:ListItem>
            <asp:ListItem>Azie</asp:ListItem>
            <asp:ListItem>Oceanie</asp:ListItem>
            <asp:ListItem>Zuid-Amerika</asp:ListItem>
            <asp:ListItem>Noord-Amerika</asp:ListItem>
        </asp:DropDownList>
        <br />
        Naam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbNaam" runat="server"></asp:TextBox>
        <br />
        Oppervlakte:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbOppervlakte" runat="server"></asp:TextBox>
        <br />
        Staatsvorm:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DdlStaatsvorm" runat="server">
            <asp:ListItem>Democratie</asp:ListItem>
            <asp:ListItem>Dictatuur</asp:ListItem>
            <asp:ListItem>Koningkrijk</asp:ListItem>
            <asp:ListItem>Republiek</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        Tijdsverschil:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="RbY" runat="server" Text="Ja" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RbN" runat="server" Text="Nee" />
        <br />
        Valuta:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbValuta" runat="server"></asp:TextBox>
        <br />
        Voertaal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbVoertaal" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtVoegToe" runat="server" OnClick="BtVoegToe_Click" Text="Voeg toe" Width="357px" />
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
        <br />
        <br />
        <asp:Button ID="BtPlaatsen" runat="server" OnClick="BtPlaatsen_Click" Text="Plaatsen bekijken" />
        <br />
        <asp:ListBox ID="LbPlaatsen" runat="server" Width="1018px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="BtActiviteit" runat="server" OnClick="BtActiviteit_Click" Text="Activiteiten overzicht" />
        <br />
        <asp:ListBox ID="LbActiviteit" runat="server" Width="993px"></asp:ListBox>
        <p>
            <asp:Button ID="BtBezienswaardigheid" runat="server" OnClick="BtBezienswaardigheid_Click" Text="Bezienswaardigheden" />
        </p>
        <p>
            <asp:ListBox ID="LbKbzw" runat="server" Width="1003px"></asp:ListBox>
        </p>
        <p>
            <asp:ListBox ID="LbNbzw" runat="server" Width="1004px"></asp:ListBox>
        </p>
    </form>
</body>
</html>
