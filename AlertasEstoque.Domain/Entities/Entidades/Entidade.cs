using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlertasEstoque.Domain.Entities.Defs;

namespace AlertasEstoque.Domain.Entities.Entidades;

[Table("Entidades")]
public class Entidade 
{
    [Key]
    public int Id { get; set; }
    
    public string RazaoSocial { get; set; }
    
    public string? Fantasia  {get; set; }
    
    public DefSituacaoEntidade IdSituacao{ get; set; }
    
    [Column(("Obs"))]
    public string? Observacao { get; set; }
    
    public string? Imagem { get; set; }
    
    public DateTime? DataUltimoLogin { get; set; }
    
    public DateTime DataCriacao { get; set; }
    
    public DateTime? DataAlteracao { get; set; }
    
    
}