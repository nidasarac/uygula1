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

namespace uygula1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bilgi bilgi;
        public MainWindow()
        {
            InitializeComponent();
            bilgi = new Bilgi();
        }

        private void BtnKelimeCikar_Click(object sender, RoutedEventArgs e)
        {
            if (tbMetin.Text!=string.Empty)
            {
                bilgi.KelimeCikar(tbMetin.Text);
                LbKelimeler.ItemsSource = bilgi.KelimeAl();
            }
        }

        private void BtnHarfCikar_Click(object sender, RoutedEventArgs e)
        {
            if (tbMetin.Text != string.Empty)
            {
                bilgi.HarfCikar(tbMetin.Text);
                LbHarfler.ItemsSource = bilgi.HarfAl();
            }           
        }

        private void BtnKelimeAra_Click(object sender, RoutedEventArgs e)
        {
            if (tbMetin.Text != string.Empty)
            {
                LbKelimeler.ItemsSource = bilgi.KelimeAra(tbMetin.Text);
            }
            else
            {
                LbKelimeler.ItemsSource = bilgi.KelimeAl();
            }
        }

        private void BtnHarfAra_Click(object sender, RoutedEventArgs e)
        {
            if (tbMetin.Text.Length == 1)
            {
                char aranan = Convert.ToChar(tbMetin.Text);
                LbHarfler.ItemsSource = bilgi.HarfAra(aranan);
            }
            else if (tbMetin.Text.Length > 1)
            {
                MessageBox.Show("Arama için tek harf girilmesi gerekmektedir.");
            }
            else
            {
                LbHarfler.Items.Clear();
                LbHarfler.ItemsSource = bilgi.HarfAl();
            }
        }
    }
}
