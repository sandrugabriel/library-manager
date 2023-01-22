using Library_Book_with_Panel.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_with_Panel
{
    public partial class Mocks : Form
    {
        ControllerBooks controllerBooks;
        public Mocks()
        {
            InitializeComponent();
            controllerBooks = new ControllerBooks();    
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {
            this.controllerBooks.createTable(listView1);
        }
    }
}
