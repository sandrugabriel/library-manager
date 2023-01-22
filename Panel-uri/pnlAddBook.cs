using Library_Book_with_Panel.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_with_Panel.Panel_uri
{
    internal class pnlAddBook:Panel
    {
        ControllerBooks controllerBooks;

        private Label lblTile;
        private TextBox txtTile;

        private Label lblAuthor;
        private TextBox txtAuthor;

        private Label lblGenre;
        private TextBox txtGenre;

        private Label lblYear;
        private NumericUpDown numericYear;

        private Button btnAdd;
        private Button btnRemove;
        private Button btnCancel;

        public pnlAddBook() { 
          
            this.controllerBooks = new ControllerBooks();

            this.Name = "pnlAddBook";
            this.Location = new System.Drawing.Point(10, 135);
            this.Size = new System.Drawing.Size(709, 485);
        
           
        
        
        
        
        
        
        
        
        
        }










    }
}
