using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DestinoViagem
{
    public partial class DestinoPorCodigo : System.Web.UI.Page
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
                string nomeDestino = TextNome.Text.ToString();                           

                if (TextID.Text != "")
                {
                    idDestino = int.Parse(TextID.Text);
                    List<WebServiceDestinoViagem.Destino> destinos = new List<WebServiceDestinoViagem.Destino>();
                    destinos.Add(destinoViagem.PegaDestinoPorCodigo(idDestino));

                    GridDestinos.DataSource = destinos;

                    GridDestinos.DataBind();
                    return;

                }
                else if (nomeDestino != "")
                {
                    GridDestinos.DataSource = destinoViagem.PegaDestinoPorFiltroDeNome(nomeDestino);
                    GridDestinos.DataBind();
                    return;
                }


            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }

        }
    }
}