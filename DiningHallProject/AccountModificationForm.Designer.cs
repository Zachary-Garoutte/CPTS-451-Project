﻿namespace DiningHallProject
{
    partial class AccountModificationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMealPlan = new System.Windows.Forms.Label();
            this.cmbMealPlans = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(150, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.ReadOnly = true;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.UseSystemPasswordChar = true;

            // lblMealPlan
            this.lblMealPlan.AutoSize = true;
            this.lblMealPlan.Location = new System.Drawing.Point(30, 110);
            this.lblMealPlan.Name = "lblMealPlan";
            this.lblMealPlan.Size = new System.Drawing.Size(61, 13);
            this.lblMealPlan.Text = "Meal Plan:";

            // cmbMealPlans
            this.cmbMealPlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealPlans.Location = new System.Drawing.Point(150, 107);
            this.cmbMealPlans.Name = "cmbMealPlans";
            this.cmbMealPlans.Size = new System.Drawing.Size(200, 21);

            // btnSaveChanges
            this.btnSaveChanges.Location = new System.Drawing.Point(150, 150);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 30);
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);

            // AccountModificationForm
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblMealPlan);
            this.Controls.Add(this.cmbMealPlans);
            this.Controls.Add(this.btnSaveChanges);
            this.Name = "AccountModificationForm";
            this.Text = "Modify Account";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMealPlan;
        private System.Windows.Forms.ComboBox cmbMealPlans;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}