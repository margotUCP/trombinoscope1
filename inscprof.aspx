<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscprof.aspx.cs" Inherits="trombinoscope1.inscprof" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Incription Professeurs</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label_idinscprof" runat="server" Text="Nom du professeur"></asp:Label>
            <br />
            <asp:TextBox ID="nom_inscprof" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Prénom "></asp:Label>
            <br />
            <asp:TextBox ID="prenom_inscprof" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="mail_inscprof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Numéro de téléphone"></asp:Label>
            <br />
            <asp:TextBox ID="phone_inscprof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nom d'utilisateur"></asp:Label>
            <br />
            <asp:TextBox ID="username_inscprof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Bureau"></asp:Label>
            <br />
            <asp:TextBox ID="bureau_inscprof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="label_passinscprof" runat="server" Text="Mot de Passe prof"></asp:Label>
            <br />
            <asp:TextBox ID="pass_inscprof" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="submit_inscprof" runat="server" OnClick="Button1_Click" Text="S'inscrire" />
        </div>
    </form>
</body>
</html>
