<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="trombinoscope1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Accueil</h1>
        <p class="lead">Bienvenue sur cette plateforme pédagogique Veuillez sélectionner quel type d&#39;utilisateur vous êtes</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Professeur</h2>
            <p>
                Cliquez ci desous pour accéder à votre espace :&nbsp;
            </p>
            <p>
                &nbsp;<asp:Button ID="btnprof" runat="server" OnClick="btnprof_Click" Text="Professeur" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Etudiant</h2>
            <p>
                Cliquez ci desous pour accéder à votre espace :&nbsp;&nbsp;
            </p>
            <p>
                &nbsp;<asp:Button ID="btnetu" runat="server" OnClick="btnetu_Click" Text="Etudiant" />
            </p>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
