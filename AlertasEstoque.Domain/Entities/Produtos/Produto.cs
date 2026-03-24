using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlertasEstoque.Domain.Entities.Alertas;

namespace AlertasEstoque.Domain.Entities.Produtos;


[Table("Produtos")]
public class Produto
{
    
    [Key]
    public int Id { get; set; }
    public string Sku { get; set; }
    public string Descricao { get; set; }
    public string? UnidadeMedida { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    
    public virtual ICollection<ConfiguracaoAlerta> ConfiguracaoAlerta { get; set; } = new List<ConfiguracaoAlerta>();
}