<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="trombinoscope1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Accueil Professeurs </h1>
        <p class="lead">Bienvenue sur cette page pour les professeurs</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Connexion</h2>
            <p>
                Veuillez vous connecter à votre espace personnel
            </p>
        </div>
        <div class="col-md-4">
            <p>
                <asp:Label ID="lblidprof" runat="server" Text="Identifiant (e-mail) "></asp:Label>
&nbsp;</p>
            <p>
                <input id="idprof" type="text" /></p>
            <p>
                <asp:Label ID="lblpassprof" runat="server" Text="Mot de Passe"></asp:Label>
            </p>
            <p>
                <input id="passprof" type="password" /></p>
            <p>
                <asp:Button ID="submitcoprof" runat="server" OnClick="submitcoprof_Click" Text="Connexion" />
            </p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <br />
        </div>
    </div>

</asp:Content>
