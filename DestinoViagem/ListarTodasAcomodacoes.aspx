<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarTodasAcomodacoes.aspx.cs" Inherits="DestinoViagem.ListarTodasAcomodacoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listar todas acomodacoes</title>
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
        <div class="auto-style1">Acomodações.</div>
        <div class="auto-style1">
            <asp:GridView ID="GridAcomodacoes" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
