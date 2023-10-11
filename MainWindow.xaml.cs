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
using System.Xml.XPath;

namespace eventigrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numeroanterior;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumeroBoton_click(object sender, RoutedEventArgs e)
        {
            int valorSeleccionat = int.Parse((sender as Button).Content.ToString());

            if(resultadolabel.Content.ToString() == "0")
            {
                resultadolabel.Content = valorSeleccionat.ToString();
            }
            else
            {
                resultadolabel.Content = $"{resultadolabel.Content}{valorSeleccionat}";
                
            }
        }
       

        private void negativo_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadolabel.Content.ToString(), out numeroanterior))
            {
                numeroanterior = numeroanterior * -1;
                resultadolabel.Content = numeroanterior.ToString();
            }
        }

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            resultadolabel.Content = "0";
        }

        private void porcentaje_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadolabel.Content.ToString(), out numeroanterior))
            {
                numeroanterior = numeroanterior / 100;
                resultadolabel.Content = numeroanterior.ToString();
            }
        }


    }
}
