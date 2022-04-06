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
    /// Логика взаимодействия для RandomBookUC.xaml
    /// </summary>
    public partial class RandomBookUC : UserControl
    {
        public static string libraryPath =
            System.IO.Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\library.xml");
        public RandomBookUC()
        {
            InitializeComponent();
            randomBookList.ItemsSource = null;
        }

        private void GenerateBook(Object sender, RoutedEventArgs e)
        {
            List<Book> books = XmlSerialize.Deserialize(libraryPath);
            List<Book> randomBook = new List<Book>();
            Random random = new Random();
            randomBook.Add(books[random.Next(0, books.Count)]);

            randomBookList.ItemsSource = randomBook;
        }
    }
}
