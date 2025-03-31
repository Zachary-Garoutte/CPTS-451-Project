namespace DiningHallProject
{
    partial class adminPage
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
            this.CreateNewAdmin = new System.Windows.Forms.Button();
            this.EditMenus = new System.Windows.Forms.Button();
            this.EditHalls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewAdmin
            // 
            this.CreateNewAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateNewAdmin.Location = new System.Drawing.Point(12, 62);
            this.CreateNewAdmin.Name = "CreateNewAdmin";
            this.CreateNewAdmin.Size = new System.Drawing.Size(148, 23);
            this.CreateNewAdmin.TabIndex = 0;
            this.CreateNewAdmin.Text = "Create New Admin";
            this.CreateNewAdmin.UseVisualStyleBackColor = true;
            this.CreateNewAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditMenus
            // 
            this.EditMenus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditMenus.Location = new System.Drawing.Point(12, 145);
            this.EditMenus.Name = "EditMenus";
            this.EditMenus.Size = new System.Drawing.Size(148, 23);
            this.EditMenus.TabIndex = 1;
            this.EditMenus.Text = "Edit Menus";
            this.EditMenus.UseVisualStyleBackColor = true;
            this.EditMenus.Click += new System.EventHandler(this.EditMenus_Click);
            // 
            // EditHalls
            // 
            this.EditHalls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditHalls.Location = new System.Drawing.Point(12, 104);
            this.EditHalls.Name = "EditHalls";
            this.EditHalls.Size = new System.Drawing.Size(148, 23);
            this.EditHalls.TabIndex = 2;
            this.EditHalls.Text = "Edit Dining Halls";
            this.EditHalls.UseVisualStyleBackColor = true;
            this.EditHalls.Click += new System.EventHandler(this.EditHalls_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditHalls);
            this.Controls.Add(this.EditMenus);
            this.Controls.Add(this.CreateNewAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "adminPage";
            this.Text = "Admin Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewAdmin;
        private System.Windows.Forms.Button EditMenus;
        private System.Windows.Forms.Button EditHalls;

    }
}