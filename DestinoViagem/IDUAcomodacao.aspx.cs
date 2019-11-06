using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DestinoViagem
{
    public partial class IDUAcomodacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelStatus.Text = "";
            if (!IsPostBack)
            {
                WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");

                List<WebServiceDestinoViagem.Destino> destinos = destinoViagem.ObterTodosDestinos().ToList();
                DropDownDestinos.DataTextField = "Nomedestino";
                DropDownDestinos.DataValueField = "CodigoDestino";
                DropDownDestinos.DataSource = destinos;
                DropDownDestinos.DataBind();
            }
        }

        protected void TextIdAcomodacao_TextChanged(object sender, EventArgs e)
        {
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idAcomodacao = int.Parse(TextIdAcomodacao.Text);
                List<WebServiceDestinoViagem.Acomodacao> acomodacoes = new List<WebServiceDestinoViagem.Acomodacao>();
                acomodacoes.Add(destinoViagem.PegaAcomodacaoPorCodigo(idAcomodacao));

                GridAcomodacao.DataSource = acomodacoes;
                GridAcomodacao.DataBind();
                return;
            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true);
            }
        }

        protected void ButDelete_Click(object sender, EventArgs e)
        {

            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idAcomodacao = int.Parse(TextIdAcomodacao.Text);
                destinoViagem.DeletarAcomodacao(idAcomodacao);
                LabelStatus.Text = "Acomodacao deleteada com sucesso";

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true);
            }
        }

        protected void ButInsert_Click(object sender, EventArgs e)
        {
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {               

                int idAcomodacao = int.Parse(TextIdAcomodacao.Text);

                List<WebServiceDestinoViagem.Acomodacao> acomodacaos = new List<WebServiceDestinoViagem.Acomodacao>();
                acomodacaos.Add(destinoViagem.PegaAcomodacaoPorCodigo(idAcomodacao));

                if (!acomodacaos.Contains(null))
                {
                    string message = "Acomodação não pode ser inserida pois ela não existe na lista de destino.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);                    
                    return;
                }
                else
                {
                    
                    destinoViagem.InserirAcomodacao(idAcomodacao, int.Parse(TextTipoAcomodacao.Text), Convert.ToInt32(TextQuantidadeQuartos.Text), TextCEP.Text, Convert.ToInt32(TextClassificacao.Text), TextDescricao.Text, int.Parse(DropDownDestinos.SelectedValue));
                    LabelStatus.Text = "Acomodação inserida com sucesso.";
                }

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true);
            }

        }

        protected void ButAtualizar_Click(object sender, EventArgs e)
        {
            WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");
            try
            {
                int idAcomodacao = int.Parse(TextIdAcomodacao.Text);

                List<WebServiceDestinoViagem.Destino> acomodacaos = new List<WebServiceDestinoViagem.Destino>();
                acomodacaos.Add(destinoViagem.PegaDestinoPorCodigo(idAcomodacao));

                if (acomodacaos.ToArray()[0] == null)
                {
                    string message = "Acomodação não pode ser atualizada pois ela não existe na lista de acomodações.";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
                    return;
                }
                else
                {
                    destinoViagem.AtualizarAcomodacao(idAcomodacao, TextTipoAcomodacao.Text, Convert.ToInt32(TextQuantidadeQuartos.Text), TextCEP.Text, Convert.ToInt32(TextClassificacao.Text), TextDescricao.Text, int.Parse(DropDownDestinos.SelectedValue));
                    LabelStatus.Text = "Acomodação atualizada com sucesso.";
                }

            }
            catch (Exception exp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exp.Message + "');", true);
            }
        }
    }
}