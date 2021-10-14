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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
            CrearBotones();
        }
        public void CrearBotones()
        {
            int contador = 1;
            for (int contadorFilas = 1; contadorFilas < 4; contadorFilas++)
            {
                for (int contadorColumnas = 0; contadorColumnas < 3; contadorColumnas++, contador++)
                {
                    Button b = new Button
                    {
                        Content = contador,
                        Style = (Style)this.Resources["botones"],

                    };
                    Grid.SetColumn(b, contadorColumnas);
                    Grid.SetRow(b, contadorFilas);
                    grid.Children.Add(b);
                }
            }
        }
    }
}
