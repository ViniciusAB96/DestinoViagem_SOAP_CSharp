using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace DestinoViagem
{
    public partial class ListaDestinosViagem : System.Web.UI.Page
    {
        WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
        protected void Page_Load(object sender, EventArgs e)
        {

          
           

        }

        protected void ButListar_Click(object sender, EventArgs e)
        {
            List<WebServiceDestinoViagem.Destino> destinos = destinoViagem.ObterTodosDestinos().ToList();
            
            foreach (WebServiceDestinoViagem.Destino dest in destinos)
            {
                TableDestinos.Rows.Add.Items(dest.CodigoDestino.ToString(), dest.Nomedestino, dest.Classificacao.ToString(), dest.Estado, dest.Cidade);
            }
        }
    }
}