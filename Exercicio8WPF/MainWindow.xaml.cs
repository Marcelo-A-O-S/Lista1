using Exercicio8WPF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicio8WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextDistancia_TextChanged(object sender, TextChangedEventArgs e)
        {
         
            
            
        }

        private void Acao_Click(object sender, RoutedEventArgs e)
        {
            Metro metro = new Metro();
            metro.metro = float.Parse(TextDistancia.Text);
            var obj = metro.distancia(metro);
            Dados.Items.Add(obj);
            
        }
    }
}
