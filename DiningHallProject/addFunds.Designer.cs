namespace DiningHallProject
{
    partial class addFunds
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
            this.label2 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.funds = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.DemoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Much Would You Like To Add?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Funds";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // funds
            // 
            this.funds.DecimalPlaces = 2;
            this.funds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.funds.Location = new System.Drawing.Point(247, 56);
            this.funds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.funds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.funds.Name = "funds";
            this.funds.Size = new System.Drawing.Size(90, 20);
            this.funds.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pay With Card \r\n(Not Available In Demo)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DemoButton
            // 
            this.DemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DemoButton.FlatAppearance.BorderSize = 0;
            this.DemoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DemoButton.ForeColor = System.Drawing.Color.White;
            this.DemoButton.Location = new System.Drawing.Point(198, 122);
            this.DemoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(90, 58);
            this.DemoButton.TabIndex = 4;
            this.DemoButton.Text = "Demo Transaction";
            this.DemoButton.UseVisualStyleBackColor = false;
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // addFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(340, 210);
            this.Controls.Add(this.DemoButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.funds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addFunds";
            this.Text = "Add Funds";
            ((System.ComponentModel.ISupportInitialize)(this.funds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.NumericUpDown funds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DemoButton;
    }
}