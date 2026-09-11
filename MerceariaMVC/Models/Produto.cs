using System.ComponentModel.DataAnnotations;

namespace MerceariaMVC.Models
{
    public class Produto
    {
        [Key]   
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        public int Estoque { get; set; }

        public bool Validacao()
        {
           return Preco > 0 && Estoque > 0 && !string.IsNullOrEmpty(Nome);

        }
    }
}
