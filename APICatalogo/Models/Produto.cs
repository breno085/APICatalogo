using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APICatalogo.Validations;

namespace APICatalogo.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(20, ErrorMessage = "O nome deve ter entre 5 e 20 caracteres",
        MinimumLength = 5)]
    [PrimeiraLetraMaiscula]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
    public string? Descricao { get; set; }
    
    [Required]
    [Range(1, 10000, ErrorMessage = "O preço deve estar entre {1} e {2}")]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300, MinimumLength = 10)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
    
}
