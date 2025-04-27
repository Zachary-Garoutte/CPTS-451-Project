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
            this.mealHistoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mealHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMenuButton
            // 
            this.viewMenuButton.Location = new System.Drawing.Point(12, 353);
            this.viewMenuButton.Name = "viewMenuButton";
            this.viewMenuButton.Size = new System.Drawing.Size(122, 85);
            this.viewMenuButton.TabIndex = 0;
            this.viewMenuButton.Text = "View Menus";
            this.viewMenuButton.UseVisualStyleBackColor = true;
            this.viewMenuButton.Click += new System.EventHandler(this.viewMenuButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.Location = new System.Drawing.Point(656, 353);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(132, 85);
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
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(147, 25);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, user!";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(20, 55);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 21);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Current Balance:";
            // 
            // mealHistoryDataGridView
            // 
            this.mealHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealHistoryDataGridView.Location = new System.Drawing.Point(25, 79);
            this.mealHistoryDataGridView.Name = "mealHistoryDataGridView";
            this.mealHistoryDataGridView.Size = new System.Drawing.Size(763, 253);
            this.mealHistoryDataGridView.TabIndex = 4;
            this.mealHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mealHistoryDataGridView_CellContentClick);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mealHistoryDataGridView);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.viewMenuButton);
            this.Name = "UserMainMenu";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.mealHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewMenuButton;
        private System.Windows.Forms.Button modifyAccountButton;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView mealHistoryDataGridView;
    }
}