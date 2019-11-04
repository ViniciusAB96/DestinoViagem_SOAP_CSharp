<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaDestinosViagem.aspx.cs" Inherits="DestinoViagem.ListaDestinosViagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista Destinos Viagem</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Listagem de Destinos Viagem.
            <br />
            <br />
            Clique no botão a seguir para listar os destinos:&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButListar" runat="server" OnClick="ButListar_Click" Text="Listar Destinos." />
        </div>
        <asp:Table ID="TableDestinos" runat="server" Height="609px" Width="1391px">
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
            <asp:TableRow runat="server">
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
