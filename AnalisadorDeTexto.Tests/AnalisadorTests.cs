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

		[Fact]
		public void CalcularFrequenciaPalavras_ComTextoSimples_DeveRetornarFrequenciaCorreta()
		{
			// Arrange
			var analisador = new Analisador();
			var texto = "teste teste é um teste";

			// Act
			var resultado = analisador.CalcularFrequenciaPalavras(texto);

			// Assert
			Assert.Equal(3, resultado["teste"]);
			Assert.Equal(1, resultado["é"]);
			Assert.Equal(1, resultado["um"]);
		}
	}
	
}