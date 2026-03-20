using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlertasEstoque.Domain.Entities.Defs;


[Table("DefSituacaoEntidade")]
public class DefSituacaoEntidade
{
    [Key]
    public int IdSituacao { get; set; }
    
    public string Descricao { get; set; }
}