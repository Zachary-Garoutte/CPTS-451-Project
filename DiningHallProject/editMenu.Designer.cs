namespace DiningHallProject
{
    partial class editMenu
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
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
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
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.diningHallsBindingSource, "name", true));
            this.comboBox1.DataSource = this.diningHallsBindingSource2;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "menu_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(17, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(771, 324);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "editMenu";
            this.Text = "Edit Menus";
            this.Load += new System.EventHandler(this.editMenu_Load);
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