using MerchandiseShop.Controller;
using MerchandiseShop.Model;
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

namespace MerchandiseShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller oxobz;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangMerch = new Bucket(5);
            BucketController bucketController = new BucketController(keranjangMerch, this);

            oxobz = new Seller("oxobz", bucketController);

            ListBoxBucket.ItemsSource = keranjangMerch.findAll();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Merch poster1 = new Merch("Poster 1");
            oxobz.addMerch(poster1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Merch poster2 = new Merch("Poster 2");
            oxobz.addMerch(poster2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Merch keychain = new Merch("Keychain");
            oxobz.addMerch(keychain);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Merch sacoche = new Merch("Sacoche");
            oxobz.addMerch(sacoche);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            oxobz.removeMerch((Merch)ListBoxBucket.SelectedItem);
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }
    }
}
