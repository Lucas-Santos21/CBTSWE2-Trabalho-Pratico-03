//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03Produtos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório")]
        [StringLength(100, ErrorMessage ="O nome deve ter no maximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="A descricao e obrigatoria")]
        [StringLength(500, ErrorMessage ="A descrição deve ter no maximo 500 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="O preço é obrigatorio")]
        [Range(0.01, 999999999.99, ErrorMessage = "O preço deve ser maior que zero e menor que 999999999.99")]
        [Column(TypeName ="decimal(11,2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade em estoque é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage ="A quantidade em estoque nao pode ser negativa")]
        public int QuantidadeEstoque { get; set; }
    }
}
