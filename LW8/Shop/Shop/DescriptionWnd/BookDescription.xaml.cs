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

namespace Shop.DescriptionWnd
{
    /// <summary>
    /// Логика взаимодействия для BookDescription.xaml
    /// </summary>
    public partial class BookDescription : Window
    {
        public BookDescription(Book book)
        {
            InitializeComponent();

            if (book.imagePath != null)
            {
                descriptionImage.Source = new BitmapImage(new Uri(book.imagePath));
            }
            descriptionBlock.Text = book.description;
            descriptionName.Text = book.name;
            descriptionAuthor.Text = book.author;
            descriptionGenre.Text = book.genre;

            priceDesc.Text = book.price.ToString();
            countDesc.Text = book.count.ToString();
            ratingDesc.Text = book.rate.ToString();
            yearDesc.Text = book.year.ToString();
        }
    }
}
