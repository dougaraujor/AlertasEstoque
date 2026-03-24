using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlertasEstoque.Domain.Entities.Produtos;

namespace AlertasEstoque.Domain.Entities.Alertas;


[Table("ConfiguracoesAlerta")]
public class ConfiguracaoAlerta
{
    [Key]
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public decimal NivelMinimo { get; set; }
    public decimal NivelCritico { get; set; }
    public bool Ativo { get; set; }
    
    public string UsuarioCriacao { get; set; }
    public DateTime DataCriacao { get; set; }
    public string? UsuarioAlteracao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    
    public virtual Produto produto { get; set; }
    public virtual ICollection<LogAlerta> Logs { get; set; }
    
    
}