using Shop.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Resources;
using Shop.ChangeBook;
using Shop.Classes;

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
        public List<Book> books = new List<Book>();
        public string languagePath;
        public string stylePath;

        // Порядок сортировки
        public string priceSortType = "ASC";
        public string countSortType = "ASC";

        List<Book> selectionList = new List<Book>(); // Лист выборки
        List<Book> booksList = new List<Book>(); // Доп лист для выборки
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

            ResourceDictionary style = new ResourceDictionary();
            stylePath = "StyleSelector/Cornsilk_Pink.xaml";
            style.Source = new Uri(stylePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(style);

            LoadFromXML();

            State.redoBooks.Push(booksList);
        }

        // Вывод коллеции книг
        public void ShowBooksList(List<Book> list) 
        {
            booksListBox.ItemsSource = null;
            booksListBox.ItemsSource = list;
            isSelected = false;
        }

        // Загрузка/выгрузка XML
        public void SaveInXML() 
        {
            XmlSerialize.Serialize(books, libraryPath);
        }

        public void LoadFromXML() 
        {
            booksListBox.ItemsSource = null;
            selectionListBox.ItemsSource = null;
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            booksList = XmlSerialize.Deserialize(libraryPath);
            selectionList = XmlSerialize.Deserialize(libraryPath);

            ShowBooksList(serializedBooks);
        }

        // Смена языка
        public void SwitchLanguageRussian() 
        {
            languagePath = "LanguageSelector/ru-RU.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void SwitchLanguageEng() 
        {
            languagePath = "LanguageSelector/eu-US.xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        // Сортировка
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

        // Управление книгой
        private void DeleteCount(object sender, RoutedEventArgs e)
        {
            string h = e.Source.ToString().Last().ToString();
            int z = Convert.ToInt32(h);
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);

            if (serializedBooks[z].count > 0)
            {
                serializedBooks[z].count--;
            }

            ShowBooksList(serializedBooks);
            XmlSerialize.Serialize(serializedBooks, libraryPath);
        }

        private void ChangeCurrentBook(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(e.Source.ToString().Last().ToString());
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            ChangeBook.Change change = new ChangeBook.Change(serializedBooks[index]);
            change.Show();
        }

        private void GetBookInfo(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(e.Source.ToString().Last().ToString());
            List<Book> serializedBooks = XmlSerialize.Deserialize(libraryPath);
            DescriptionWnd.BookDescription bookDescription = new DescriptionWnd.BookDescription(serializedBooks[index]);
            bookDescription.Show();
        }

        // Жанры
        private void GenreDetectiveSelection(object sender, RoutedEventArgs e)
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

        private void GenreRomanceSelection(object sender, RoutedEventArgs e)
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

        private void GenreAdventureSelection(object sender, RoutedEventArgs e)
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

        private void GenreFantasySelection(object sender, RoutedEventArgs e)
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

        // Выборка
        private void PriceSelection(object sender, RoutedEventArgs e)
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

        // Смена стилей
        public void SetCornsilkStyle()
        {
            stylePath = "StyleSelector/Cornsilk_Pink.xaml";
            ResourceDictionary style = new ResourceDictionary();
            style.Source = new Uri(stylePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(style);
        }

        public void SetBlackStyle()
        {
            stylePath = "StyleSelector/Black_White.xaml";
            ResourceDictionary style = new ResourceDictionary();
            style.Source = new Uri(stylePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(style);
        }
        
        // Вперед/Назад
        
        public void RedoB()
        {
            if(State.undoBooks.Count > 0)
            {
                State.redoBooks.Push(State.undoBooks.Peek());
                ShowBooksList(State.undoBooks.Pop());
                XmlSerialize.Serialize(State.redoBooks.Peek(), libraryPath);
            }
        }

        public void UndoB()
        {
            if (State.redoBooks.Count <= 1)
            {
                ShowBooksList(State.redoBooks.Peek());
            }
            else if(State.redoBooks.Count > 1)
            {
                State.undoBooks.Push(State.redoBooks.Pop());
                ShowBooksList(State.redoBooks.Peek());
                XmlSerialize.Serialize(State.redoBooks.Peek(), libraryPath);
            }
        }

        // RoutedEvent

        private void OpenRoutedEvent(object sender, RoutedEventArgs e)
        {
            RoutedEventsWnd routedEventsWindow = new RoutedEventsWnd();
            routedEventsWindow.Show();
        }

        private void ExitCommand(object sender, RoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToLongDateString() + " " +
                                                           DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }
    }
}