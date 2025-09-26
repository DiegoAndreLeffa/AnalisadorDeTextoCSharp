namespace AnalisadorDeTexto.Core
{
	public interface IAnalisadorTexto
	{
		int ContarPalavras(string texto);
		Dictionary<string, int> CalcularFrequenciaPalavras(string texto);
    }
}