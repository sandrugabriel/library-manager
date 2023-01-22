namespace Library_Book_with_Panel
{
    partial class Mocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-26, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 171);
            this.panel1.TabIndex = 1;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateBook.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateBook.Location = new System.Drawing.Point(158, 92);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(213, 55);
            this.btnCreateBook.TabIndex = 1;
            this.btnCreateBook.Text = "Create New Book";
            this.btnCreateBook.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books";
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.label2);
            this.pnlShow.Controls.Add(this.listView1);
            this.pnlShow.Location = new System.Drawing.Point(12, 175);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(776, 461);
            this.pnlShow.TabIndex = 2;
            this.pnlShow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShow_Paint);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(29, 82);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(703, 344);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Mocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.panel1);
            this.Name = "Mocks";
            this.Text = "Mocks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}