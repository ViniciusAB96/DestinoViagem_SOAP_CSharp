<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IDUDestino.aspx.cs" Inherits="DestinoViagem.IDUDestinos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>IDU - Destinos</title>
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
        .auto-style3 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
                <asp:Button ID="ButtonBack" runat="server" CssClass="newStyle2" HorizontalAlign="Center" Text="Back"  PostBackUrl="http://localhost:50096/Main.aspx" />
                </p>
        <div class="auto-style1">
            ID:
            <asp:TextBox ID="TextIdDestino" runat="server" AutoPostBack="True" OnTextChanged="TextIdDestino_TextChanged" Width="42px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButDelete" runat="server" CssClass="auto-style2" OnClick="ButDelete_Click" Text="Deletar" />
            <br />
            <div class="auto-style3">
                <asp:GridView ID="GridDestinos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Height="16px" Width="380px">
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
            </div>
        </div>
        <p>
            Nome Destino:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextNomeDestino" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Classificacao Destino:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextClassifica" runat="server" Width="48px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Taxa:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextTaxa" runat="server" Width="71px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Estado:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextEstado" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Cidade:&nbsp;
            <asp:TextBox ID="TextCidade" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButInsert" runat="server" CssClass="auto-style2" OnClick="ButInsert_Click" Text="Inserir" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButAtualizar" runat="server" CssClass="auto-style2" OnClick="ButAtualizar_Click" Text="Atualizar" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LabelStatus" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
