namespace TechDistribution.GUI
{
    partial class MainFormMISManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToEmployee = new System.Windows.Forms.Button();
            this.buttonToUserAccount = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIS Manager";
            // 
            // buttonToEmployee
            // 
            this.buttonToEmployee.Location = new System.Drawing.Point(228, 225);
            this.buttonToEmployee.Name = "buttonToEmployee";
            this.buttonToEmployee.Size = new System.Drawing.Size(172, 135);
            this.buttonToEmployee.TabIndex = 1;
            this.buttonToEmployee.Text = "Employee Managment";
            this.buttonToEmployee.UseVisualStyleBackColor = true;
            this.buttonToEmployee.Click += new System.EventHandler(this.buttonToEmployee_Click);
            // 
            // buttonToUserAccount
            // 
            this.buttonToUserAccount.Location = new System.Drawing.Point(529, 225);
            this.buttonToUserAccount.Name = "buttonToUserAccount";
            this.buttonToUserAccount.Size = new System.Drawing.Size(172, 135);
            this.buttonToUserAccount.TabIndex = 2;
            this.buttonToUserAccount.Text = "Users Account";
            this.buttonToUserAccount.UseVisualStyleBackColor = true;
            this.buttonToUserAccount.Click += new System.EventHandler(this.buttonToUserAccount_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(891, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(103, 40);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MainFormMISManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 549);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonToUserAccount);
            this.Controls.Add(this.buttonToEmployee);
            this.Controls.Add(this.label1);
            this.Name = "MainFormMISManager";
            this.Text = "MainFormMISManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToEmployee;
        private System.Windows.Forms.Button buttonToUserAccount;
        private System.Windows.Forms.Button buttonLogout;
    }
}