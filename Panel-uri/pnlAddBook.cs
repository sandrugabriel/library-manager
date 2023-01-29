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
    internal class pnlAddBook : Panel
    {
        ControllerBooks controllerBooks;

        private Label lblNume;

        private Label lblTile;
        private TextBox txtTile;

        private Label lblAuthor;
        private TextBox txtAuthor;

        private Label lblGenre;
        private TextBox txtGenre;

        private Label lblYear;
        private NumericUpDown numericYear;

        private Button btnAdd;
        private Button btnCancel;

        List<string> erori;
        ControllerBooks controllerCartii;

        Form1 form;

        public pnlAddBook(Form1 a) {

            this.controllerBooks = new ControllerBooks();

            this.Name = "pnlAddBook";
            this.Location = new System.Drawing.Point(10, 0);
            this.Size = new System.Drawing.Size(709, 585);
            this.BringToFront();
            
            //Nume
            this.lblNume = new Label();
            this.Controls.Add(this.lblNume);
            this.lblNume.Text = "Add Book";
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new Font("Arial", 24);
            this.lblNume.Location = new System.Drawing.Point(200, 60);

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
            this.lblTile.Location = new System.Drawing.Point(37, 150);
            this.txtTile.Location = new System.Drawing.Point(135, 150);
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
            this.lblAuthor.Location = new System.Drawing.Point(37, 210);
            this.txtAuthor.Location = new System.Drawing.Point(135, 210);
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
            this.lblGenre.Location = new System.Drawing.Point(37, 270);
            this.txtGenre.Location = new System.Drawing.Point(135, 270);
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
            this.lblYear.Location = new System.Drawing.Point(37, 330);
            this.numericYear.Location = new System.Drawing.Point(135, 330);
            this.numericYear.Font = font1;
            this.numericYear.Maximum = 2500;
            this.numericYear.Minimum = 0;
            this.lblYear.Font = font;
            this.numericYear.Name = "numericAn";
            this.lblYear.Name = "lblAn";

            //BtnAdd
            this.btnAdd = new Button();
            this.Controls.Add(btnAdd);

            this.btnAdd.Location = new System.Drawing.Point(220, 390);
            this.btnAdd.Text = "Add book";
            this.btnAdd.Font = font;
            this.btnAdd.Size = new System.Drawing.Size(160, 50);
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            //BtnCancel
            this.btnCancel = new Button();
            this.Controls.Add(btnCancel);

            this.btnCancel.Location = new System.Drawing.Point(220, 450);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = font;
            this.btnCancel.Size = new System.Drawing.Size(160, 50);
            this.btnCancel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);


            erori = new List<string>();
            controllerCartii = new ControllerBooks();
            form = a;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            verificareErori();

            if (erori.Count > 0)
            {
                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Erori", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                string text = "";
                string nume = txtTile.Text;
                string autor = txtAuthor.Text;
                string genre = txtGenre.Text;
                int an = ((int)numericYear.Value);


                text = controllerCartii.generareId().ToString() + "," + nume + "," + autor + "," + genre + "," + an.ToString();
                controllerCartii.addFisier(text);
                this.form.removePnl("pnlAddBook");
                this.form.Controls.Add(new pnlShow(form));

            }
        }

        public void verificareErori()
        {

            erori.Clear();

            if (txtTile.Text.Equals(""))
            {
                txtTile.Focus();
                erori.Add("You have not entered the title");
            }

            if (txtAuthor.Text.Equals(""))
            {
                txtAuthor.Focus();
                erori.Add("You have not entered the author");
            }

            if (txtGenre.Text.Equals(""))
            {
                txtGenre.Focus();
                erori.Add("You have not entered the genre");
            }

            if (numericYear.Value == 0)
            {

                numericYear.Focus();
                erori.Add("You have not entered year");
            }

        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.form.removePnl("pnlAddBook");
            this.form.Controls.Add(new pnlShow(form));
        }






    }
}
