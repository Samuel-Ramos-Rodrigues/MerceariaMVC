namespace MerceariaMVC.Models
{
    public class Produto
    {

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public bool Validacao()
        {
           return Preco > 0 && Estoque > 0 && !string.IsNullOrEmpty(Nome);

        }
    }
}
