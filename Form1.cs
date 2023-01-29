using Library_Book_with_Panel.Panel_uri;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new pnlShow(this));
        }

        public void removePnl(string pnl)
        {
            Control control=null;

            foreach(Control control1 in this.Controls) { 
            
                if(control1.Name.Equals(pnl))
                {
                    control=control1;
                }

            }

            this.Controls.Remove(control);
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new pnlAddBook(this));
            removePnl("pnlShow");
        }
    }
}
