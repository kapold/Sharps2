using System;
using System.Collections;
using System.Windows.Media;

// Продукт - книга
namespace Shop
{
    [Serializable]
    public class Book
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public string genre { get; set; }
        public int rate { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        public DateTime? year { get; set; }

        public Book() { }

        public Book(string name, string author, float price, int count, string genre, string description)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.count = count;
            this.genre = genre;
            this.description = description;
        }

    }
}