using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlertasEstoque.Domain.Entities.Alertas;


[Table("LogAlertas")]
public class LogAlerta
{
    [Key]
    public int Id { get; set; }
    public int ConfiguracaoAlertaId { get; set; }
    public DateTime DataGeracao{ get; set; }
    public decimal QuantidadeNoMomento { get; set; }
    public int StatusAlerta { get; set; }
    public string? Observacao { get; set; }

    public virtual ConfiguracaoAlerta ConfiguracaoAlerta { get; set; } = null!;

}