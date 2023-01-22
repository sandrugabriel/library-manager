using Library_Book_with_Panel.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Book_with_Panel.Panel_uri
{
    internal class pnlShow:Panel
    {
        private ListView lstBooks;

        private Label lblInfo;

        ControllerBooks controllerBooks;
        public pnlShow()
        {
            this.controllerBooks = new ControllerBooks();

            this.Name = "pnlShow";
            this.Location = new System.Drawing.Point(10, 135);
            this.Size = new System.Drawing.Size(709, 485);
            this.BackColor = System.Drawing.Color.Transparent;


            //lstBooks
            this.lstBooks = new ListView();
            this.Controls.Add(lstBooks);
            this.controllerBooks.createTable(lstBooks);
            this.lstBooks.View = View.Details;
            this.lstBooks.Location = new System.Drawing.Point(32,25);
            this.lstBooks.Size = new System.Drawing.Size(484, 350);
            FontStyle fontStyle = FontStyle.Regular;
            Font font = new Font("Microsoft YaHei UI", 12, fontStyle);
            this.lstBooks.Font = font;
            this.lstBooks.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstBooks.GridLines= true;
            

            //lblInfo
            this.lblInfo = new Label();
            this.Controls.Add(lblInfo);
            this.lblInfo.Text = "Click on the title to change the data or delete";
            this.lblInfo.Font = font;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(32, 0);








        }



    }
}
