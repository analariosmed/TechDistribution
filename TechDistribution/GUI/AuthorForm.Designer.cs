﻿namespace TechDistribution.GUI
{
    partial class AuthorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddBook = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBook = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIDUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUpdateEmail = new System.Windows.Forms.TextBox();
            this.textBoxUpdateLastName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBy = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListBooks = new System.Windows.Forms.TabPage();
            this.buttonListAllAuthors = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UpdateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ListBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddBook);
            this.tabControl1.Controls.Add(this.UpdateBook);
            this.tabControl1.Controls.Add(this.ListBooks);
            this.tabControl1.Location = new System.Drawing.Point(28, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2363, 1297);
            this.tabControl1.TabIndex = 1;
            // 
            // AddBook
            // 
            this.AddBook.Controls.Add(this.groupBox1);
            this.AddBook.Location = new System.Drawing.Point(12, 58);
            this.AddBook.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AddBook.Name = "AddBook";
            this.AddBook.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AddBook.Size = new System.Drawing.Size(2339, 1227);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Create Book";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(537, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(1242, 768);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Author";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(952, 617);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 90);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(563, 407);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(470, 44);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(563, 308);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(470, 44);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(563, 192);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(470, 44);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // UpdateBook
            // 
            this.UpdateBook.Controls.Add(this.dataGridView1);
            this.UpdateBook.Controls.Add(this.groupBox3);
            this.UpdateBook.Controls.Add(this.groupBox2);
            this.UpdateBook.Location = new System.Drawing.Point(12, 58);
            this.UpdateBook.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UpdateBook.Size = new System.Drawing.Size(2339, 1227);
            this.UpdateBook.TabIndex = 1;
            this.UpdateBook.Text = "Search/Update/Delete";
            this.UpdateBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 694);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2320, 523);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIDUpdate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxUpdateEmail);
            this.groupBox3.Controls.Add(this.textBoxUpdateLastName);
            this.groupBox3.Controls.Add(this.textBoxUpdateFirstName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Location = new System.Drawing.Point(24, 317);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox3.Size = new System.Drawing.Size(2320, 363);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // textBoxIDUpdate
            // 
            this.textBoxIDUpdate.Location = new System.Drawing.Point(370, 56);
            this.textBoxIDUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxIDUpdate.Name = "textBoxIDUpdate";
            this.textBoxIDUpdate.ReadOnly = true;
            this.textBoxIDUpdate.Size = new System.Drawing.Size(470, 44);
            this.textBoxIDUpdate.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 37);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID ";
            // 
            // textBoxUpdateEmail
            // 
            this.textBoxUpdateEmail.Location = new System.Drawing.Point(1168, 56);
            this.textBoxUpdateEmail.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUpdateEmail.Name = "textBoxUpdateEmail";
            this.textBoxUpdateEmail.Size = new System.Drawing.Size(470, 44);
            this.textBoxUpdateEmail.TabIndex = 29;
            // 
            // textBoxUpdateLastName
            // 
            this.textBoxUpdateLastName.Location = new System.Drawing.Point(370, 257);
            this.textBoxUpdateLastName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUpdateLastName.Name = "textBoxUpdateLastName";
            this.textBoxUpdateLastName.Size = new System.Drawing.Size(470, 44);
            this.textBoxUpdateLastName.TabIndex = 28;
            // 
            // textBoxUpdateFirstName
            // 
            this.textBoxUpdateFirstName.Location = new System.Drawing.Point(370, 146);
            this.textBoxUpdateFirstName.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUpdateFirstName.Name = "textBoxUpdateFirstName";
            this.textBoxUpdateFirstName.Size = new System.Drawing.Size(470, 44);
            this.textBoxUpdateFirstName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1031, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "First Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(2042, 264);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(238, 86);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearchBy);
            this.groupBox2.Controls.Add(this.comboBoxSearchBy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(24, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox2.Size = new System.Drawing.Size(2320, 287);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 37);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(2042, 185);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(238, 88);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchBy
            // 
            this.textBoxSearchBy.Location = new System.Drawing.Point(876, 141);
            this.textBoxSearchBy.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxSearchBy.Name = "textBoxSearchBy";
            this.textBoxSearchBy.Size = new System.Drawing.Size(420, 44);
            this.textBoxSearchBy.TabIndex = 2;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Email"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(876, 44);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(420, 45);
            this.comboBoxSearchBy.TabIndex = 1;
            this.comboBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBy_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search by";
            // 
            // ListBooks
            // 
            this.ListBooks.Controls.Add(this.buttonListAllAuthors);
            this.ListBooks.Controls.Add(this.dataGridView2);
            this.ListBooks.Location = new System.Drawing.Point(12, 58);
            this.ListBooks.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(2339, 1227);
            this.ListBooks.TabIndex = 2;
            this.ListBooks.Text = "List Authors";
            this.ListBooks.UseVisualStyleBackColor = true;
            // 
            // buttonListAllAuthors
            // 
            this.buttonListAllAuthors.Location = new System.Drawing.Point(21, 37);
            this.buttonListAllAuthors.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonListAllAuthors.Name = "buttonListAllAuthors";
            this.buttonListAllAuthors.Size = new System.Drawing.Size(444, 79);
            this.buttonListAllAuthors.TabIndex = 4;
            this.buttonListAllAuthors.Text = "List All Authors";
            this.buttonListAllAuthors.UseVisualStyleBackColor = true;
            this.buttonListAllAuthors.Click += new System.EventHandler(this.buttonListAllAuthors_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 160);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(2325, 1059);
            this.dataGridView2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2081, 1373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1770, 1373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 94);
            this.button2.TabIndex = 3;
            this.button2.Text = "Main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2556, 1665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "AuthorForm";
            this.Text = "Author";
            this.tabControl1.ResumeLayout(false);
            this.AddBook.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UpdateBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ListBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage UpdateBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBy;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage ListBooks;
        private System.Windows.Forms.Button buttonListAllAuthors;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxIDUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUpdateEmail;
        private System.Windows.Forms.TextBox textBoxUpdateLastName;
        private System.Windows.Forms.TextBox textBoxUpdateFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}