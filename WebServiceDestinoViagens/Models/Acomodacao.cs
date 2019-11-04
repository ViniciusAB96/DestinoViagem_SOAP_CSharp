using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceDestinoViagens.Models
{
    public class Acomodacao
    {
        private int codigoAcomodacao;
        private string tipo;
        private int quantidadeQuartos;
        private string cep;
        private int classificacao;
        private string descricao;
        private int iddestino;
        public List<Acomodacao> Acomodacoes;

        /// <summary>
        /// Pode haver algum erro no retorno do Código da Acomodacao
        /// </summary>
        public int CodigoAcomodacao
        {
            get => codigoAcomodacao;
            set => codigoAcomodacao = value; //varificar se isso dá certo
        }
        public string Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
            }
        }
        public int QuantidadeQuartos
        {
            get => quantidadeQuartos;
            set
            {
                quantidadeQuartos = value;
            }
        }
        public string CEP
        {
            get
            {
                return cep;
            }
            set
            {
                cep = value;
            }
        }
        public int Classificacao
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
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public int IdDestino
        {
            get
            {
                return iddestino;

            }
            set
            {
                iddestino = value;
            }
        }


        public List<Acomodacao> GetAllAcomodacoes()
        {
            return Acomodacoes;
        }
        public List<Acomodacao> GetByTipoAcomodacao(string tipoAcomodacao)
        {
            return Acomodacoes.Where(w => w.Tipo.ToLower().Contains(tipoAcomodacao.ToLower().Trim())).ToList();
        }
        public Acomodacao GetByCodigoAcomodacao(int codigo)
        {
            return Acomodacoes.Where(w => w.CodigoAcomodacao.Equals(codigo)).FirstOrDefault();
        }

        public List<Acomodacao> GetByCodigoDestino(int codigoDestino)
        {
            return Acomodacoes.Where(w => w.IdDestino == codigoDestino).Select(n => n).ToList();
        }

        public void InsertAcomodacao(int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao, int destino)
        {
            Acomodacoes.Add(new Acomodacao(codigo, tipo, quantidadeQuartos, cep, classifica, descricao, destino));
        }
        public void DeletAcomodacao(int codigo)
        {
            Acomodacao acomodRemov = Acomodacoes.Where(n => n.CodigoAcomodacao == codigo).Select(n => n).First();
            Acomodacoes.Remove(acomodRemov);
        }
        public void Updateacomodacao(int codigo, string tipo, int quantidadeQuartos, string cep, int classifica, string descricao, int IDdestino)
        {
            Acomodacoes.Where(n => n.CodigoAcomodacao == codigo).Select(s =>
            {
                s.CodigoAcomodacao = codigo;
                s.Tipo = tipo;
                s.QuantidadeQuartos = quantidadeQuartos;
                s.CEP = cep;
                s.Classificacao = classifica;
                s.Descricao = descricao;
                s.IdDestino = IDdestino;
                return s;
            }).ToList();

        }









        /// <summary>
        /// Construtores da classe Acomodacoes
        /// </summary>
        /// <param name="codigo">Codigo da Acomodacao</param>
        /// <param name="tipo">Hotel = 1, Pousada = 2, Rancho =3 , Apartamento = 4, Resort = 5, Villa = 6, Chale = 7, Casa_de_campo = 8 </param>
        /// <param name="quantidadeQuartos"></param>
        /// <param name="cep"></param>
        /// <param name="classifica"></param>
        /// <param name="descricao"></param>
        public Acomodacao(int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao, int destino)
        {
            try
            {
                if (!codigo.Equals(0) && tipo > 0 && quantidadeQuartos >= 1 && classifica >= 1 && descricao.Length >= 3)
                {
                    this.CodigoAcomodacao = codigo;
                    this.Tipo = Enum.GetName(typeof(TipoAcomodacao), tipo);
                    this.QuantidadeQuartos = quantidadeQuartos;
                    this.CEP = cep;
                    this.Classificacao = classifica;
                    this.Descricao = descricao;
                    this.IdDestino = destino;                    
                }
                else
                {
                    throw new Exception("Erro nos parâmetros do construtor Acomodacao");
                }
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }
        public Acomodacao()
        { }
        public Acomodacao(List<Acomodacao> acomodacaosList)
        {
            this.Acomodacoes = acomodacaosList;
            if(Acomodacoes.Count ==0)
            {
                Acomodacoes.Add(new Acomodacao(1, 2, 3, "88343124", 3, "Ótimo local para passar as férias...", 1));
                Acomodacoes.Add(new Acomodacao(2, 1, 2, "88340296", 3, "Ótimo local para passar as férias...", 1));
                Acomodacoes.Add(new Acomodacao(3, 5, 2, "88340539", 4, "Ótimo local para passar as férias...", 1));
                Acomodacoes.Add(new Acomodacao(4, 4, 3, "88348056", 4, "Ótimo local para passar as férias...", 1));
                Acomodacoes.Add(new Acomodacao(5, 2, 2, "88348613", 5, "Ótimo local para passar as férias...", 1));
                Acomodacoes.Add(new Acomodacao(6, 2, 1, "23550130", 5, "Local perfeito local para passar as férias...", 2));
                Acomodacoes.Add(new Acomodacao(7, 1, 2, "28895424", 4, "Ótimo local para passar as férias...", 2));
                Acomodacoes.Add(new Acomodacao(8, 5, 3, "20260150", 4, "Incrível local para relaxar.", 2));
                Acomodacoes.Add(new Acomodacao(9, 5, 1, "28899398", 5, "Ótimo local para passar as férias...", 2));
                Acomodacoes.Add(new Acomodacao(10, 4, 2, "27277140", 4, "Sem palavras.", 2));
                Acomodacoes.Add(new Acomodacao(11, 2, 2, "46960970", 5, "Local perfeito local para passar as férias...", 3));
                Acomodacoes.Add(new Acomodacao(12, 2, 2, "46960970", 4, "Maravilhoso.", 3));
                Acomodacoes.Add(new Acomodacao(13, 2, 2, "46960970", 3, "Sem palavras.", 3));
                Acomodacoes.Add(new Acomodacao(14, 2, 3, "46960970", 4, "Ótimo local para passar as férias...", 3));
                Acomodacoes.Add(new Acomodacao(15, 2, 3, "46960970", 5, "Inacreditável", 3));
                Acomodacoes.Add(new Acomodacao(16, 2, 2, "95670975", 4, "Ótimo local para passar as férias...", 4));
                Acomodacoes.Add(new Acomodacao(17, 2, 3, "95670972", 2, "Maravilhoso.", 4));
                Acomodacoes.Add(new Acomodacao(18, 2, 2, "95670970", 5, "Sem palavras.", 4));
                Acomodacoes.Add(new Acomodacao(19, 2, 1, "95670976", 3, "Ótimo local para passar as férias...", 4));
                Acomodacoes.Add(new Acomodacao(20, 2, 1, "95670971", 2, "Local perfeito local para passar as férias...", 4));

            }
        }
    }
}