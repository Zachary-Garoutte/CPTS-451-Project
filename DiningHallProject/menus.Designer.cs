namespace DiningHallProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.diningHallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallSQLDatabaseDataSet = new DiningHallProject.DiningHallSQLDatabaseDataSet();
            this.diningHallsTableAdapter = new DiningHallProject.DiningHallSQLDatabaseDataSetTableAdapters.diningHallsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallSQLDatabaseDataSet1 = new DiningHallProject.DiningHallSQLDatabaseDataSet1();
            this.menuTableAdapter = new DiningHallProject.DiningHallSQLDatabaseDataSet1TableAdapters.MenuTableAdapter();
            this.diningHallSQLDatabaseDataSet2 = new DiningHallProject.DiningHallSQLDatabaseDataSet2();
            this.diningHallsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsTableAdapter1 = new DiningHallProject.DiningHallSQLDatabaseDataSet2TableAdapters.diningHallsTableAdapter();
            this.diningHallsData = new DiningHallProject.DiningHallsData();
            this.diningHallsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.diningHallsTableAdapter2 = new DiningHallProject.DiningHallsDataTableAdapters.diningHallsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // diningHallsBindingSource
            // 
            this.diningHallsBindingSource.DataMember = "diningHalls";
            this.diningHallsBindingSource.DataSource = this.diningHallSQLDatabaseDataSet;
            // 
            // diningHallSQLDatabaseDataSet
            // 
            this.diningHallSQLDatabaseDataSet.DataSetName = "DiningHallSQLDatabaseDataSet";
            this.diningHallSQLDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningHallsTableAdapter
            // 
            this.diningHallsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dining Hall";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.diningHallSQLDatabaseDataSet1;
            // 
            // diningHallSQLDatabaseDataSet1
            // 
            this.diningHallSQLDatabaseDataSet1.DataSetName = "DiningHallSQLDatabaseDataSet1";
            this.diningHallSQLDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // diningHallSQLDatabaseDataSet2
            // 
            this.diningHallSQLDatabaseDataSet2.DataSetName = "DiningHallSQLDatabaseDataSet2";
            this.diningHallSQLDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningHallsBindingSource1
            // 
            this.diningHallsBindingSource1.DataMember = "diningHalls";
            this.diningHallsBindingSource1.DataSource = this.diningHallSQLDatabaseDataSet2;
            // 
            // diningHallsTableAdapter1
            // 
            this.diningHallsTableAdapter1.ClearBeforeFill = true;
            // 
            // diningHallsData
            // 
            this.diningHallsData.DataSetName = "DiningHallsData";
            this.diningHallsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningHallsBindingSource2
            // 
            this.diningHallsBindingSource2.DataMember = "diningHalls";
            this.diningHallsBindingSource2.DataSource = this.diningHallsData;
            // 
            // diningHallsTableAdapter2
            // 
            this.diningHallsTableAdapter2.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.diningHallsBindingSource2;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "menu_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(262, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 400);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(691, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallSQLDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningHallsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DiningHallSQLDatabaseDataSet diningHallSQLDatabaseDataSet;
        private System.Windows.Forms.BindingSource diningHallsBindingSource;
        private DiningHallSQLDatabaseDataSetTableAdapters.diningHallsTableAdapter diningHallsTableAdapter;
        private System.Windows.Forms.Label label1;
        private DiningHallSQLDatabaseDataSet1 diningHallSQLDatabaseDataSet1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DiningHallSQLDatabaseDataSet1TableAdapters.MenuTableAdapter menuTableAdapter;
        private DiningHallSQLDatabaseDataSet2 diningHallSQLDatabaseDataSet2;
        private System.Windows.Forms.BindingSource diningHallsBindingSource1;
        private DiningHallSQLDatabaseDataSet2TableAdapters.diningHallsTableAdapter diningHallsTableAdapter1;
        private DiningHallsData diningHallsData;
        private System.Windows.Forms.BindingSource diningHallsBindingSource2;
        private DiningHallsDataTableAdapters.diningHallsTableAdapter diningHallsTableAdapter2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}