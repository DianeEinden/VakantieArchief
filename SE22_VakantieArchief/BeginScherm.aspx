<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeginScherm.aspx.cs" Inherits="SE22_VakantieArchief.BeginScherm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="BtUitloggen" runat="server" OnClick="BtUitloggen_Click" Text="Uitloggen" Width="209px" />
        <br />
        <br />
        <br />
    
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

        <asp:GridView ID="GvLand" runat="server" AutoGenerateColumns="True" Height="58px" Width="832px">
            <Columns>

            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:ListBox ID="LbReizen" runat="server" Width="1463px"></asp:ListBox>
        <br />
        <br />
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
    
        <br />
        <br />
        <br />
    
    </div>
        <p>
            <asp:Button ID="BtBoekingOpvragen" runat="server" OnClick="BtBoekingOpvragen_Click" Text="Boeking opvragen" />
            <asp:ListBox ID="LbBoeking" runat="server" Width="1160px"></asp:ListBox>
        </p>
        <p>
            Boekingsnummer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbBoekingsnummer" runat="server"></asp:TextBox>
        <br />
            Datum retour:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbDatumRetour" runat="server"></asp:TextBox>
&nbsp;<br />
            Datum vertrek:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbDatumvertrek" runat="server"></asp:TextBox>
&nbsp;<br />
            Organisatie:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbOrganisatie" runat="server"></asp:TextBox>
        <br />
            Paspoort of ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RbPaspoort" runat="server" Text="Paspoort" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RbID" runat="server" Text="ID-Kaart" />
        <br />
            Soort vakantie:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DdlVaksoort" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            Totaalprijs:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbTotaal" runat="server"></asp:TextBox>
        <br />
            Visum:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RbVY" runat="server" Text="Ja" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RbVN" runat="server" Text="Nee" />
        <br />
            Voertuig:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbVoertuig" runat="server"></asp:TextBox>
        <br />
            Landcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbVoertuig0" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            &nbsp;<asp:Button ID="BtBoekingToevoegen" runat="server" OnClick="BtBoekingToevoegen_Click" Text="Voeg toe" Width="302px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtReisInzien" runat="server" Text="Reis inzien" Width="209px" OnClick="BtReisInzien_Click" />
        <br />
        <asp:ListBox ID="LbReis" runat="server" Width="1457px"></asp:ListBox>
        <p>
            Reistijd:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbReistijd" runat="server"></asp:TextBox>
        <br />
            Vertrekpunt:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbVertrekpunt" runat="server"></asp:TextBox>
&nbsp;<br />
            Aankomstpunt:&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbAankomstpunt" runat="server"></asp:TextBox>
&nbsp;<br />
            Vertrek:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbVertrek" runat="server"></asp:TextBox>
        <br />
            Reiscode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbReiscode" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtReisToevoegen" runat="server" Text="Voeg toe" Width="302px" OnClick="BtReisToevoegen_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtAccomodatieBekijken" runat="server" OnClick="BtAccomodatieBekijken_Click" Text="Accomodatie bekijken" />
        <br />
        <asp:ListBox ID="LbAccomodatie" runat="server" Width="1020px"></asp:ListBox>
        <br />
        <br />
        Adres:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbAdres" runat="server"></asp:TextBox>
        <br />
            Categorie:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TbCategorie" runat="server"></asp:TextBox>
&nbsp;<br />
            Naam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="TbDatumvertrek0" runat="server"></asp:TextBox>
&nbsp;<br />
            Postcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TbPostcode" runat="server"></asp:TextBox>
        <br />
            Plaats:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbPlaats" runat="server"></asp:TextBox>
        <br />
            Accomodatie soort:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="DdlAccomodatie" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            Telefoonnummer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TbTelefoonnummer" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            Verzorging:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DdlVerzorging" runat="server">
            </asp:DropDownList>
        <br />
            Website:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TbWebsite" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="BtVoegToeAcco" runat="server" OnClick="BtVoegToeAcco_Click" Text="Voeg toe" Width="279px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtPlaatsen" runat="server" OnClick="BtPlaatsen_Click" Text="Plaatsen bekijken" />
        <br />
        <asp:ListBox ID="LbPlaatsen" runat="server" Width="1018px"></asp:ListBox>
        <br />
        <br />
        Aantal inwoners:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TbAantalInwonersPl" runat="server"></asp:TextBox>
        <br />
        Areacode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbAreacode" runat="server"></asp:TextBox>
        <br />
        Plaatsnaam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbPlaatsnaam" runat="server"></asp:TextBox>
        <br />
        Stad of dorp:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RbStad" runat="server" Text="Stad" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RbPlaats" runat="server" Text="Plaats" />
        <br />
        Landcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbLandcodePl" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtVoegToePlaats" runat="server" OnClick="BtVoegToePlaats_Click" Text="Voeg toe" Width="313px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtActiviteit" runat="server" OnClick="BtActiviteit_Click" Text="Activiteiten overzicht" />
        <br />
        <asp:ListBox ID="LbActiviteit" runat="server" Width="993px"></asp:ListBox>
        <br />
        <br />
        Adres:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TbAdresActi" runat="server"></asp:TextBox>
        <br />
        Arragement mogelijk:&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RbJa" runat="server" Text="Ja" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RbNee" runat="server" Text="Nee" />
        <br />
        Naam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbNaamActie" runat="server"></asp:TextBox>
        <br />
        Omschrijving:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbOmschrijvingActi" runat="server"></asp:TextBox>
        <br />
        Organisatie:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbOrganisatieActie" runat="server"></asp:TextBox>
        <br />
        Plaats:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbPlaatsActie" runat="server"></asp:TextBox>
        <br />
        Postcode:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbPostcodeActie" runat="server"></asp:TextBox>
        <br />
        Prijs:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbPrijsActie" runat="server"></asp:TextBox>
        <br />
        Telefoonnummer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbTelActie" runat="server"></asp:TextBox>
        <br />
        Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TbTypeActie" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtVoegToeActie" runat="server" OnClick="BtVoegToeActie_Click" Text="Voeg toe" Width="355px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="BtBezienswaardigheid" runat="server" Text="Bezienswaardigheden" />
        </p>
        <p>
            <asp:ListBox ID="LbKbzw" runat="server" Width="1003px"></asp:ListBox>
        </p>
        <p>
            <asp:ListBox ID="LbNbzw" runat="server" Width="1004px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
