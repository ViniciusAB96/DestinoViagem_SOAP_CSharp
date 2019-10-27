using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WebServiceDestinoViagens.Models
{
    public class Destino
    {
        private int codigoDestino;
        private string nomeDestino;
        private double classificacao;
        private double taxaDestino; //valor cobrado sobre o destino.
        private string estado;
        private string cidade;
        private List<Acomodacao> acomodacoes = new List<Acomodacao>();
        
        private List<Destino> Destinos;
        public int CodigoDestino {
            get
            {
                return codigoDestino;
            }
            set
            {
                codigoDestino = value;
            }
        }
        public string Nomedestino
        {
            get
            {
                return nomeDestino;
            }
            set
            {
                nomeDestino = value;
            }
        }
        public double Classificacao
        {
            get
            {
                return classificacao;
            }
            set
            {
                classificacao = value;
            }
        }
        public double TaxaDestino
        {
            get
            {
                return taxaDestino;
            }
            set
            {
                taxaDestino = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }
        public Destino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade, List<Acomodacao> acomodacoes)
        {
            try
            {
                if (!codigoDest.Equals(0) && nomeDest.Length > 3 && !classificDestino.Equals(0) && !taxa.Equals(0) && estado.Length == 2 && cidade.Length >= 3 && acomodacoes.Count > 0)
                {
                    this.CodigoDestino = codigoDest;
                    this.Nomedestino = nomeDest;
                    this.Classificacao = classificDestino;
                    this.TaxaDestino = taxa;
                    this.Estado = estado;
                    this.Cidade = cidade;
                    this.Acomodacoes = acomodacoes;
                }
                else
                {
                    throw new Exception("Erro nos parâmetros da classe Destino");
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
        public Destino()
        {
            Destinos = new List<Destino>();
            //int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao

            List<Acomodacao> acomodacoes = new List<Acomodacao>();
            acomodacoes.Add(new Acomodacao(1, 2, 3, "88343124", 3, "Ótimo local para passar as férias..."));
            acomodacoes.Add(new Acomodacao(2, 1, 2, "88340296", 3, "Ótimo local para passar as férias..."));
            acomodacoes.Add(new Acomodacao(3, 5, 2, "88340539", 4, "Ótimo local para passar as férias..."));
            acomodacoes.Add(new Acomodacao(4, 4, 3, "88348056", 4, "Ótimo local para passar as férias..."));
            acomodacoes.Add(new Acomodacao(5, 2, 2, "88348613", 5, "Ótimo local para passar as férias..."));
            Destinos.Add(new Destino(1, "Camboriú", 4.3, 50.0, "SC", "Balneário Camboriú", acomodacoes));

            List<Acomodacao> acomodacoes1 = new List<Acomodacao>();

            acomodacoes1.Add(new Acomodacao(6, 2, 1, "23550130", 5, "Local perfeito local para passar as férias..."));
            acomodacoes1.Add(new Acomodacao(7, 1, 2, "28895424", 4, "Ótimo local para passar as férias..."));
            acomodacoes1.Add(new Acomodacao(8, 5, 3, "20260150", 4, "Incrível local para relaxar."));
            acomodacoes1.Add(new Acomodacao(9, 5, 1, "28899398", 5, "Ótimo local para passar as férias..."));
            acomodacoes1.Add(new Acomodacao(10, 4, 2, "27277140", 4, "Sem palavras."));
            Destinos.Add(new Destino(2, "Ipanema", 4.9, 40.0, "RJ", "Copacabana", acomodacoes1));

            List<Acomodacao> acomodacoes2 = new List<Acomodacao>();

            acomodacoes2.Add(new Acomodacao(1, 2, 2, "46960970", 5, "Local perfeito local para passar as férias..."));
            acomodacoes2.Add(new Acomodacao(1, 2, 2, "46960970", 4, "Maravilhoso."));
            acomodacoes2.Add(new Acomodacao(1, 2, 2, "46960970", 3, "Sem palavras."));
            acomodacoes2.Add(new Acomodacao(1, 2, 3, "46960970", 4, "Ótimo local para passar as férias..."));
            acomodacoes2.Add(new Acomodacao(1, 2, 3, "46960970", 5, "Inacreditável"));
            Destinos.Add(new Destino(3, "Chapada Diamantina", 4.7, 80.0, "BA", "Lençois", acomodacoes2));


            List<Acomodacao> acomodacoes3 = new List<Acomodacao>();

            acomodacoes3.Add(new Acomodacao(11, 2, 2, "95670975", 4, "Ótimo local para passar as férias..."));
            acomodacoes3.Add(new Acomodacao(12, 2, 3, "95670972", 2, "Maravilhoso."));
            acomodacoes3.Add(new Acomodacao(13, 2, 2, "95670970", 5, "Sem palavras."));
            acomodacoes3.Add(new Acomodacao(14, 2, 1, "95670976", 3, "Ótimo local para passar as férias..."));
            acomodacoes3.Add(new Acomodacao(15, 2, 1, "95670971", 2, "Local perfeito local para passar as férias..."));
            Destinos.Add(new Destino(4, "Gramado", 4.3, 50.0, "RS", "Gramado", acomodacoes3));
        }

        public List<Acomodacao> Acomodacoes
        {
            get
            {
                return acomodacoes;
            }
            set
            {
                acomodacoes = value;
            }

        }
        public List<Destino> getAll()
        {
            return Destinos;
        }
        public List<Destino> getByNomeDestino(string nomeDestino)
        {
            return Destinos.Where(w => w.Nomedestino.ToLower().Contains(nomeDestino.ToLower().Trim())).ToList();
        }
        public Destino getById(int id)
        {
            return Destinos.Where(w => w.CodigoDestino.Equals(id)).FirstOrDefault();
        }
    }
}