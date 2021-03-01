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
