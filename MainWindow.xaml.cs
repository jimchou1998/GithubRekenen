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
            clearMultiply();
        }


        private void multiply()
        {
            int result = Convert.ToInt32(txtmulti1.Text) * Convert.ToInt32(txtmulti2.Text);

            lblMultiplyResult.Content = result;
        }

        private void clearMultiply()
        {
            txtmulti1.Text = string.Empty;
            txtmulti2.Text = string.Empty;
            lblMultiplyResult.Content = string.Empty;
        }
        private void btnmultiply_Click(object sender, RoutedEventArgs e)
        {
            clearMultiply();
            multiply();
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

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = 12;
            int getal2 = 7;

            lblResultMinus.Content = getal1 - getal2;
        }

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            int grondtal = Convert.ToInt32(txtGrondtal.Text);
            int huidigGetal = 1;
            for (int i = 0; i < Convert.ToInt32(txtExponent.Text); i++)
            {
                huidigGetal = huidigGetal * grondtal;
            }
            lblResultaat.Content = huidigGetal;
        }
    }
}
