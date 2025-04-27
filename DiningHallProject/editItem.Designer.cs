namespace DiningHallProject
{
    partial class editItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editItem));
            this.label1 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemCalories = new System.Windows.Forms.Label();
            this.typelabel = new System.Windows.Forms.Label();
            this.availability = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.calories = new System.Windows.Forms.TextBox();
            this.available = new System.Windows.Forms.CheckedListBox();
            this.itemType = new System.Windows.Forms.CheckedListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ingredients = new System.Windows.Forms.RichTextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemName.Location = new System.Drawing.Point(11, 46);
            this.itemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(75, 17);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Item Name";
            this.itemName.Click += new System.EventHandler(this.itemName_Click);
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSize = true;
            this.itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDesc.Location = new System.Drawing.Point(11, 94);
            this.itemDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(109, 17);
            this.itemDesc.TabIndex = 3;
            this.itemDesc.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingredients";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemPrice.Location = new System.Drawing.Point(11, 302);
            this.itemPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(40, 17);
            this.itemPrice.TabIndex = 5;
            this.itemPrice.Text = "Price";
            // 
            // itemCalories
            // 
            this.itemCalories.AutoSize = true;
            this.itemCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemCalories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemCalories.Location = new System.Drawing.Point(104, 302);
            this.itemCalories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemCalories.Name = "itemCalories";
            this.itemCalories.Size = new System.Drawing.Size(59, 17);
            this.itemCalories.TabIndex = 6;
            this.itemCalories.Text = "Calories";
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.typelabel.Location = new System.Drawing.Point(201, 302);
            this.typelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(70, 17);
            this.typelabel.TabIndex = 7;
            this.typelabel.Text = "Item Type";
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.availability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.availability.Location = new System.Drawing.Point(294, 302);
            this.availability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(74, 17);
            this.availability.TabIndex = 8;
            this.availability.Text = "Availability";
            this.availability.Click += new System.EventHandler(this.availability_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(14, 65);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(276, 22);
            this.name.TabIndex = 9;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(14, 321);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(76, 22);
            this.price.TabIndex = 12;
            // 
            // calories
            // 
            this.calories.BackColor = System.Drawing.Color.White;
            this.calories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories.ForeColor = System.Drawing.Color.Black;
            this.calories.Location = new System.Drawing.Point(107, 321);
            this.calories.Margin = new System.Windows.Forms.Padding(2);
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(76, 22);
            this.calories.TabIndex = 13;
            // 
            // available
            // 
            this.available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.available.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.available.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.available.FormattingEnabled = true;
            this.available.IntegralHeight = false;
            this.available.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.available.Location = new System.Drawing.Point(297, 324);
            this.available.Margin = new System.Windows.Forms.Padding(2);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(90, 31);
            this.available.TabIndex = 14;
            this.available.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.available_ItemCheck);
            // 
            // itemType
            // 
            this.itemType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.itemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemType.FormattingEnabled = true;
            this.itemType.IntegralHeight = false;
            this.itemType.Items.AddRange(new object[] {
            "Side",
            "Entree",
            "Drink"});
            this.itemType.Location = new System.Drawing.Point(204, 324);
            this.itemType.Margin = new System.Windows.Forms.Padding(2);
            this.itemType.MinimumSize = new System.Drawing.Size(4, 4);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(90, 45);
            this.itemType.TabIndex = 15;
            this.itemType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemType_ItemCheck);
            this.itemType.SelectedIndexChanged += new System.EventHandler(this.itemType_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Location = new System.Drawing.Point(392, 307);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 36);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(294, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "*you will not be able to change this later";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Editor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(392, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingredients
            // 
            this.ingredients.Location = new System.Drawing.Point(12, 197);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(499, 96);
            this.ingredients.TabIndex = 20;
            this.ingredients.Text = "";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 114);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(499, 60);
            this.description.TabIndex = 21;
            this.description.Text = "";
            // 
            // editItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(525, 403);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.available);
            this.Controls.Add(this.calories);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.availability);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.itemCalories);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemDesc);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editItem";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.editItem_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label itemCalories;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.CheckedListBox available;
        private System.Windows.Forms.CheckedListBox itemType;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox ingredients;
        private System.Windows.Forms.RichTextBox description;
    }
}