using Library_Book_with_Panel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_with_Panel.Controllers
{
    internal class ControllerBooks
    {

        List<Book> books;

        public ControllerBooks() { 
        
            books = new List<Book>();

            load();

        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/books.txt";

            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {
                Book a = new Book(text);

                books.Add(a);
            }

            streamReader.Close();
        }

        public void createTable(ListView listBooks)
        {
            listBooks.Columns.Add("Title", 150, HorizontalAlignment.Left);
            listBooks.Columns.Add("Author", 150,HorizontalAlignment.Left); 
            listBooks.Columns.Add("Genre",120,HorizontalAlignment.Left);
            listBooks.Columns.Add("Year", 60, HorizontalAlignment.Left);

            foreach(Book book in books)
            {
                ListViewItem list = new ListViewItem();

                list.Text = book.getTitle();
                list.SubItems.Add(book.getAuthor());
                list.SubItems.Add(book.getGenre());
                list.SubItems.Add(book.getYear().ToString());

                listBooks.Items.Add(list);
            }

        }





    }
}
