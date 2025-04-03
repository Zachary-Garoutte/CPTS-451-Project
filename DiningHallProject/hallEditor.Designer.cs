namespace DiningHallProject
{
    partial class hallEditor
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
            this.hallBox = new System.Windows.Forms.ListBox();
            this.newHall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which dining hall would you like to edit?";
            // 
            // hallBox
            // 
            this.hallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hallBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hallBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hallBox.FormattingEnabled = true;
            this.hallBox.ItemHeight = 20;
            this.hallBox.Location = new System.Drawing.Point(16, 67);
            this.hallBox.Name = "hallBox";
            this.hallBox.Size = new System.Drawing.Size(757, 344);
            this.hallBox.TabIndex = 1;
            this.hallBox.SelectedIndexChanged += new System.EventHandler(this.hallBox_SelectedIndexChanged);
            // 
            // newHall
            // 
            this.newHall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newHall.Location = new System.Drawing.Point(667, 38);
            this.newHall.Name = "newHall";
            this.newHall.Size = new System.Drawing.Size(106, 23);
            this.newHall.TabIndex = 2;
            this.newHall.Text = "Add New Hall";
            this.newHall.UseVisualStyleBackColor = true;
            this.newHall.Click += new System.EventHandler(this.newHall_Click);
            // 
            // hallEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newHall);
            this.Controls.Add(this.hallBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "hallEditor";
            this.Text = "Hall Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox hallBox;
        private System.Windows.Forms.Button newHall;
    }
}