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
        private static List<Destino> destinos = new List<Destino>();
        private static List<Acomodacao> acomodacaosList = new List<Acomodacao>();

        Destino destino = new Destino(destinos);
        Acomodacao acomodacao = new Acomodacao(acomodacaosList);

        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]

        [WebMethod]
        public List<Destino> ObterTodosDestinos()
        {
            try
            {
                return destino.GetAllDestinos();
            }
            catch(Exception exp)
            {
                List<Destino> dest = null;
                return dest;
                 
            }
        }

        [WebMethod]
        public Destino PegaDestinoPorCodigo(int id)
        {
            return destino.GetById(id);
        }

        [WebMethod]
        public List<Destino> PegaDestinoPorFiltroDeNome(string name)
        {
            return destino.GetByNomeDestino(name);
        }

        [WebMethod]
        public string InserirDestino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade)
        {
            try
            {
                destino.InsertDestino(codigoDest, nomeDest, classificDestino, taxa, estado, cidade);
                return "Destino inserido com sucesso";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        [WebMethod]
        public string DeletarDestino(int codigoDestino)
        {
            try
            {
                destino.DeletDestino(codigoDestino);
                return "Destino deletado com suscesso.";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        [WebMethod]
        public string AtualizarDestino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade)
        {
            try
            {
                destino.UpdateDestino(codigoDest, nomeDest, classificDestino, taxa, estado, cidade);
                return "Destino atualizado com suscesso.";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        [WebMethod]
        public List<Destino> PegaTodosDestinosComAcomodacao()
        {
            return destino.GetAllDestinosAcomodacoes(acomodacaosList);
        }



        [WebMethod]
        public List<Acomodacao> ObterTodasAcomodacoes()
        {
            return acomodacao.GetAllAcomodacoes();
        }

        [WebMethod]
        public Acomodacao PegaAcomodacaoPorCodigo(int codigo)
        {
            return acomodacao.GetByCodigoAcomodacao(codigo);
        }

        [WebMethod]
        public List<Acomodacao> PegaListaDeAcomodacoesPorIdDestino(int idDestino)
        {
            return acomodacao.GetByCodigoDestino(idDestino);
        }



        [WebMethod]
        public List<Acomodacao> PegaAcomodacaoPorTipoNome(string tipoAcomod)
        {
            return acomodacao.GetByTipoAcomodacao(tipoAcomod);
        }

        [WebMethod]
        public string InserirAcomodacao(int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao, int destino)
        {
            try
            {

                acomodacao.InsertAcomodacao(codigo, tipo, quantidadeQuartos, cep, classifica, descricao, destino);
                return "Acomodacao inserida com sucesso";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        [WebMethod]
        public string DeletarAcomodacao(int codigoAcomodacao)
        {
            try
            {
                acomodacao.DeletAcomodacao(codigoAcomodacao);
                return "Acomodacao deletada com suscesso.";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

        [WebMethod]
        public string AtualizarAcomodacao(int codigo, string tipo, int quantidadeQuartos, string cep, int classifica, string descricao, int destino)
        {
            try
            {
                acomodacao.Updateacomodacao(codigo, tipo, quantidadeQuartos, cep, classifica, descricao, destino);
                return "Acomodacao atualizada com suscesso.";
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
        }

    }
}
