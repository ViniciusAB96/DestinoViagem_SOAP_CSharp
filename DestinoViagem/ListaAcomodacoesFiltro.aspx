<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaAcomodacoesFiltro.aspx.cs" Inherits="DestinoViagem.ListaAcomodacoesFiltros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Acomodacões com Filtros</title>
    <style type="text/css">

        .newStyle2 {
            z-index: 0;
            top: 0px;
            text-align: left;
            font-size: xx-small;
        }
        .auto-style1 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
                <asp:Button ID="ButtonBack" runat="server" CssClass="newStyle2" HorizontalAlign="Center" Text="Back"  PostBackUrl="http://localhost:50096/Main.aspx" />
                </p>
        <div class="auto-style1">Lista acomodacões com filtros
        </div>
        <div class="auto-style1">
            ID:
            <asp:TextBox ID="TextIDAcomod" runat="server" Width="36px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Nome:
            <asp:TextBox ID="TextNomeAcomodacao" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButPesq" runat="server" OnClick="ButPesq_Click" Text="Pesquisar" />
        </div>
        <br />
        <asp:GridView ID="GridAcomodacao" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
</body>
</html>
