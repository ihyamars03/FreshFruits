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
using FreshFruits.Model;
using FreshFruits.Controller;

namespace FreshFruits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller toni;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            toni = new Seller("toni", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruits anggur = new Fruits("Anggur");
            toni.addFruit(anggur);
        }

 private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruits Apel = new Fruits("Apel");
            toni.addFruit(Apel);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruits Pisang = new Fruits("Pisang");
            toni.addFruit(Pisang);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruits jeruk = new Fruits("Jeruk");
            toni.addFruit(jeruk);
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
