using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DestinoViagem
{
    public partial class IDUDestinos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelStatus.Text = "";

        }

        protected void ButInsert_Click(object sender, EventArgs e)
        {
            
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idDestino = int.Parse(TextIdDestino.Text);

                List<WebServiceDestinoViagem.Destino> destinos = new List<WebServiceDestinoViagem.Destino>();
                destinos.Add(destinoViagem.PegaDestinoPorCodigo(idDestino));

                if (!destinos.Contains(null))
                {
                    string message = "Destino não pode ser inserido pois o mesmo existe na lista de destino.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
                    return;
                }
                else
                {
                    destinoViagem.InserirDestino(idDestino, TextNomeDestino.Text, Convert.ToDouble(TextClassifica.Text), Convert.ToDouble(TextTaxa.Text), TextEstado.Text, TextCidade.Text);
                    LabelStatus.Text = "Destino Inserido com sucesso.";
                }                                

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true); ;
            }
        }

        protected void ButAtualizar_Click(object sender, EventArgs e)
        {

            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idDestino = int.Parse(TextIdDestino.Text);

                List<WebServiceDestinoViagem.Destino> destinos = new List<WebServiceDestinoViagem.Destino>();
                destinos.Add(destinoViagem.PegaDestinoPorCodigo(idDestino));

                if (destinos.ToArray()[0] == null)
                {
                    string message =  "Destino não pode ser atualizado pois ele não existe na lista de destino.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true); ;
                    return;
                }
                else
                {
                    destinoViagem.AtualizarDestino(idDestino, TextNomeDestino.Text, Convert.ToDouble(TextClassifica.Text), Convert.ToDouble(TextTaxa.Text), TextEstado.Text, TextCidade.Text);
                    LabelStatus.Text = "Destino Atualizado com sucesso.";
                }

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true); ;
            }
        }

        protected void ButDelete_Click(object sender, EventArgs e)
        {
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idDestino = int.Parse(TextIdDestino.Text);
                destinoViagem.DeletarDestino(idDestino);
                LabelStatus.Text = "Destino deleteado com sucesso";

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true); ;
            }
        }
        protected void TextIdDestino_TextChanged(object sender, EventArgs e)
        {
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try { 
                int idDestino = int.Parse(TextIdDestino.Text);
                List<WebServiceDestinoViagem.Destino> destinos = new List<WebServiceDestinoViagem.Destino>();
                destinos.Add(destinoViagem.PegaDestinoPorCodigo(idDestino));
                
                GridDestinos.DataSource = destinos;

                GridDestinos.DataBind();
                return;
            }
            catch(Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true); ;
            }
        }
    }
}