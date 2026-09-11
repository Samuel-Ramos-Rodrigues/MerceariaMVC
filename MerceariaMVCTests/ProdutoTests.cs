using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVC.Models;

namespace MerceariaMVCTests
{
    public class ProdutoTests
    {

        [Fact]
        public void Verificar_Preco_Valido_se_ForMenorqueZero()
        {
            //Arrange

            var produto = new Produto
            {
                Nome = "Pacote Salada",
                Preco = 0,
                Estoque = 500
            };

            //Act
            var resultado = produto.Validacao();

            //Assert

            Assert.False(resultado);
        }
        [Fact]

        public void Estque_Invalido_se_Valor_MenorqueZero()
        {
            //Arrange 

            var produto = new Produto
            {
                Nome = "Muçarela",
                Preco = 45,
                Estoque = -1
            };

            //Act 

            var resultado = produto.Validacao();

            //Assert
            Assert.False(resultado);

        }
        [Fact]
        public void Verificar_Nome_Nulo_ou_Vazio_Invalido()
        {

            //Arrange
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 45
            };
            //Act 

            var resultado = produto.Validacao();

            //Assert

            Assert.False(resultado);

        }
        [Fact]

        public void Verifica_ProdutoMaiorqueZero_Estoque_MaiorqueZero_NomeProdutoExistente()
        {

            //Arrange

            var produto = new Produto
            {
                Nome = "Proteína Isolada",
                Preco = 115,
                Estoque = 50
            };

            //Act 

            var resultado = produto.Validacao();

            //Assert

            Assert.True(resultado);

        }
    }
}
