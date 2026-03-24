using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlertasEstoque.Domain.Entities.Entidades;

namespace AlertasEstoque.Domain.Entities.Defs;


[Table("DefSituacaoEntidade")]
public class DefSituacaoEntidade


{
    [Key]
    
    public int IdSituacao { get; set; }
    
    public string Descricao { get; set;}
        
    public virtual ICollection<Entidade> Entidades { get; set; } = new List<Entidade>();
}