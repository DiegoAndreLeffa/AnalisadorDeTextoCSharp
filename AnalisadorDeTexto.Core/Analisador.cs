namespace AnalisadorDeTexto.Core
{
	public class Analisador : IAnalisadorTexto
	{
		public int ContarPalavras(string texto)
		{
			if (string.IsNullOrWhiteSpace(texto))
				return 0;

			var palavras = texto.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			return palavras.Length;
		}
		
		public Dictionary<string, int> CalcularFrequenciaPalavras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return new Dictionary<string, int>();

            var palavras = texto.ToLower().Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var frequencia = new Dictionary<string, int>();

            foreach (var palavra in palavras)
            {
                if (frequencia.ContainsKey(palavra))
                    frequencia[palavra]++;
                else
                    frequencia[palavra] = 1;
            }

            return frequencia;
        }
    }
}