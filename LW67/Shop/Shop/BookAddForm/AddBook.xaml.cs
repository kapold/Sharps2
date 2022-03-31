using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Shop.BookAddForm
{
    /// <summary>
    /// Логика взаимодействия для AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        Book Book = new Book();
        public AddBook(string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            this.MinHeight = 450;
            this.MinWidth = 400;
            dateAddForm.DisplayDateEnd = DateTime.Now;
        }

        private void addBook(object sender, RoutedEventArgs e)
        {
            try
            {
                Book.name = nameAddForm.Text;
                Book.author = authorAddForm.Text;
                Book.price = Convert.ToDouble(priceAddForm.Text);
                Book.count = Convert.ToInt32(countAddForm.Text);
                Book.rate = Convert.ToInt32(ratingAddForm.Text);
                Book.year = Convert.ToDateTime(dateAddForm.Text);
                Book.description = descriptionAddForm.Text;
                if(genreAdventureAddForm.IsChecked == true)
                {
                    Book.genre = "Adventure";
                }
                else if(genreDetectiveAddForm.IsChecked == true)
                {
                    Book.genre = "Detective";
                }
                else if (genreFantasyAddForm.IsChecked == true)
                {
                    Book.genre = "Fantasy";
                }
                else if (genreRomanceAddForm.IsChecked == true)
                {
                    Book.genre = "Romance";
                }
                else
                {
                    Book.genre = "";
                }
                Book.ID = MainWindow.mainForm.books.Count;
                MainWindow.mainForm.books.Add(Book);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните все поля или проверьте правильность их заполнения!");
            }
        }

        private void addImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if(fileDialog.ShowDialog() == true)
            {
                Book.imagePath = fileDialog.FileName;
            }
        }
    }
}
