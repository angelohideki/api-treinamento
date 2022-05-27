using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTreinamento.Domain;

[Table("Compras")]
public class Compra
{
    public Compra()
    {
        Produtos = new Collection<Produto>();
    }
    [Key]
    public int CompraId { get; set; }
    public float Quantidade { get; set; }
    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public double PrecoUnitario { get; set; }
    public ICollection<Produto> Produtos { get; set; }
}
