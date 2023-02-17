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

namespace Week4Ex1
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


            var xmlDocument = new XmlDocument();
            xmlDocument.Load("Books.XML");
            XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                TbXmlData.Text += "book Title: " + xmlNode.SelectSingleNode("title").InnerText;
                TbXmlData.Text += " - ";
                TbXmlData.Text += "Book Auther: " + xmlNode.SelectSingleNode("author").InnerText;
                TbXmlData.Text += " - ";
                TbXmlData.Text += "Book genre: " + xmlNode.SelectSingleNode("genre").InnerText;
                TbXmlData.Text += " - ";
                TbXmlData.Text += "Book price: " + xmlNode.SelectSingleNode("price").InnerText;
                TbXmlData.Text += " - ";
                TbXmlData.Text += "Book publish date: " + xmlNode.SelectSingleNode("publish_date").InnerText;
                TbXmlData.Text += " \n ";
                TbXmlData.Text += "Book description:  \n ";
                TbXmlData.Text += xmlNode.SelectSingleNode("description").InnerText;
                TbXmlData.Text += " \n ";
                TbXmlData.Text += " ------------------------------------------------------";
                TbXmlData.Text += " \n ";

            }

        }
    }
}
