using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTreinamento.Domain
{
    [Table("Promocoes")]
    public class Promocao
    {
        public Promocao()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int PromocaoId { get; set; }
        [MaxLength(300)]
        public string? Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
