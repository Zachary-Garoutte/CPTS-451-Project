namespace DiningHallProject
{
    partial class ViewFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFeedback));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.diningHallsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallSQLDatabaseDataSet4 = new DiningHallProject.DiningHallSQLDatabaseDataSet4();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallSQLDatabaseDataSet3 = new DiningHallProject.DiningHallSQLDatabaseDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.diningHallsData = new DiningHallProject.DiningHallsData();
            this.diningHallsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsTableAdapter = new DiningHallProject.DiningHallsDataTableAdapters.diningHallsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.feedbackTableAdapter = new DiningHallProject.DiningHallSQLDatabaseDataSet3TableAdapters.FeedbackTableAdapter();
            this.diningHallsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.diningHallNames = new DiningHallProject.DiningHallNames();
            this.diningHallsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsTableAdapter1 = new DiningHallProject.DiningHallNamesTableAdapters.diningHallsTableAdapter();
            this.diningHallsTableAdapter2 = new DiningHallProject.DiningHallSQLDatabaseDataSet4TableAdapters.diningHallsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.diningHallsBindingSource3;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // diningHallsBindingSource3
            // 
            this.diningHallsBindingSource3.DataMember = "diningHalls";
            this.diningHallsBindingSource3.DataSource = this.diningHallSQLDatabaseDataSet4;
            // 
            // diningHallSQLDatabaseDataSet4
            // 
            this.diningHallSQLDatabaseDataSet4.DataSetName = "DiningHallSQLDatabaseDataSet4";
            this.diningHallSQLDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "Feedback";
            this.feedbackBindingSource.DataSource = this.diningHallSQLDatabaseDataSet3;
            // 
            // diningHallSQLDatabaseDataSet3
            // 
            this.diningHallSQLDatabaseDataSet3.DataSetName = "DiningHallSQLDatabaseDataSet3";
            this.diningHallSQLDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dining Hall";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // diningHallsData
            // 
            this.diningHallsData.DataSetName = "DiningHallsData";
            this.diningHallsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningHallsDataBindingSource
            // 
            this.diningHallsDataBindingSource.DataSource = this.diningHallsData;
            this.diningHallsDataBindingSource.Position = 0;
            // 
            // diningHallsBindingSource
            // 
            this.diningHallsBindingSource.DataMember = "diningHalls";
            this.diningHallsBindingSource.DataSource = this.diningHallsData;
            // 
            // diningHallsTableAdapter
            // 
            this.diningHallsTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(160, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 403);
            this.listBox1.TabIndex = 2;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // diningHallsBindingSource1
            // 
            this.diningHallsBindingSource1.DataMember = "diningHalls";
            this.diningHallsBindingSource1.DataSource = this.diningHallsDataBindingSource;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Feedback";
            // 
            // diningHallNames
            // 
            this.diningHallNames.DataSetName = "DiningHallNames";
            this.diningHallNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningHallsBindingSource2
            // 
            this.diningHallsBindingSource2.DataMember = "diningHalls";
            this.diningHallsBindingSource2.DataSource = this.diningHallNames;
            // 
            // diningHallsTableAdapter1
            // 
            this.diningHallsTableAdapter1.ClearBeforeFill = true;
            // 
            // diningHallsTableAdapter2
            // 
            this.diningHallsTableAdapter2.ClearBeforeFill = true;
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewFeedback";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource diningHallsDataBindingSource;
        private DiningHallsData diningHallsData;
        private System.Windows.Forms.BindingSource diningHallsBindingSource;
        private DiningHallsDataTableAdapters.diningHallsTableAdapter diningHallsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private DiningHallSQLDatabaseDataSet3 diningHallSQLDatabaseDataSet3;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private DiningHallSQLDatabaseDataSet3TableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.BindingSource diningHallsBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private DiningHallNames diningHallNames;
        private System.Windows.Forms.BindingSource diningHallsBindingSource2;
        private DiningHallNamesTableAdapters.diningHallsTableAdapter diningHallsTableAdapter1;
        private DiningHallSQLDatabaseDataSet4 diningHallSQLDatabaseDataSet4;
        private System.Windows.Forms.BindingSource diningHallsBindingSource3;
        private DiningHallSQLDatabaseDataSet4TableAdapters.diningHallsTableAdapter diningHallsTableAdapter2;
    }
}