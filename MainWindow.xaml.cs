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

namespace GithubRekenen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(txtDividend.Text, out double dividend) &&
                Double.TryParse(txtDivisor.Text, out double divisor))
            {
                lblResultDivision.Content =
                    $"The quotient is {Math.Round(dividend / divisor, 5)}";
            }
            else
            {
                MessageBox.Show("Invalid numbers supplied");
            }
        }
    }
}
