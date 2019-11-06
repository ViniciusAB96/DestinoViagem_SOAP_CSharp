using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DestinoViagem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WebServiceDestinoViagem.DestinoViagemSoapClient destinoViagem = new WebServiceDestinoViagem.DestinoViagemSoapClient("DestinoViagemSoap");

                List<WebServiceDestinoViagem.Destino> destinos = destinoViagem.ObterTodosDestinos().ToList();
                GvDestios.DataSource = destinoViagem.ObterTodosDestinos();
                GvDestios.DataBind();
            }
        }
    }
}