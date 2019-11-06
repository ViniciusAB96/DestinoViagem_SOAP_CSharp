using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DestinoViagem
{
    public partial class ListaAcomodacoesFiltros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButPesq_Click(object sender, EventArgs e)
        {
            try
            {


                WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");

                int idDestino = 0;
                string nomeAcomodacao = TextNomeAcomodacao.Text;

                if (TextIDAcomod.Text != "")
                {
                    idDestino = int.Parse(TextIDAcomod.Text);
                    List<WebServiceDestinoViagem.Acomodacao> acomodacaos = new List<WebServiceDestinoViagem.Acomodacao>();
                    acomodacaos.Add(destinoViagem.PegaAcomodacaoPorCodigo(idDestino));

                    GridAcomodacao.DataSource = acomodacaos;

                    GridAcomodacao.DataBind();
                    return;

                }
                else if (nomeAcomodacao != "")
                {
                    GridAcomodacao.DataSource = destinoViagem.PegaAcomodacaoPorTipoNome(nomeAcomodacao);
                    GridAcomodacao.DataBind();
                    return;
                }


            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true);
                
            }

        }
    }
}