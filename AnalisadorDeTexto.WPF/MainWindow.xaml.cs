using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using AnalisadorDeTexto.Core;

namespace AnalisadorDeTexto.WPF
{
    public partial class MainWindow : Window
    {
        private readonly IAnalisadorTexto _analisador;

        public MainWindow()
        {
            InitializeComponent();
            _analisador = new Analisador();
        }

        private void Analisar_Click(object sender, RoutedEventArgs e)
        {
            var texto = TextoEntrada.Text;
            var numeroPalavras = _analisador.ContarPalavras(texto);
            var frequencia = _analisador.CalcularFrequenciaPalavras(texto);

            // Por enquanto, vamos apenas exibir em uma MessageBox
            MessageBox.Show($"Número de palavras: {numeroPalavras}");
        }
    }
}