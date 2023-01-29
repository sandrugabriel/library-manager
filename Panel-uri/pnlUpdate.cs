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
    internal class pnlUpdate:Panel
    {
        private Label lblTile;
        private TextBox txtTile;

        private Label lblAuthor;
        private TextBox txtAuthor;

        private Label lblGenre;
        private TextBox txtGenre;

        private Label lblYear;
        private NumericUpDown numericYear;

        private Button btnCancel;
        private Button btnUpdate;
        private Button btnDelete;

        public int id1;
        private Form1 form;
        ControllerBooks controllerBooks;
        public pnlUpdate(Form1 form1, int id)
        {
            this.controllerBooks = new ControllerBooks();

            this.Name = "pnlUpdate";
            this.Location = new System.Drawing.Point(10, 135);
            this.Size = new System.Drawing.Size(709, 485);


            //Nume
            this.lblTile = new Label();
            this.txtTile = new TextBox();
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.txtTile);

            Font font = new Font("Arial", 17);
            Font font1 = new Font("Arial", 14);

            this.lblTile.Text = "Title";
            this.lblTile.Font = font;
            this.lblTile.AutoSize = true;
            this.lblTile.Size = new System.Drawing.Size(125, 20);
            this.lblTile.Location = new System.Drawing.Point(37, 25);
            this.txtTile.Location = new System.Drawing.Point(135, 25);
            this.txtTile.Font = font1;
            this.txtTile.Size = new System.Drawing.Size(160, 50);
            this.txtTile.Name = "txtTile";
            this.lblTile.Name = "lblNume";

            //Autor
            this.lblAuthor = new Label();
            this.txtAuthor = new TextBox();
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);

            this.lblAuthor.Text = "Author";
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Size = new System.Drawing.Size(125, 20);
            this.lblAuthor.Location = new System.Drawing.Point(37, 80);
            this.txtAuthor.Location = new System.Drawing.Point(135, 80);
            this.txtAuthor.Size = new System.Drawing.Size(160, 50);
            this.txtAuthor.Font = font1;
            this.lblAuthor.Font = font;
            this.txtAuthor.Name = "txtAutor";
            this.lblAuthor.Name = "lblAutor";

            //Genre
            this.lblGenre = new Label();
            this.txtGenre = new TextBox();
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);

            this.lblGenre.Text = "Genre";
            this.lblGenre.AutoSize = true;
            this.lblGenre.Size = new System.Drawing.Size(125, 20);
            this.lblGenre.Location = new System.Drawing.Point(37, 140);
            this.txtGenre.Location = new System.Drawing.Point(135, 140);
            this.txtGenre.Size = new System.Drawing.Size(160, 50);
            this.txtGenre.Font = font1;
            this.lblGenre.Font = font;
            this.txtGenre.Name = "txtAuthor";
            this.lblGenre.Name = "lblAutor";

            //Anul
            this.lblYear = new Label();
            this.numericYear = new NumericUpDown();
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.numericYear);

            this.lblYear.Text = "Year";
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(37, 190);
            this.numericYear.Location = new System.Drawing.Point(135, 190);
            this.numericYear.Font = font1;
            this.numericYear.Maximum = 2500;
            this.numericYear.Minimum = 0;
            this.lblYear.Font = font;
            this.numericYear.Name = "numericAn";
            this.lblYear.Name = "lblAn";

            //BtnUpdate
            this.btnUpdate = new Button();
            this.Controls.Add(btnUpdate);

            this.btnUpdate.Location = new System.Drawing.Point(220, 240);
            this.btnUpdate.Text = "Update book";
            this.btnUpdate.Font = font;
            this.btnUpdate.Size = new System.Drawing.Size(160, 50);
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.Click += new EventHandler(btnUpdate_Click);

            //BtnDelete
            this.btnDelete = new Button();
            this.Controls.Add(btnDelete);

            this.btnDelete.Location = new System.Drawing.Point(220, 300);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Font = font;
            this.btnDelete.Size = new System.Drawing.Size(160, 50);
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.Click += new EventHandler(btnDelete_Click);

            //BtnCancel
            this.btnCancel = new Button();
            this.Controls.Add(btnCancel);

            this.btnCancel.Location = new System.Drawing.Point(220, 350);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = font;
            this.btnCancel.Size = new System.Drawing.Size(160, 50);
            this.btnCancel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            form = form1;
            id1 = id;
            txtTile.Text = controllerBooks.getNumeById(id1);
            txtAuthor.Text = controllerBooks.getAuthorById(id1);
            txtGenre.Text = controllerBooks.getGenerById(id1);
            numericYear.Value = controllerBooks.getYearById(id1);
            

        }

        public void btnCancel_Click(object sender, EventArgs e)
        {

            this.form.removePnl("pnlUpdate");
            this.form.Controls.Add(new pnlShow(form));

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {

           int id = id1;

           controllerBooks.deleteCarte(id);
            this.form.removePnl("pnlUpdate");
            this.form.Controls.Add(new pnlShow(form));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = id1;

            controllerBooks.setNume(id, txtTile.Text);
            controllerBooks.setAutor(id, txtAuthor.Text);
            controllerBooks.setGenre(id, txtGenre.Text);
            controllerBooks.setAn(id, ((int)numericYear.Value));
            controllerBooks.save();

            this.form.removePnl("pnlUpdate");
            this.form.Controls.Add(new pnlShow(form));

        }

    }
}
