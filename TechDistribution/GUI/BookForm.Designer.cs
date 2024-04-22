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
            this.buttonDelete = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonShowAuthors = new System.Windows.Forms.Button();
            this.buttonAssignDelete = new System.Windows.Forms.Button();
            this.buttonAssignAdd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.ListBooks = new System.Windows.Forms.TabPage();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UpdateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ListBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddBook);
            this.tabControl1.Controls.Add(this.UpdateBook);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ListBooks);
            this.tabControl1.Location = new System.Drawing.Point(-2, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2377, 1550);
            this.tabControl1.TabIndex = 0;
            // 
            // AddBook
            // 
            this.AddBook.Controls.Add(this.groupBox1);
            this.AddBook.Location = new System.Drawing.Point(12, 58);
            this.AddBook.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AddBook.Name = "AddBook";
            this.AddBook.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.AddBook.Size = new System.Drawing.Size(2353, 1480);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Create Book";
            this.AddBook.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
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
            this.groupBox1.Location = new System.Drawing.Point(508, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox1.Size = new System.Drawing.Size(1309, 1156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddBook";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(563, 506);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(470, 44);
            this.textBoxYear.TabIndex = 18;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1057, 1052);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 90);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(563, 789);
            this.comboBoxPublisher.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxPublisher.MaxDropDownItems = 100;
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(470, 45);
            this.comboBoxPublisher.TabIndex = 16;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(563, 696);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(470, 45);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(563, 597);
            this.textBoxQOH.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(470, 44);
            this.textBoxQOH.TabIndex = 11;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(563, 407);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(470, 44);
            this.textBoxUnitPrice.TabIndex = 9;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(563, 308);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(470, 44);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(563, 192);
            this.textBoxIsbn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(470, 44);
            this.textBoxIsbn.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 809);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 715);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 610);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 520);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Published";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
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
            this.UpdateBook.Size = new System.Drawing.Size(2353, 1480);
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
            this.groupBox3.Location = new System.Drawing.Point(24, 317);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.groupBox3.Size = new System.Drawing.Size(2320, 363);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1817, 264);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(238, 86);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // YearPublishedUpdate
            // 
            this.YearPublishedUpdate.Location = new System.Drawing.Point(1119, 49);
            this.YearPublishedUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.YearPublishedUpdate.Name = "YearPublishedUpdate";
            this.YearPublishedUpdate.Size = new System.Drawing.Size(470, 44);
            this.YearPublishedUpdate.TabIndex = 24;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(2069, 264);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(238, 86);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxPublisherUpdate
            // 
            this.comboBoxPublisherUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisherUpdate.FormattingEnabled = true;
            this.comboBoxPublisherUpdate.Location = new System.Drawing.Point(1864, 49);
            this.comboBoxPublisherUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxPublisherUpdate.MaxDropDownItems = 100;
            this.comboBoxPublisherUpdate.Name = "comboBoxPublisherUpdate";
            this.comboBoxPublisherUpdate.Size = new System.Drawing.Size(386, 45);
            this.comboBoxPublisherUpdate.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1670, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 37);
            this.label16.TabIndex = 21;
            this.label16.Text = "Publisher";
            // 
            // comboBoxCategoryUpdate
            // 
            this.comboBoxCategoryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryUpdate.FormattingEnabled = true;
            this.comboBoxCategoryUpdate.Location = new System.Drawing.Point(1119, 250);
            this.comboBoxCategoryUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxCategoryUpdate.Name = "comboBoxCategoryUpdate";
            this.comboBoxCategoryUpdate.Size = new System.Drawing.Size(470, 45);
            this.comboBoxCategoryUpdate.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(779, 268);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 37);
            this.label15.TabIndex = 19;
            this.label15.Text = "Category";
            // 
            // textBoxQohUpdate
            // 
            this.textBoxQohUpdate.Location = new System.Drawing.Point(1119, 148);
            this.textBoxQohUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxQohUpdate.Name = "textBoxQohUpdate";
            this.textBoxQohUpdate.Size = new System.Drawing.Size(470, 44);
            this.textBoxQohUpdate.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(772, 162);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(274, 37);
            this.label14.TabIndex = 17;
            this.label14.Text = "Quantity On Hand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(772, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 37);
            this.label13.TabIndex = 15;
            this.label13.Text = "Year Published";
            // 
            // textBoxUnitPriceUpdate
            // 
            this.textBoxUnitPriceUpdate.Location = new System.Drawing.Point(228, 257);
            this.textBoxUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUnitPriceUpdate.Name = "textBoxUnitPriceUpdate";
            this.textBoxUnitPriceUpdate.Size = new System.Drawing.Size(470, 44);
            this.textBoxUnitPriceUpdate.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 37);
            this.label12.TabIndex = 12;
            this.label12.Text = "Unit Price";
            // 
            // textBoxTitleUpdate
            // 
            this.textBoxTitleUpdate.Location = new System.Drawing.Point(228, 157);
            this.textBoxTitleUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxTitleUpdate.Name = "textBoxTitleUpdate";
            this.textBoxTitleUpdate.Size = new System.Drawing.Size(470, 44);
            this.textBoxTitleUpdate.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "Title";
            // 
            // textBoxIsbnUpdate
            // 
            this.textBoxIsbnUpdate.Location = new System.Drawing.Point(228, 56);
            this.textBoxIsbnUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxIsbnUpdate.Name = "textBoxIsbnUpdate";
            this.textBoxIsbnUpdate.Size = new System.Drawing.Size(470, 44);
            this.textBoxIsbnUpdate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 37);
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
            this.buttonSearch.Location = new System.Drawing.Point(2069, 185);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN",
            "Title"});
            this.comboBox1.Location = new System.Drawing.Point(876, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(420, 45);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonShowAuthors);
            this.tabPage1.Controls.Add(this.buttonAssignDelete);
            this.tabPage1.Controls.Add(this.buttonAssignAdd);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.comboBoxAuthors);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.comboBoxBooks);
            this.tabPage1.Location = new System.Drawing.Point(12, 58);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(2353, 1480);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Assign Authors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonShowAuthors
            // 
            this.buttonShowAuthors.Location = new System.Drawing.Point(59, 310);
            this.buttonShowAuthors.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonShowAuthors.Name = "buttonShowAuthors";
            this.buttonShowAuthors.Size = new System.Drawing.Size(285, 109);
            this.buttonShowAuthors.TabIndex = 8;
            this.buttonShowAuthors.Text = "Show Authors";
            this.buttonShowAuthors.UseVisualStyleBackColor = true;
            this.buttonShowAuthors.Click += new System.EventHandler(this.buttonShowAuthors_Click);
            // 
            // buttonAssignDelete
            // 
            this.buttonAssignDelete.Location = new System.Drawing.Point(1655, 335);
            this.buttonAssignDelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonAssignDelete.Name = "buttonAssignDelete";
            this.buttonAssignDelete.Size = new System.Drawing.Size(285, 109);
            this.buttonAssignDelete.TabIndex = 7;
            this.buttonAssignDelete.Text = "Delete";
            this.buttonAssignDelete.UseVisualStyleBackColor = true;
            this.buttonAssignDelete.Click += new System.EventHandler(this.buttonAssignDelete_Click);
            // 
            // buttonAssignAdd
            // 
            this.buttonAssignAdd.Location = new System.Drawing.Point(1976, 335);
            this.buttonAssignAdd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonAssignAdd.Name = "buttonAssignAdd";
            this.buttonAssignAdd.Size = new System.Drawing.Size(292, 109);
            this.buttonAssignAdd.TabIndex = 5;
            this.buttonAssignAdd.Text = "Add";
            this.buttonAssignAdd.UseVisualStyleBackColor = true;
            this.buttonAssignAdd.Click += new System.EventHandler(this.buttonAssignAdd_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 458);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(2247, 742);
            this.dataGridView3.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2145, 148);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 37);
            this.label18.TabIndex = 3;
            this.label18.Text = "Authors";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(1268, 215);
            this.comboBoxAuthors.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(992, 45);
            this.comboBoxAuthors.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 148);
            this.label17.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 37);
            this.label17.TabIndex = 1;
            this.label17.Text = "Books";
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(59, 215);
            this.comboBoxBooks.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(964, 45);
            this.comboBoxBooks.TabIndex = 0;
            // 
            // ListBooks
            // 
            this.ListBooks.Controls.Add(this.button6);
            this.ListBooks.Controls.Add(this.button5);
            this.ListBooks.Controls.Add(this.buttonListAllBooks);
            this.ListBooks.Controls.Add(this.dataGridView2);
            this.ListBooks.Location = new System.Drawing.Point(12, 58);
            this.ListBooks.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ListBooks.Name = "ListBooks";
            this.ListBooks.Size = new System.Drawing.Size(2353, 1457);
            this.ListBooks.TabIndex = 2;
            this.ListBooks.Text = "List Books";
            this.ListBooks.UseVisualStyleBackColor = true;
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(21, 37);
            this.buttonListAllBooks.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(444, 79);
            this.buttonListAllBooks.TabIndex = 4;
            this.buttonListAllBooks.Text = "List All Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
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
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1947, 1339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(343, 90);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1594, 1339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(311, 90);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1136, 1313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(292, 84);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2026, 1598);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(313, 77);
            this.button7.TabIndex = 2;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1666, 1598);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(313, 77);
            this.button9.TabIndex = 3;
            this.button9.Text = "Main menu";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2481, 1763);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonAssignDelete;
        private System.Windows.Forms.Button buttonAssignAdd;
        private System.Windows.Forms.Button buttonShowAuthors;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
    }
}