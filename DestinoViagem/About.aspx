<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DestinoViagem.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .newStyle2 {
            z-index: 0;
            top: 0px;
            text-align: left;
            font-size: xx-small;
        }
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            text-align: center;
            width: 1377px;
        }
        .auto-style3 {
            font-size: large;
            text-align: center;
            width: 1376px;
        }
        .auto-style4 {
            text-align: right;
            width: 1378px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p>
                <asp:Button ID="ButtonBack" runat="server" CssClass="newStyle2" HorizontalAlign="Center" Text="Back"  PostBackUrl="http://localhost:50096/Main.aspx" />
                </p>
        </div>
        <p class="auto-style2">
            <span class="auto-style1"><strong>Autor:</strong></span> <em><span class="auto-style1">Vinícius de Andrade Barros</span></em>&nbsp;&nbsp;&nbsp; <strong><span class="auto-style1">RA: </span></strong><span class="auto-style1"><em>082150366</em></span>&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style1">Turma:</span></strong> <em><span class="auto-style1">EC9</span></em></p>
        <p class="auto-style2">
            <em><strong><span class="auto-style1">Projeto:</span></strong><span class="auto-style1"> Destino de Viagem</span></em></p>
        <p class="auto-style3">
            <strong>&nbsp;Tecnologias utilizadas:</strong></p>
        <p class="auto-style2">
            <em>SOAP
                </em>
        </p>
        <p class="auto-style2">
            <em>Linguagem: C#
                </em>
        </p>
        <p class="auto-style2">
            <em>Web Forms
                </em>
        </p>
        <div class="auto-style4">
            <br />
&nbsp;06/11/2019</div>
    </form>
</body>
</html>
