using ApiTreinamento.Context;
using ApiTreinamento.Domain;

namespace ApiTreinamento.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext contexto) : base(contexto)
        {
        }

        public IEnumerable<Produto> GetProdutosPorPreco()
        {
            return Get().OrderBy(x => x.Preco).ToList();
        }
    }
}
