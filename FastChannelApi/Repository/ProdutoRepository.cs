using FastChannelApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastChannelApi.Repository
{
    public class ProdutoRepository
    {
        public IList<Produto> Produtos { get; set; }
        /// <summary>
        ///     Mock dos produtos
        /// </summary>
        public ProdutoRepository()
        {
            Produtos = new List<Produto> {
                new Produto { Codigo = 1, Estoque = 10, Preco = 100},
                new Produto { Codigo = 2, Estoque = 4, Preco = 200},
                new Produto { Codigo = 3, Estoque = 7, Preco = 1000},
                new Produto { Codigo = 4, Estoque = 8, Preco = 100},
                new Produto { Codigo = 5, Estoque = 1, Preco = 400},
                new Produto { Codigo = 6, Estoque = 0, Preco = 100},
                new Produto { Codigo = 7, Estoque = 9, Preco = 500},
                new Produto { Codigo = 8, Estoque = 3, Preco = 10},
                new Produto { Codigo = 9, Estoque = 3, Preco = 80}
            };
        }
        /// <summary>
        ///     Recupera produto
        /// </summary>
        /// <param name="codigo">Filtro para busca</param>
        /// <returns>Retorna produto</returns>
        public Produto Busca(int codigo)
        {
            return Produtos.SingleOrDefault(p => p.Codigo == codigo);
        }
        /// <summary>
        ///     Atualiza produto
        /// </summary>
        /// <param name="produto">Produto que sera atualizado</param>
        /// <returns>Retorna Produto atualizado</returns>
        public Produto Atualiza(Produto produto)
        {
            var produtoDb = Busca(produto.Codigo);
            if (produtoDb == null) return null;

            produtoDb.Estoque = produto.Estoque;
            produtoDb.Preco = produto.Preco;

            return produtoDb;
        } 
    }
}