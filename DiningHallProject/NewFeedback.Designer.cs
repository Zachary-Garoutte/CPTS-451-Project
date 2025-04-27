namespace DiningHallProject
{
    partial class NewFeedback
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
            this.components = new System.ComponentModel.Container();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiningHallSelection = new System.Windows.Forms.ComboBox();
            this.diningHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsData = new DiningHallProject.DiningHallsData();
            this.label3 = new System.Windows.Forms.Label();
            this.diningHallsTableAdapter = new DiningHallProject.DiningHallsDataTableAdapters.diningHallsTableAdapter();
            this.FeedbackRating = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackRating)).BeginInit();
            this.SuspendLayout();
            // 
            // commentBox
            // 
            this.commentBox.BackColor = System.Drawing.Color.White;
            this.commentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentBox.ForeColor = System.Drawing.Color.Black;
            this.commentBox.Location = new System.Drawing.Point(12, 82);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(350, 92);
            this.commentBox.TabIndex = 0;
            this.commentBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comments (Optional)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rating";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DiningHallSelection
            // 
            this.DiningHallSelection.BackColor = System.Drawing.Color.White;
            this.DiningHallSelection.DataSource = this.diningHallsBindingSource;
            this.DiningHallSelection.DisplayMember = "name";
            this.DiningHallSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiningHallSelection.ForeColor = System.Drawing.Color.Black;
            this.DiningHallSelection.FormattingEnabled = true;
            this.DiningHallSelection.Location = new System.Drawing.Point(15, 25);
            this.DiningHallSelection.Name = "DiningHallSelection";
            this.DiningHallSelection.Size = new System.Drawing.Size(262, 21);
            this.DiningHallSelection.TabIndex = 3;
            this.DiningHallSelection.SelectedIndexChanged += new System.EventHandler(this.DiningHallSelection_SelectedIndexChanged);
            // 
            // diningHallsBindingSource
            // 
            this.diningHallsBindingSource.DataMember = "diningHalls";
            this.diningHallsBindingSource.DataSource = this.diningHallsDataBindingSource;
            // 
            // diningHallsDataBindingSource
            // 
            this.diningHallsDataBindingSource.DataSource = this.diningHallsData;
            this.diningHallsDataBindingSource.Position = 0;
            // 
            // diningHallsData
            // 
            this.diningHallsData.DataSetName = "DiningHallsData";
            this.diningHallsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dining Hall";
            // 
            // diningHallsTableAdapter
            // 
            this.diningHallsTableAdapter.ClearBeforeFill = true;
            // 
            // FeedbackRating
            // 
            this.FeedbackRating.BackColor = System.Drawing.Color.White;
            this.FeedbackRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeedbackRating.ForeColor = System.Drawing.Color.Black;
            this.FeedbackRating.Location = new System.Drawing.Point(304, 29);
            this.FeedbackRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FeedbackRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FeedbackRating.Name = "FeedbackRating";
            this.FeedbackRating.Size = new System.Drawing.Size(58, 16);
            this.FeedbackRating.TabIndex = 6;
            this.FeedbackRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FeedbackRating.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(209, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(374, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedbackRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiningHallSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentBox);
            this.Name = "NewFeedback";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DiningHallSelection;
        private System.Windows.Forms.BindingSource diningHallsDataBindingSource;
        private DiningHallsData diningHallsData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource diningHallsBindingSource;
        private DiningHallsDataTableAdapters.diningHallsTableAdapter diningHallsTableAdapter;
        private System.Windows.Forms.NumericUpDown FeedbackRating;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}