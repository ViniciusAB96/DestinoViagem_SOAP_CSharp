<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IDUAcomodacao.aspx.cs" Inherits="DestinoViagem.IDUAcomodacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>IDU - Acomodacão</title>
    <style type="text/css">

        .newStyle2 {
            z-index: 0;
            top: 0px;
            text-align: left;
            font-size: xx-small;
        }
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            font-size: smaller;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
                <asp:Button ID="ButtonBack" runat="server" CssClass="newStyle2" HorizontalAlign="Center" Text="Back"  PostBackUrl="http://localhost:50096/Main.aspx" />
                </p>
        <div class="auto-style1">
            Codigo Acomodacao:
            <asp:TextBox ID="TextIdAcomodacao" runat="server" AutoPostBack="True" OnTextChanged="TextIdAcomodacao_TextChanged" Width="42px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButDelete" runat="server" CssClass="auto-style2" OnClick="ButDelete_Click" Text="Deletar" />
                <asp:GridView ID="GridAcomodacao" runat="server" CellPadding="4" HorizontalAlign="Center" Height="16px" Width="739px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Tipo Acomodacao:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextTipoAcomodacao" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Quantidade quartos:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextQuantidadeQuartos" runat="server" Width="48px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; CEP:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextCEP" runat="server" Width="71px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 
        </p>
        <p>
            Classificacao:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextClassificacao" runat="server" Width="35px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Descricao:&nbsp;
            <asp:TextBox ID="TextDescricao" runat="server" Width="243px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;Destino:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownDestinos" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButInsert" runat="server" CssClass="auto-style2" OnClick="ButInsert_Click" Text="Inserir" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButAtualizar" runat="server" CssClass="auto-style2" OnClick="ButAtualizar_Click" Text="Atualizar" />
        </p>
            <p>
                &nbsp;</p>
        <p>
            &nbsp;<asp:Label ID="LabelStatus" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
