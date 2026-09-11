using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace MerceariaMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int? Idade  { get; set; }
        [Required]
        public bool Ativo { get; set; }

        public bool ValidacaoCliente()

        {
            if(Idade == null)
            {
                return false;
            }

            return Idade >= 18 && Idade != null && Email.Contains("@") && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Nome);

        }

        public bool PodeComprar()
        {
            return Ativo == true && Idade >= 18;
        }

     
    }
}
