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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainMenu));
            this.viewMenuButton = new System.Windows.Forms.Button();
            this.modifyAccountButton = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.transHistory = new System.Windows.Forms.Button();
            this.charge = new System.Windows.Forms.Button();
            this.mealHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addFunds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mealHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMenuButton
            // 
            this.viewMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.viewMenuButton.FlatAppearance.BorderSize = 0;
            this.viewMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.viewMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMenuButton.ForeColor = System.Drawing.Color.White;
            this.viewMenuButton.Location = new System.Drawing.Point(12, 353);
            this.viewMenuButton.Name = "viewMenuButton";
            this.viewMenuButton.Size = new System.Drawing.Size(98, 75);
            this.viewMenuButton.TabIndex = 0;
            this.viewMenuButton.Text = "View Menus";
            this.viewMenuButton.UseVisualStyleBackColor = false;
            this.viewMenuButton.Click += new System.EventHandler(this.viewMenuButton_Click);
            // 
            // modifyAccountButton
            // 
            this.modifyAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.modifyAccountButton.FlatAppearance.BorderSize = 0;
            this.modifyAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.modifyAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyAccountButton.ForeColor = System.Drawing.Color.White;
            this.modifyAccountButton.Location = new System.Drawing.Point(474, 356);
            this.modifyAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAccountButton.Name = "modifyAccountButton";
            this.modifyAccountButton.Size = new System.Drawing.Size(117, 66);
            this.modifyAccountButton.TabIndex = 1;
            this.modifyAccountButton.Text = "Modify Account Info";
            this.modifyAccountButton.UseVisualStyleBackColor = false;
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
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(16, 44);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 21);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Current Balance:";
            // 
            // transHistory
            // 
            this.transHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.transHistory.FlatAppearance.BorderSize = 0;
            this.transHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transHistory.ForeColor = System.Drawing.Color.White;
            this.transHistory.Location = new System.Drawing.Point(239, 356);
            this.transHistory.Margin = new System.Windows.Forms.Padding(2);
            this.transHistory.Name = "transHistory";
            this.transHistory.Size = new System.Drawing.Size(105, 66);
            this.transHistory.TabIndex = 4;
            this.transHistory.Text = "View Transaction History";
            this.transHistory.UseVisualStyleBackColor = false;
            this.transHistory.Click += new System.EventHandler(this.transHistory_Click);
            // 
            // charge
            // 
            this.charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.charge.FlatAppearance.BorderSize = 0;
            this.charge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charge.ForeColor = System.Drawing.Color.White;
            this.charge.Location = new System.Drawing.Point(338, -2);
            this.charge.Margin = new System.Windows.Forms.Padding(2);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(99, 80);
            this.charge.TabIndex = 5;
            this.charge.Text = "$1 Charge(Button For Demo Only)";
            this.charge.UseVisualStyleBackColor = false;
            this.charge.Click += new System.EventHandler(this.charge_Click);
            // 
            // mealHistoryDataGridView
            // 
            this.mealHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealHistoryDataGridView.Location = new System.Drawing.Point(11, 80);
            this.mealHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.mealHistoryDataGridView.Name = "mealHistoryDataGridView";
            this.mealHistoryDataGridView.RowHeadersWidth = 51;
            this.mealHistoryDataGridView.Size = new System.Drawing.Size(572, 206);
            this.mealHistoryDataGridView.TabIndex = 4;
            this.mealHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mealHistoryDataGridView_CellContentClick);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.feedbackButton.FlatAppearance.BorderSize = 0;
            this.feedbackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.feedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackButton.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.Location = new System.Drawing.Point(138, 356);
            this.feedbackButton.Margin = new System.Windows.Forms.Padding(2);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(88, 69);
            this.feedbackButton.TabIndex = 4;
            this.feedbackButton.Text = "Feedback";
            this.feedbackButton.UseVisualStyleBackColor = false;
            this.feedbackButton.Click += new System.EventHandler(this.feedback_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(574, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addFunds
            // 
            this.addFunds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addFunds.FlatAppearance.BorderSize = 0;
            this.addFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFunds.ForeColor = System.Drawing.Color.White;
            this.addFunds.Location = new System.Drawing.Point(357, 357);
            this.addFunds.Margin = new System.Windows.Forms.Padding(2);
            this.addFunds.Name = "addFunds";
            this.addFunds.Size = new System.Drawing.Size(105, 66);
            this.addFunds.TabIndex = 6;
            this.addFunds.Text = "addFunds";
            this.addFunds.UseVisualStyleBackColor = false;
            this.addFunds.Click += new System.EventHandler(this.addFunds_Click);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.addFunds);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.transHistory);
            this.Controls.Add(this.mealHistoryDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.modifyAccountButton);
            this.Controls.Add(this.viewMenuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMainMenu";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealHistoryDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView mealHistoryDataGridView;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addFunds;
    }
}