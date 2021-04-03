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
            <asp:Label ID="label_idinscprof" runat="server" Text="ID Inscription Professeur"></asp:Label>
            <br />
            <asp:TextBox ID="id_inscprof" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
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
