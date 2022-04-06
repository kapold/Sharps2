using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop.SearchNameWnd
{
    /// <summary>
    /// Логика взаимодействия для SearchName.xaml
    /// </summary>
    public partial class SearchName : Window
    {
        public static string libraryPath =
            System.IO.Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\library.xml");
        public void ShowBooks(List<Book> list) // Выводим коллецию книг
        {
            searchListBox.ItemsSource = null;
            searchListBox.ItemsSource = list;
        }
        public SearchName(string languagePath)
        {
            InitializeComponent();

            this.MinHeight = 450;
            this.MinWidth = 400;

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void SearchByName(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(searchNameTextBox.Text);

            List<Book> serializedBooks = new List<Book>();
            serializedBooks = XmlSerialize.Deserialize(libraryPath);
            List<Book> searchedByName = new List<Book>();
            foreach(Book book in serializedBooks)
            {
                if(regex.IsMatch(book.name))
                {
                    searchedByName.Add(book);
                }
            }

            if(searchedByName.Count > 0)
            {
                ShowBooks(searchedByName);
            }
            else
            {
                searchListBox.ItemsSource = null;
            }
        }
    }
}
