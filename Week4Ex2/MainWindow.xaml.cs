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
using System.Xml;

namespace Week4Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();
            newBook.title = txtTitle.Text;
            newBook.auther = txtAuthor.Text;
            newBook.genre= txtGenre.Text;
            newBook.price= txtPrice.Text;
            newBook.publish_date= txtDate.Text;
            newBook.description= txtDescription.Text;

            var doc = new XmlDocument();
            doc.Load("Books.XML");

            XmlElement book = doc.CreateElement("Book");
            XmlElement title = doc.CreateElement("title");
            title.InnerText = newBook.title;

            XmlElement auth = doc.CreateElement("author");
            auth.InnerText = newBook.auther;
            
            XmlElement genre = doc.CreateElement("genre");
            genre.InnerText = newBook.genre;
            
            XmlElement price = doc.CreateElement("price");
            price.InnerText = newBook.price;
            
            XmlElement date = doc.CreateElement("publish_date");
            date.InnerText = newBook.publish_date;

            XmlElement description = doc.CreateElement("description");
            description.InnerText = newBook.description;

            book.AppendChild(title);
            book.AppendChild(auth);
            book.AppendChild(genre);
            book.AppendChild(price);
            book.AppendChild(date);
            book.AppendChild(description);

            doc.DocumentElement.AppendChild(book);
            doc.Save("Books.XML");

        }
    }
}
