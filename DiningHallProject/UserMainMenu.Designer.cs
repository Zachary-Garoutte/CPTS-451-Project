namespace DiningHallProject
{
    partial class UserMainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.viewMenuButton = new System.Windows.Forms.Button();
            this.modifyAccountButton = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.transHistory = new System.Windows.Forms.Button();
            this.charge = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewMenuButton
            // 
            this.viewMenuButton.Location = new System.Drawing.Point(16, 434);
            this.viewMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewMenuButton.Name = "viewMenuButton";
            this.viewMenuButton.Size = new System.Drawing.Size(163, 105);
            this.viewMenuButton.TabIndex = 0;
            this.viewMenuButton.Text = "View Menus";
            this.viewMenuButton.UseVisualStyleBackColor = true;
            this.viewMenuButton.Click += new System.EventHandler(this.viewMenuButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.Location = new System.Drawing.Point(888, 434);
            this.modifyAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(163, 105);
            this.modifyAccountButton.TabIndex = 1;
            this.modifyAccountButton.Text = "Modify Account Info";
            this.modifyAccountButton.UseVisualStyleBackColor = true;
            this.modifyAccountButton.Click += new System.EventHandler(this.modifyAccountButton_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(27, 25);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 32);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, user!";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(27, 68);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(152, 28);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Current Balance:";
            // 
            // transHistory
            // 
            this.transHistory.Location = new System.Drawing.Point(578, 431);
            this.transHistory.Name = "transHistory";
            this.transHistory.Size = new System.Drawing.Size(163, 108);
            this.transHistory.TabIndex = 4;
            this.transHistory.Text = "View Transaction History";
            this.transHistory.UseVisualStyleBackColor = true;
            this.transHistory.Click += new System.EventHandler(this.transHistory_Click);
            // 
            // charge
            // 
            this.charge.Location = new System.Drawing.Point(919, 25);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(132, 99);
            this.charge.TabIndex = 5;
            this.charge.Text = "$1 Charge(Button For Demo Only)";
            this.charge.UseVisualStyleBackColor = true;
            this.charge.Click += new System.EventHandler(this.charge_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 105);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Funds";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.transHistory);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.viewMenuButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserMainMenu";
            this.Text = "User Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewMenuButton;
        private System.Windows.Forms.Button modifyAccountButton;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button transHistory;
        private System.Windows.Forms.Button charge;
        private System.Windows.Forms.Button button1;
    }
}