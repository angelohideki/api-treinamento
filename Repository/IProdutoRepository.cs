using ApiTreinamento.Domain;

namespace ApiTreinamento.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosPorPreco();
    }
}
