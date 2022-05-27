using System.Collections.ObjectModel;

namespace ApiTreinamento.DTOs
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }

        //Relacionamento de Categoria e Produto
        public ICollection<ProdutoDTO>? Produtos { get; set; }
    }
}
