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
        
        /// <summary>
        /// Construtor da classe Acomodacoes
        /// </summary>
        /// <param name="codigo">Codigo da Acomodacao</param>
        /// <param name="tipo">Hotel = 1, Pousada = 2, Rancho =3 , Apartamento = 4, Resort = 5, Villa = 6, Chale = 7, Casa_de_campo = 8 </param>
        /// <param name="quantidadeQuartos"></param>
        /// <param name="cep"></param>
        /// <param name="classifica"></param>
        /// <param name="descricao"></param>
        public Acomodacao(int codigo, int tipo, int quantidadeQuartos, string cep, int classifica, string descricao)
        {
            try
            {
                if (!codigo.Equals(0) && tipo > 0 && quantidadeQuartos >= 1 && classifica >= 1 && descricao.Length > 10)
                {
                    this.Classificacao = codigo;
                    Tipo = Enum.GetName(typeof(TipoAcomodacao), tipo);
                    this.QuantidadeQuartos = quantidadeQuartos;
                    this.CEP = cep;
                    this.Classificacao = classifica;
                    this.Descricao = descricao;
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
    }
}