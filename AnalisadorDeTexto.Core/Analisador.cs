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
    }
}