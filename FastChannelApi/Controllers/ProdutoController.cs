using FastChannelApi.Domain;
using FastChannelApi.Repository;
using System.Web.Http;
using System.Web.Http.Description;

namespace FastChannelApi.Controllers
{
    public class ProdutoController : ApiController
    {
        private ProdutoRepository ProdutoRepository { get; }
        public ProdutoController()
        {
            ProdutoRepository = new ProdutoRepository();
        }
        // GET: /api/produto/busca?codigo=1
        [HttpGet]
        [ResponseType(typeof(Produto))]
        public Produto Busca(int codigo)
        {
            return ProdutoRepository.Busca(codigo);
        }

        // POST: /api/produto/atualiza
        public string Atualiza([FromBody]Produto produto)
        {
            var produtoDb = ProdutoRepository.Atualiza(produto);
            
            if (produtoDb == null)
                return "Produto não encontrado";

            return "Dados do produto que foi alterado";
        }
    }
}
