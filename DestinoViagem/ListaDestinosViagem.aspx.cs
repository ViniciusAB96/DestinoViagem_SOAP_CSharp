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
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
                WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");

                List<WebServiceDestinoViagem.Destino> destinos = destinoViagem.ObterTodosDestinos().ToList();
                dropDown.DataTextField = "Nomedestino";
                dropDown.DataValueField = "CodigoDestino";
                dropDown.DataSource = destinos;
                dropDown.DataBind();
            }

        }

        protected void ButListar_Click(object sender, EventArgs e)
        {
            
            
            //foreach (WebServiceDestinoViagem.Destino dest in destinos)
            //{
            //    TableDestinos.Rows.Add.Items(dest.CodigoDestino.ToString(), dest.Nomedestino, dest.Classificacao.ToString(), dest.Estado, dest.Cidade);
            //}
        }

        protected void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            GvAcomodacoes.DataSource = destinoViagem.PegaListaDeAcomodacoesPorIdDestino(int.Parse(dropDown.SelectedValue));
            GvAcomodacoes.DataBind();
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            
        }

        protected void GvAcomodacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}