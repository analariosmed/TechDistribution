namespace TechDistribution.GUI
{
    partial class BookForm
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
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBook = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.YearPublishedUpdate = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxPublisherUpdate = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxQohUpdate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTitleUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIsbnUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBy = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListBooks = new System.Windows.Forms.TabPage();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // AddBook
            // 
            this.AddBook.Controls.Add(this.groupBox1);
            this.AddBook.Location = new System.Drawing.Point(4, 25);
            this.AddBook.Name = "AddBook";
            this.AddBook.Padding = new System.Windows.Forms.Padding(3);
            this.AddBook.Size = new System.Drawing.Size(993, 532);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Create Book";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.comboBoxPublisher);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.textBoxQOH);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.textBoxIsbn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(214, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddBook";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(237, 219);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 22);
            this.textBoxYear.TabIndex = 18;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(445, 455);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 39);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(237, 341);
            this.comboBoxPublisher.MaxDropDownItems = 100;
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPublisher.TabIndex = 16;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(237, 301);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(237, 258);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(200, 22);
            this.textBoxQOH.TabIndex = 11;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(237, 176);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxUnitPrice.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(237, 133);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 22);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(237, 83);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(200, 22);
            this.textBoxIsbn.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Published";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // UpdateBook
            // 
            this.UpdateBook.Controls.Add(this.dataGridView1);
            this.UpdateBook.Controls.Add(this.groupBox3);
            this.UpdateBook.Controls.Add(this.groupBox2);
            this.UpdateBook.Location = new System.Drawing.Point(4, 25);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateBook.Size = new System.Drawing.Size(993, 532);
            this.UpdateBook.TabIndex = 1;
            this.UpdateBook.Text = "Search/Update/Delete";
            this.UpdateBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 226);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.YearPublishedUpdate);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.comboBoxPublisherUpdate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.comboBoxCategoryUpdate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxQohUpdate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxUnitPriceUpdate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxTitleUpdate);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxIsbnUpdate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(10, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(977, 157);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // YearPublishedUpdate
            // 
            this.YearPublishedUpdate.Location = new System.Drawing.Point(471, 21);
            this.YearPublishedUpdate.Name = "YearPublishedUpdate";
            this.YearPublishedUpdate.Size = new System.Drawing.Size(200, 22);
            this.YearPublishedUpdate.TabIndex = 24;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(871, 114);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 37);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxPublisherUpdate
            // 
            this.comboBoxPublisherUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisherUpdate.FormattingEnabled = true;
            this.comboBoxPublisherUpdate.Location = new System.Drawing.Point(785, 21);
            this.comboBoxPublisherUpdate.MaxDropDownItems = 100;
            this.comboBoxPublisherUpdate.Name = "comboBoxPublisherUpdate";
            this.comboBoxPublisherUpdate.Size = new System.Drawing.Size(165, 24);
            this.comboBoxPublisherUpdate.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(703, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Publisher";
            // 
            // comboBoxCategoryUpdate
            // 
            this.comboBoxCategoryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryUpdate.FormattingEnabled = true;
            this.comboBoxCategoryUpdate.Location = new System.Drawing.Point(471, 108);
            this.comboBoxCategoryUpdate.Name = "comboBoxCategoryUpdate";
            this.comboBoxCategoryUpdate.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCategoryUpdate.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(328, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Category";
            // 
            // textBoxQohUpdate
            // 
            this.textBoxQohUpdate.Location = new System.Drawing.Point(471, 64);
            this.textBoxQohUpdate.Name = "textBoxQohUpdate";
            this.textBoxQohUpdate.Size = new System.Drawing.Size(200, 22);
            this.textBoxQohUpdate.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Quantity On Hand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Year Published";
            // 
            // textBoxUnitPriceUpdate
            // 
            this.textBoxUnitPriceUpdate.Location = new System.Drawing.Point(96, 111);
            this.textBoxUnitPriceUpdate.Name = "textBoxUnitPriceUpdate";
            this.textBoxUnitPriceUpdate.Size = new System.Drawing.Size(200, 22);
            this.textBoxUnitPriceUpdate.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Unit Price";
            // 
            // textBoxTitleUpdate
            // 
            this.textBoxTitleUpdate.Location = new System.Drawing.Point(96, 68);
            this.textBoxTitleUpdate.Name = "textBoxTitleUpdate";
            this.textBoxTitleUpdate.Size = new System.Drawing.Size(200, 22);
            this.textBoxTitleUpdate.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Title";
            // 
            // textBoxIsbnUpdate
            // 
            this.textBoxIsbnUpdate.Location = new System.Drawing.Point(96, 24);
            this.textBoxIsbnUpdate.Name = "textBoxIsbnUpdate";
            this.textBoxIsbnUpdate.Size = new System.Drawing.Size(200, 22);
            this.textBoxIsbnUpdate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBoxSearchBy);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(10, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "label9";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(871, 80);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 38);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchBy
            // 
            this.textBoxSearchBy.Location = new System.Drawing.Point(369, 61);
            this.textBoxSearchBy.Name = "textBoxSearchBy";
            this.textBoxSearchBy.Size = new System.Drawing.Size(179, 22);
            this.textBoxSearchBy.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN",
            "Title"});
            this.comboBox1.Location = new System.Drawing.Point(369, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search by";
            // 
            // ListBooks
            // 
            this.ListBooks.Controls.Add(this.buttonListAllBooks);
            this.ListBooks.Controls.Add(this.dataGridView2);
            this.ListBooks.Location = new System.Drawing.Point(4, 25);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(993, 532);
            this.ListBooks.TabIndex = 2;
            this.ListBooks.Text = "List Books";
            this.ListBooks.UseVisualStyleBackColor = true;
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(9, 16);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(187, 34);
            this.buttonListAllBooks.TabIndex = 4;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(979, 458);
            this.dataGridView2.TabIndex = 3;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(765, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 37);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "BookForm";
            this.Text = "BookForm";
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
        private System.Windows.Forms.TabPage UpdateBook;
        private System.Windows.Forms.TabPage ListBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxUnitPriceUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTitleUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxIsbnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCategoryUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxQohUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxPublisherUpdate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox YearPublishedUpdate;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonDelete;
    }
}