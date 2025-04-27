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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hallEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.hallBox = new System.Windows.Forms.ListBox();
            this.newHall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Dining Hall to Edit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hallBox
            // 
            this.hallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.hallBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hallBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.hallBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hallBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hallBox.FormattingEnabled = true;
            this.hallBox.ItemHeight = 16;
            this.hallBox.Location = new System.Drawing.Point(219, 0);
            this.hallBox.Margin = new System.Windows.Forms.Padding(2);
            this.hallBox.Name = "hallBox";
            this.hallBox.Size = new System.Drawing.Size(427, 411);
            this.hallBox.TabIndex = 1;
            this.hallBox.SelectedIndexChanged += new System.EventHandler(this.hallBox_SelectedIndexChanged);
            // 
            // newHall
            // 
            this.newHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.newHall.FlatAppearance.BorderSize = 0;
            this.newHall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newHall.ForeColor = System.Drawing.Color.White;
            this.newHall.Location = new System.Drawing.Point(16, 357);
            this.newHall.Margin = new System.Windows.Forms.Padding(2);
            this.newHall.Name = "newHall";
            this.newHall.Size = new System.Drawing.Size(87, 39);
            this.newHall.TabIndex = 2;
            this.newHall.Text = "Add New Hall";
            this.newHall.UseVisualStyleBackColor = false;
            this.newHall.Click += new System.EventHandler(this.newHall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dining Hall Editor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(118, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hallEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(646, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newHall);
            this.Controls.Add(this.hallBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hallEditor";
            this.Text = "Hall Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox hallBox;
        private System.Windows.Forms.Button newHall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}