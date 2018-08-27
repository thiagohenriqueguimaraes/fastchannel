using System;
using FastChannelApi.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastChannelApi.Tests
{
    [TestClass]
    public class ProtutoUT
    {
        public ProdutoRepository produtoRepository { get; set; }
        public ProtutoUT()
        {
            produtoRepository = new ProdutoRepository();
        }
        [TestMethod]
        public void BuscaProdutoTest()
        {
            var produto = produtoRepository.Busca(1);
            Assert.IsNotNull(produto);
        }

        [TestMethod]
        public void NaoEncontraProdutoTest()
        {
            var produto = produtoRepository.Busca(11);
            Assert.IsNull(produto);
        }

        [TestMethod]
        public void AlteraProdutoTest()
        {
            var produto = produtoRepository.Busca(1);
            produto.Estoque = 3;
            produto.Preco = 9;
            var produtoDb = produtoRepository.Atualiza(produto);
            Assert.AreEqual(produto.Estoque, produtoDb.Estoque);
            Assert.AreEqual(produto.Preco, produtoDb.Preco);
        }


    }
}
