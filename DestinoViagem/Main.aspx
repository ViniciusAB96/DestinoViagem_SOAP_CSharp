<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="DestinoViagem.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página Principal</title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="main" runat="server">
        <div class="auto-style1">
            SOAP Destino Viagem</div>
        <p class="auto-style2">
            <asp:Button ID="ButObterTodosDest" runat="server" PostBackUrl="http://localhost:50096/ListarDestinos.aspx" Text="Listar Destinos" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButDestAcomod" runat="server" Text="Destinos e Acomodacoes" PostBackUrl="http://localhost:50096/ListaDestinosViagem.aspx" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButAcomodacoes" runat="server" Text="Listar Acomodacoes" PostBackUrl="http://localhost:50096/ListarTodasAcomodacoes.aspx" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButDestFiltro" runat="server" Text="Listar Destino Filtro" PostBackUrl="http://localhost:50096/ListaDestinoPorFiltro.aspx" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButListAcomodFilt" runat="server" PostBackUrl="http://localhost:50096/ListaAcomodacoesFiltro.aspx" Text="Listar Acomodacoes Filtro" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButIDUDestino" runat="server" PostBackUrl="http://localhost:50096/IDUDestino.aspx" Text="Atuar sobre o destino" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButIDUAcomodacao" runat="server" PostBackUrl="http://localhost:50096/IDUAcomodacao.aspx" Text="Atuar Sobre Acomodacoes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="auto-style3">
            <asp:Button ID="Button1" runat="server" PostBackUrl="http://localhost:50096/About.aspx" Text="About" Align="right" />
        </p>
    </form>
</body>
</html>
