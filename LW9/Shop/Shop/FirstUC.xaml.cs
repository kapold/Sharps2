using Shop.Classes;
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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для FirstUC.xaml
    /// </summary>
    public partial class FirstUC : UserControl
    {
        public FirstUC()
        {
            InitializeComponent();
        }

        public void GetPriceDP(object sender, RoutedEventArgs e)
        {
            Vocabulary vocabulary = (Vocabulary)this.Resources["firstVocabulary"]; // получаем ресурс по ключу
            string voc = $"Title Name: {vocabulary.Title.ToString()}\n" +
                         $"Current Price: {vocabulary.Price.ToString()}";
            MessageBox.Show(voc);
        }
    }
}
