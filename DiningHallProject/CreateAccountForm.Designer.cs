namespace DiningHallProject
{
    partial class CreateAccountForm
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.ConfirmText = new System.Windows.Forms.TextBox();
            this.StudentIDText = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentEmail = new System.Windows.Forms.TextBox();
            this.plan1radial = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.plan2radial = new System.Windows.Forms.RadioButton();
            this.plan3radial = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(208, 61);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(201, 22);
            this.UserNameText.TabIndex = 0;
            this.UserNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(208, 102);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(201, 22);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfirmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmLabel.Location = new System.Drawing.Point(12, 143);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(171, 25);
            this.ConfirmLabel.TabIndex = 5;
            this.ConfirmLabel.Text = "Confirm Password";
            this.ConfirmLabel.UseWaitCursor = true;
            // 
            // ConfirmText
            // 
            this.ConfirmText.Location = new System.Drawing.Point(208, 147);
            this.ConfirmText.Name = "ConfirmText";
            this.ConfirmText.Size = new System.Drawing.Size(201, 22);
            this.ConfirmText.TabIndex = 4;
            this.ConfirmText.UseWaitCursor = true;
            // 
            // StudentIDText
            // 
            this.StudentIDText.AutoSize = true;
            this.StudentIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentIDText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentIDText.Location = new System.Drawing.Point(10, 266);
            this.StudentIDText.Name = "StudentIDText";
            this.StudentIDText.Size = new System.Drawing.Size(104, 25);
            this.StudentIDText.TabIndex = 7;
            this.StudentIDText.Text = "Student ID";
            this.StudentIDText.UseWaitCursor = true;
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(206, 270);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(201, 22);
            this.StudentID.TabIndex = 6;
            this.StudentID.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(10, 312);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Email";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentEmail
            // 
            this.StudentEmail.Location = new System.Drawing.Point(206, 316);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(201, 22);
            this.StudentEmail.TabIndex = 8;
            this.StudentEmail.UseWaitCursor = true;
            // 
            // plan1radial
            // 
            this.plan1radial.AutoSize = true;
            this.plan1radial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plan1radial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plan1radial.Location = new System.Drawing.Point(15, 394);
            this.plan1radial.Name = "plan1radial";
            this.plan1radial.Size = new System.Drawing.Size(157, 29);
            this.plan1radial.TabIndex = 10;
            this.plan1radial.TabStop = true;
            this.plan1radial.Text = "Plan 1($1120)";
            this.plan1radial.UseVisualStyleBackColor = true;
            this.plan1radial.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Please Select A Meal Plan:";
            // 
            // plan2radial
            // 
            this.plan2radial.AutoSize = true;
            this.plan2radial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plan2radial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plan2radial.Location = new System.Drawing.Point(15, 429);
            this.plan2radial.Name = "plan2radial";
            this.plan2radial.Size = new System.Drawing.Size(157, 29);
            this.plan2radial.TabIndex = 12;
            this.plan2radial.TabStop = true;
            this.plan2radial.Text = "Plan 2($1475)";
            this.plan2radial.UseVisualStyleBackColor = true;
            // 
            // plan3radial
            // 
            this.plan3radial.AutoSize = true;
            this.plan3radial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plan3radial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plan3radial.Location = new System.Drawing.Point(15, 464);
            this.plan3radial.Name = "plan3radial";
            this.plan3radial.Size = new System.Drawing.Size(157, 29);
            this.plan3radial.TabIndex = 13;
            this.plan3radial.TabStop = true;
            this.plan3radial.Text = "Plan 3($1795)";
            this.plan3radial.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SubmitButton.Location = new System.Drawing.Point(10, 499);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(89, 26);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(83, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Create Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name";
            this.label3.UseWaitCursor = true;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(208, 191);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(201, 22);
            this.firstName.TabIndex = 16;
            this.firstName.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            this.label4.UseWaitCursor = true;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(208, 229);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(201, 22);
            this.lastName.TabIndex = 18;
            this.lastName.UseWaitCursor = true;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1237, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.plan3radial);
            this.Controls.Add(this.plan2radial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plan1radial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentEmail);
            this.Controls.Add(this.StudentIDText);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.ConfirmText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameText);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.TextBox ConfirmText;
        private System.Windows.Forms.Label StudentIDText;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StudentEmail;
        private System.Windows.Forms.RadioButton plan1radial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton plan2radial;
        private System.Windows.Forms.RadioButton plan3radial;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastName;
    }
}