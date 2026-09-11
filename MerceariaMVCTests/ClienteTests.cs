using MerceariaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerceariaMVCTests
{
    public class ClienteTests
    {
        [Fact]
        public void Verificar_Idade_Menorque18Anos()
        {
            //Arrange
            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 17,
                Email = "carlos#gmail.com",
                Ativo = true,

            };

            //Act

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }
        [Fact]
        public void Verificar_Email_Invalido()
        {
            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 18,
                Email = "carlos#gmail.com",
                Ativo = true,
            };

            //Act 

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Nome_Invalido()
        {
       

            //Arrange

            var cliente = new Cliente
            {
                Nome = "",
                Idade = 18,
                Email = "carlos@gmail.com",
                Ativo = true,
            };

            //Act 

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Cliente_Ativo()
        {
            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 18,
                Email = "carlos@gmail.com",
                Ativo = false,
            };

            //Act 

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.False(resultado);

        }

        [Fact]
        public void Verificar_Cliente_Inativo_E_MenordeIdade()
        {
            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 18,
                Email = "carlos@gmail.com",
                Ativo = false,
            };

            //Act 

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.False(resultado);
        }

        [Fact]
        public void Verificar_Cliente_Ativo_E_Menor_de_Idade_True()
        {
            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 18,
                Email = "carlos@gmail.com",
                Ativo = true,
            };

            //Act 

            var resultado = cliente.PodeComprar();

            //Assert

            Assert.True(resultado);
        }

        [Fact]
        public void Verificar_Nome_Valido_Idade_Maiorque18_Email_Vaalido()
        {


            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
                Idade = 18,
                Email = "carlos@gmail.com",
                Ativo = true,
            };

            //Act 

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.True(resultado);
        }

        [Fact]

        public void Verificar_Idade_Vazia()
        {
            //Arrange

            var cliente = new Cliente
            {
                Nome = "Carlos Augusto",
            
                Email = "carlos@gmail.com",
                Ativo = true,
            };

            //Act 

            var resultado = cliente.ValidacaoCliente();

            //Assert

            Assert.False(resultado);

        }
    }
}
