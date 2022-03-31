using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Shop.ChangeBook
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change : Window
    {
        Book currentBook = new Book();
        private MainWindow mainWnd = new MainWindow();
        private int CurrentID = 0;
        public static string libraryPath =
           System.IO.Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\library.xml");
        public string languagePath = "LanguageSelector/ru-RU.xaml";
        public Change(Book book)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            this.MinHeight = 450;
            this.MinWidth = 400;
            CurrentID = book.ID;

            // Current book
            nameChange.Text = book.name;
            authorChange.Text = book.author;
            priceChange.Text = Convert.ToString(book.price);
            countChange.Text = Convert.ToString(book.count);
            descriptionChange.Text = Convert.ToString(book.description);
            dateChange.Text = Convert.ToString(book.year);
            ratingChange.Text = Convert.ToString(book.rate);
            currentBook.imagePath = book.imagePath;
            if (book.genre == "Adventure")
            {
                genreAdventureChange.IsChecked = true;
            }
            else if (book.genre == "Detective")
            {
                genreDetectiveChange.IsChecked = true;
            }
            else if (book.genre == "Fantasy")
            {
                genreFantasyChange.IsChecked = true;
            }
            else if (book.genre == "Romance")
            {
                genreRomanceChange.IsChecked = true;
            }
        }

        public void changeBook(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Book> books = XmlSerialize.Deserialize(libraryPath);

                books[CurrentID].name = nameChange.Text;
                books[CurrentID].author = authorChange.Text;
                books[CurrentID].price = Convert.ToDouble(priceChange.Text);
                books[CurrentID].count = Convert.ToInt32(countChange.Text);
                books[CurrentID].rate = Convert.ToInt32(ratingChange.Text);
                books[CurrentID].year = Convert.ToDateTime(dateChange.Text);
                books[CurrentID].description = descriptionChange.Text;
                if (genreAdventureChange.IsChecked == true)
                {
                    books[CurrentID].genre = "Adventure";
                }
                else if (genreDetectiveChange.IsChecked == true)
                {
                    books[CurrentID].genre = "Detective";
                }
                else if (genreFantasyChange.IsChecked == true)
                {
                    books[CurrentID].genre = "Fantasy";
                }
                else if (genreRomanceChange.IsChecked == true)
                {
                    books[CurrentID].genre = "Romance";
                }

                File.Delete(libraryPath);
                XmlSerialize.Serialize(books, libraryPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
        }

        private void changeImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (fileDialog.ShowDialog() == true)
            {
                currentBook.imagePath = fileDialog.FileName;
            }
        }
    }
}
