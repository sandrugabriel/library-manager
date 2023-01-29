using Library_Book_with_Panel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            listBooks.Columns.Add("Title", 180, HorizontalAlignment.Left);
            listBooks.Columns.Add("Author", 180,HorizontalAlignment.Left); 
            listBooks.Columns.Add("Genre",180,HorizontalAlignment.Left);
            listBooks.Columns.Add("Year", 70, HorizontalAlignment.Left);

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

        public Book getID(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {

                if (id == books[i].getId())
                {
                    return books[i];
                }
            }

            return null;
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();

            while (this.getID(id) != null)
            {
                id = random.Next();
            }

            return id;

        }

        public void addFisier(string textul)
        {
            String path = Application.StartupPath + @"/data/books.txt";
            string text = textul;
            File.AppendAllText(path, text + "\n");

        }

        public int getIdByNume(string nume)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getTitle().Equals(nume))
                {
                    return books[i].getId();
                }
            }

            return -1;
        }

        public string getNumeById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getTitle();
                }
            }

            return null;
        }

        public string getAuthorById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getAuthor();
                }
            }

            return null;
        }

        public string getGenerById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getGenre();
                }
            }

            return null;
        }

        public int getYearById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getYear();
                }
            }

            return -1;
        }

        public int pozID(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozID(id);
            if(p==pozID(id))
            books.RemoveAt(p);

        }

        public void deleteCarte(int id)
        {
            this.stergere(id);
            
            string path = Application.StartupPath + @"/data/books.txt";
            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

        public void setNume(int id, string nume)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setTitle(nume);
                }
            }


        }

        public void setAutor(int id, string autor)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setAuthor(autor);
                }
            }


        }

        public void setGenre(int id, string genre)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setGenre(genre);
                }
            }


        }

        public void setAn(int id, int an)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setYear(an);
                }
            }


        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < books.Count; i++)
            {
                t += books[i].toSave() + "\n";
            }

            return t;
        }

        public void save()
        {
            String path = Application.StartupPath + @"/data/books.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }


    }
}
