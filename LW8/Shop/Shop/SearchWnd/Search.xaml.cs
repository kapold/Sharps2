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
using System.IO;
using System.Windows.Shapes;

namespace Shop.Search
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        private static string libraryPath =
            System.IO.Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\library.xml");

        public Search(string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            this.MinHeight = 450;
            this.MinWidth = 400;
        }

        public void ShowBooks(List<Book> list) // Выводим коллецию книг
        {
            searchListBox.ItemsSource = null;
            searchListBox.ItemsSource = list;
        }

        public void SearchPriceRange(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(fromTextBox.Text) || String.IsNullOrEmpty(toTextBox.Text))
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                double fromPrice = Convert.ToDouble(fromTextBox.Text);
                double toPrice = Convert.ToDouble(toTextBox.Text);
                List<Book> serializedBooks = new List<Book>();
                serializedBooks = XmlSerialize.Deserialize(libraryPath);
                List<Book> searchedPrice = new List<Book>();
                searchedPrice = serializedBooks.Where(b => b.price > fromPrice && b.price < toPrice).ToList();
                ShowBooks(searchedPrice);
            }
        }
    }
}
