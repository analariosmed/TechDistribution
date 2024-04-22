namespace TechDistribution.GUI
{
    partial class MISController
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUserAccountManagement = new System.Windows.Forms.Button();
            this.buttonEmployeeManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(561, 859);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(244, 92);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "MIS MANAGEMENT";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(844, 859);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(244, 92);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUserAccountManagement
            // 
            this.buttonUserAccountManagement.Location = new System.Drawing.Point(176, 502);
            this.buttonUserAccountManagement.Name = "buttonUserAccountManagement";
            this.buttonUserAccountManagement.Size = new System.Drawing.Size(790, 106);
            this.buttonUserAccountManagement.TabIndex = 6;
            this.buttonUserAccountManagement.Text = "User Account Management";
            this.buttonUserAccountManagement.UseVisualStyleBackColor = true;
            this.buttonUserAccountManagement.Click += new System.EventHandler(this.buttonUserAccountManagement_Click);
            // 
            // buttonEmployeeManagement
            // 
            this.buttonEmployeeManagement.Location = new System.Drawing.Point(176, 360);
            this.buttonEmployeeManagement.Name = "buttonEmployeeManagement";
            this.buttonEmployeeManagement.Size = new System.Drawing.Size(800, 103);
            this.buttonEmployeeManagement.TabIndex = 5;
            this.buttonEmployeeManagement.Text = "Employee Management";
            this.buttonEmployeeManagement.UseVisualStyleBackColor = true;
            this.buttonEmployeeManagement.Click += new System.EventHandler(this.buttonEmployeeManagement_Click);
            // 
            // MISController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 988);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUserAccountManagement);
            this.Controls.Add(this.buttonEmployeeManagement);
            this.Name = "MISController";
            this.Text = "MISController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUserAccountManagement;
        private System.Windows.Forms.Button buttonEmployeeManagement;
    }
}