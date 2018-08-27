using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastChannelApi.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Produto
    {
        /// <summary>
        ///     Recupera ou define Código do Produto
        /// </summary>
        public int Codigo { get; set; }

        private int _estoque;
        /// <summary>
        ///     Recupera ou define a quantidade de estoque
        /// </summary>
        public int Estoque
        {
            get { return _estoque; }
            set
            {
                if (value < 0)
                    throw new Exception("Estoque não pode ser menor que zero");
                _estoque = value;
            }
        }

        /// <summary>
        ///     Recupera ou define o Preço do Produto
        /// </summary>
        public decimal Preco { get; set; }
    }
}