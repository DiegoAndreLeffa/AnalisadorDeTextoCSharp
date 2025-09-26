using AnalisadorDeTexto.Core;
using Xunit;

namespace AnalisadorDeTexto.Tests
{
    public class AnalisadorTests
    {
        [Fact]
        public void ContarPalavras_ComTextoSimples_DeveRetornarNumeroCorreto()
        {
            var analisador = new Analisador();
            var texto = "Este é um texto de teste.";

            var resultado = analisador.ContarPalavras(texto);

            Assert.Equal(6, resultado);
        }
    }
}