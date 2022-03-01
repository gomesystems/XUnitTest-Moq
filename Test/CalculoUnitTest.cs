using System;
using Xunit;

namespace Test
{
    public class CalculoUnitTest
    {
        [Fact]
        [Trait("CalculoUnitTest", "Somar")]
        public void Somar_DoisDouble_Retornarouble()
        {

            //Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 6;

            //Act 
            var soma = CalculoXUnit.Calculo.Somar(num1,num2);

            //Assert
            Assert.Equal(valorEsperado,soma);
        }

        [Fact]
        [Trait("CalculoUnitTest", "Subtrair")]
        public void Subtrair_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;

            // Act  
            var subtracao = CalculoXUnit.Calculo.Subtrair(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, subtracao,1);
        }


        [Fact]
        [Trait("CalculoUnitTest", "Multiplicar")]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;

            // Act  
            var mult = CalculoXUnit.Calculo.Multiplicar(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }


        [Fact]
        [Trait("CalculoUnitTest", "Dividir")]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94; //Rounded value  

            // Act  
            var div = CalculoXUnit.Calculo.Dividir(num1, num2);

            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, +1, int.MinValue + 1)]
        [Trait("CalculoUnitTest", "Theory")]
        public void Somar_DoisNumerosRelativos_RetornaNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            //Act
            var resultado = CalculoXUnit.Calculo.Somar(num1, num2);

            //Assert
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
