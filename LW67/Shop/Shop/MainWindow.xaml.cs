using Shop.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Resources;

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        // Нужные переменные
        public static MainWindow mainForm;
        public static string libraryPath =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\library.xml");
        public static string testLibraryPath =
            Path.GetFullPath(@"D:\Универ 2 курс\Университет 4 семестр\ООП\Лабораторные работы\LW67\Shop\Shop\testLibrary.xml");
        public List<Book> books = new List<Book>();
        public string languagePath = "LanguageSelector/ru-RU.xaml";

        public string priceSortType = "ASC";
        public string countSortType = "ASC";

        List<Book> selectionList = new List<Book>(); // Лист выборки
        List<Book> booksList = new List<Book>();
        private bool isSelected = false;
        //
        public MainWindow() // Главное окно
        {
            InitializeComponent();

            DataContext = new ApplicationsViewModel();
            mainForm = this;


            StreamResourceInfo sri = Application.GetResourceStream(new Uri("Images/CursorBlack.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;

            this.MinHeight = 450;
            this.MinWidth = 800;
            this.Width = 1000;
            this.Height = 700;

            ResourceDictionary language = new ResourceDictionary();
            languagePath = "LanguageSelector/ru-RU.xaml";
            language.Source = new Uri(languagePath, UriKind.Relative);
        }

        public void ShowBooksList(List<Book> list) // Выводим коллецию книг
        {
            booksListBox.ItemsSource = null;
            booksListBox.ItemsSource = list;
        }

        public void AddBook(object sender, RoutedEventArgs e) // Добавляем книгу
        {
            addBook.Command = ApplicationCommands.New;

            BookAddForm.AddBook addNewBook = new BookAddForm.AddBook(languagePath);
            addNewBook.Show();
        }

        public void SaveInXML() // Загрузка в ХМЛ
        {
            XmlSerialize.Serialize(books, libraryPath);
        }

        public void LoadFromXML() // Выгрузка из ХМЛ
        {
            booksListBox.ItemsSource = null;
            selectionListBox.ItemsSource = null;
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            booksList = XmlSerialize.Deserialize(libraryPath);
            selectionList = XmlSerialize.Deserialize(libraryPath);

            ShowBooksList(serializedBooks);
        }

        public void SwitchLanguageRussian() // Меняем язык на русский
        {
            languagePath = "LanguageSelector/ru-RU.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void SwitchLanguageEng() // Меняем язык на англ
        {
            languagePath = "LanguageSelector/eu-US.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void PriceSort()
        {
            List<Book> serializedBooks = new List<Book>();
            serializedBooks = XmlSerialize.Deserialize(libraryPath);
            List<Book> sortedByPrice = new List<Book>();
            if(priceSortType == "ASC")
            {
                sortedByPrice = serializedBooks.OrderBy(b => b.price).ToList();
                priceSortType = "DESC";
            }
            else if(priceSortType == "DESC")
            {
                sortedByPrice = serializedBooks.OrderByDescending(b => b.price).ToList();
                priceSortType = "ASC";
            }

            ShowBooksList(sortedByPrice);
        }

        public void CountSort()
        {
            List<Book> serializedBooks = new List<Book>();
            serializedBooks = XmlSerialize.Deserialize(libraryPath);
            List<Book> sortedByCount = new List<Book>();
            if (countSortType == "ASC")
            {
                sortedByCount = serializedBooks.OrderBy(b => b.count).ToList();
                countSortType = "DESC";
            }
            else if (countSortType == "DESC")
            {
                sortedByCount = serializedBooks.OrderByDescending(b => b.count).ToList();
                countSortType = "ASC";
            }

            ShowBooksList(sortedByCount);
        }

        public void DeleteCount(object sender, RoutedEventArgs e)
        {
            string h = e.Source.ToString().Last().ToString();
            int z = Convert.ToInt32(h);
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);

            if(serializedBooks[z].count > 0)
            {
                serializedBooks[z].count = serializedBooks[z].count - 1;
            }

            ShowBooksList(serializedBooks);
            XmlSerialize.Serialize(serializedBooks, libraryPath);
        }

        // TODO: do change
        public void ChangeCurrentBook(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(e.Source.ToString().Last().ToString());
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            ChangeBook.Change change = new ChangeBook.Change(serializedBooks[index]);
            change.Show();
        }

        public void GetBookInfo(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(e.Source.ToString().Last().ToString());
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            DescriptionWnd.BookDescription bookDescription = new DescriptionWnd.BookDescription(serializedBooks[index]);
            bookDescription.Show();
        }

        // Жанры
        public void GenreDetectiveSelection(object sender, RoutedEventArgs e)
        {
            selectionListBox.ItemsSource = null;
            if(isSelected)
            {
                selectionList = selectionList.Where(b => b.genre == "Detectvie").ToList();
            }
            else if(!isSelected)
            {
                selectionList = booksList.Where(b => b.genre == "Detectvie").ToList();
                isSelected = true;
            }
            selectionListBox.ItemsSource = selectionList;
        }

        public void GenreRomanceSelection(object sender, RoutedEventArgs e)
        {
            selectionListBox.ItemsSource = null;
            if (isSelected)
            {
                selectionList = selectionList.Where(b => b.genre == "Romance").ToList();
            }
            else if (!isSelected)
            {
                selectionList = booksList.Where(b => b.genre == "Romance").ToList();
                isSelected = true;
            }
            selectionListBox.ItemsSource = selectionList;
        }

        public void GenreAdventureSelection(object sender, RoutedEventArgs e)
        {
            selectionListBox.ItemsSource = null;
            if (isSelected)
            {
                selectionList = selectionList.Where(b => b.genre == "Adventure").ToList();
            }
            else if (!isSelected)
            {
                selectionList = booksList.Where(b => b.genre == "Adventure").ToList();
                isSelected = true;
            }
            selectionListBox.ItemsSource = selectionList;
        }

        public void GenreFantasySelection(object sender, RoutedEventArgs e)
        {
            selectionListBox.ItemsSource = null;
            if (isSelected)
            {
                selectionList = selectionList.Where(b => b.genre == "Fantasy").ToList();
            }
            else if (!isSelected)
            {
                selectionList = booksList.Where(b => b.genre == "Fantasy").ToList();
                isSelected = true;
            }
            selectionListBox.ItemsSource = selectionList;
        }

        public void PriceSelection(object sender, RoutedEventArgs e)
        {
            selectionListBox.ItemsSource = null;
            if (isSelected)
            {
                selectionList = selectionList.OrderBy(b => b.price).ToList();
            }
            else if (!isSelected)
            {
                selectionList = booksList.OrderBy(b => b.price).ToList();
                isSelected = true;
            }
            selectionListBox.ItemsSource = selectionList;
        }
    }
}