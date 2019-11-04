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
        //private List<Acomodacao> acomodacoes = new List<Acomodacao>();
        public int CodigoDestino
        {
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

        public List<Destino> Destinos;
        public List<Acomodacao> Acomodacoes;

        /*public List<Acomodacao> Acomodacoes
        {
            get
            {
                return acomodacoes;
            }
            set
            {
                acomodacoes = value;
            }

        }*/



        /// <summary>
        /// Métodos
        /// </summary>
        /// <returns></returns>
        public List<Destino> GetAllDestinos()
        {
            return Destinos;
        }
        public List<Destino> GetByNomeDestino(string nomeDestino)
        {
            return Destinos.Where(w => w.Nomedestino.ToLower().Contains(nomeDestino.ToLower().Trim())).ToList();
        }
        public Destino GetById(int id)
        {
            return Destinos.Where(w => w.CodigoDestino.Equals(id)).FirstOrDefault();
        }
        public void InsertDestino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade)
        {
            Destinos.Add(new Destino(codigoDest, nomeDest, classificDestino, taxa, estado, cidade));
        }
        public void DeletDestino(int codigoDest)
        {
            Destino dest = Destinos.Where(n => n.codigoDestino == codigoDest).Select(n => n).First();
            Destinos.Remove(dest);
        }
        public void UpdateDestino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade)
        {
            Destinos.Where(n => n.CodigoDestino == codigoDest).Select(s =>
            {
                s.CodigoDestino = codigoDest;
                s.Nomedestino = nomeDest;
                s.Classificacao = classificDestino;
                s.TaxaDestino = taxa;
                s.Estado = estado;
                s.Cidade = cidade;
                return s;
            }).ToList();

        }

        public List<Destino> GetAllDestinosAcomodacoes(List<Acomodacao> acomodacoes)
        {
            foreach (Destino d in Destinos)
            {
                d.Acomodacoes = acomodacoes.Where(n => n.IdDestino == d.codigoDestino).Select(n => n).ToList();
                
            }
            return Destinos;
        }
        


        /// <summary>
        /// Contrutores
        /// </summary>
        /// <param name="codigoDest"></param>
        /// <param name="nomeDest"></param>
        /// <param name="classificDestino"></param>
        /// <param name="taxa"></param>
        /// <param name="estado"></param>
        /// <param name="cidade"></param>
        /// <param name="idAcomodacao"></param>
        public Destino(int codigoDest, string nomeDest, double classificDestino, double taxa, string estado, string cidade /*List<Acomodacao> acomodacoes*/)
        {
            try
            {
                if (!codigoDest.Equals(0) && nomeDest.Length > 3 && !classificDestino.Equals(0) && !taxa.Equals(0) && estado.Length == 2 && cidade.Length >= 3)
                {
                    this.CodigoDestino = codigoDest;
                    this.Nomedestino = nomeDest;
                    this.Classificacao = classificDestino;
                    this.TaxaDestino = taxa;
                    this.Estado = estado;
                    this.Cidade = cidade;
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
        public Destino(List<Destino> destinos)
        {
            this.Destinos = destinos;
            if (destinos.Count == 0)
            {
                //int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao

                //List<Acomodacao> acomodacoes = new List<Acomodacao>();
                //acomodacoes.Add(new Acomodacao(1, 2, 3, "88343124", 3, "Ótimo local para passar as férias...", 1));
                //acomodacoes.Add(new Acomodacao(2, 1, 2, "88340296", 3, "Ótimo local para passar as férias...", 1));
                //acomodacoes.Add(new Acomodacao(3, 5, 2, "88340539", 4, "Ótimo local para passar as férias...", 1));
                //acomodacoes.Add(new Acomodacao(4, 4, 3, "88348056", 4, "Ótimo local para passar as férias...", 1));
                //acomodacoes.Add(new Acomodacao(5, 2, 2, "88348613", 5, "Ótimo local para passar as férias...", 1));


                //List<Acomodacao> acomodacoes1 = new List<Acomodacao>();

                //acomodacoes1.Add(new Acomodacao(6, 2, 1, "23550130", 5, "Local perfeito local para passar as férias...", 2));
                //acomodacoes1.Add(new Acomodacao(7, 1, 2, "28895424", 4, "Ótimo local para passar as férias...", 2));
                //acomodacoes1.Add(new Acomodacao(8, 5, 3, "20260150", 4, "Incrível local para relaxar.", 2));
                //acomodacoes1.Add(new Acomodacao(9, 5, 1, "28899398", 5, "Ótimo local para passar as férias...", 2));
                //acomodacoes1.Add(new Acomodacao(10, 4, 2, "27277140", 4, "Sem palavras.", 2));


                //List<Acomodacao> acomodacoes2 = new List<Acomodacao>();

                //acomodacoes2.Add(new Acomodacao(11, 2, 2, "46960970", 5, "Local perfeito local para passar as férias...", 3));
                //acomodacoes2.Add(new Acomodacao(12, 2, 2, "46960970", 4, "Maravilhoso.", 3));
                //acomodacoes2.Add(new Acomodacao(13, 2, 2, "46960970", 3, "Sem palavras.", 3));
                //acomodacoes2.Add(new Acomodacao(14, 2, 3, "46960970", 4, "Ótimo local para passar as férias...", 3));
                //acomodacoes2.Add(new Acomodacao(15, 2, 3, "46960970", 5, "Inacreditável", 3));



                //List<Acomodacao> acomodacoes3 = new List<Acomodacao>();

                //acomodacoes3.Add(new Acomodacao(16, 2, 2, "95670975", 4, "Ótimo local para passar as férias...", 4));
                //acomodacoes3.Add(new Acomodacao(17, 2, 3, "95670972", 2, "Maravilhoso.", 4));
                //acomodacoes3.Add(new Acomodacao(18, 2, 2, "95670970", 5, "Sem palavras.", 4));
                //acomodacoes3.Add(new Acomodacao(19, 2, 1, "95670976", 3, "Ótimo local para passar as férias...", 4));
                //acomodacoes3.Add(new Acomodacao(20, 2, 1, "95670971", 2, "Local perfeito local para passar as férias...", 4));


                destinos.Add(new Destino(1, "Camboriú", 4.3, 50.0, "SC", "Balneário Camboriú"));
                destinos.Add(new Destino(2, "Ipanema", 4.9, 40.0, "RJ", "Copacabana"));
                destinos.Add(new Destino(3, "Chapada Diamantina", 4.7, 80.0, "BA", "Lençois"));
                destinos.Add(new Destino(4, "Gramado", 4.3, 50.0, "RS", "Gramado"));
            }

        }
        public Destino()
        { }


    }
}