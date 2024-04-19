namespace TechDistribution.GUI
{
    partial class InventoryControllerMainForm
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
            this.buttonToBookManagement = new System.Windows.Forms.Button();
            this.buttonToAuthorManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToBookManagement
            // 
            this.buttonToBookManagement.Location = new System.Drawing.Point(12, 12);
            this.buttonToBookManagement.Name = "buttonToBookManagement";
            this.buttonToBookManagement.Size = new System.Drawing.Size(140, 118);
            this.buttonToBookManagement.TabIndex = 0;
            this.buttonToBookManagement.Text = "Book Management";
            this.buttonToBookManagement.UseVisualStyleBackColor = true;
            this.buttonToBookManagement.Click += new System.EventHandler(this.buttonToBookManagement_Click);
            // 
            // buttonToAuthorManagement
            // 
            this.buttonToAuthorManagement.Location = new System.Drawing.Point(12, 301);
            this.buttonToAuthorManagement.Name = "buttonToAuthorManagement";
            this.buttonToAuthorManagement.Size = new System.Drawing.Size(140, 118);
            this.buttonToAuthorManagement.TabIndex = 1;
            this.buttonToAuthorManagement.Text = "Author Management";
            this.buttonToAuthorManagement.UseVisualStyleBackColor = true;
            this.buttonToAuthorManagement.Click += new System.EventHandler(this.buttonToAuthorManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Controller";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(682, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 50);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // InventoryControllerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToAuthorManagement);
            this.Controls.Add(this.buttonToBookManagement);
            this.Name = "InventoryControllerMainForm";
            this.Text = "InventoryControllerMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToBookManagement;
        private System.Windows.Forms.Button buttonToAuthorManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
    }
}