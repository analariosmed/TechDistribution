namespace TechDistribution.GUI
{
    partial class InventoryController
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
            this.buttonAuthorManagement = new System.Windows.Forms.Button();
            this.buttonBookManagement = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorManagement
            // 
            this.buttonAuthorManagement.Location = new System.Drawing.Point(65, 326);
            this.buttonAuthorManagement.Name = "buttonAuthorManagement";
            this.buttonAuthorManagement.Size = new System.Drawing.Size(800, 103);
            this.buttonAuthorManagement.TabIndex = 0;
            this.buttonAuthorManagement.Text = "Authors Management";
            this.buttonAuthorManagement.UseVisualStyleBackColor = true;
            this.buttonAuthorManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBookManagement
            // 
            this.buttonBookManagement.Location = new System.Drawing.Point(75, 463);
            this.buttonBookManagement.Name = "buttonBookManagement";
            this.buttonBookManagement.Size = new System.Drawing.Size(790, 106);
            this.buttonBookManagement.TabIndex = 1;
            this.buttonBookManagement.Text = "Books Management";
            this.buttonBookManagement.UseVisualStyleBackColor = true;
            this.buttonBookManagement.Click += new System.EventHandler(this.buttonBookManagement_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(721, 770);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(244, 92);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory Controller";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(443, 770);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(244, 92);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // InventoryController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 913);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBookManagement);
            this.Controls.Add(this.buttonAuthorManagement);
            this.Name = "InventoryController";
            this.Text = "InventoryController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorManagement;
        private System.Windows.Forms.Button buttonBookManagement;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogOut;
    }
}