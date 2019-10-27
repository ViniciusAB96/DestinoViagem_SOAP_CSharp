using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Xml.Serialization;
using System.Data;
using WebServiceDestinoViagens.Models;

namespace WebServiceDestinoViagens
{
    /// <summary>
    /// Summary description for DestinoViagem
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DestinoViagem : System.Web.Services.WebService
    {
              
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]       
        [WebMethod]
        public List<Destino> ObterTodosDestinos()
        {
            return new Destino().getAll();
        }

        [WebMethod]
        public Destino PegaDestinoPorCodigo(int id)
        {
            return new Destino().getById(id);
        }

        [WebMethod]
        public List<Destino> PegaDestinoPorFiltroDeNome(string name)
        {
            return new Destino().getByNomeDestino(name);
        }
        //faltando o método de insert, delete e update.        
    }
}
