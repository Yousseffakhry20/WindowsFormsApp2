namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FullName_textbox = new System.Windows.Forms.TextBox();
            this.Age_textbox = new System.Windows.Forms.TextBox();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.Gender_comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.UserRole_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // FullName_textbox
            // 
            this.FullName_textbox.Location = new System.Drawing.Point(200, 25);
            this.FullName_textbox.Name = "FullName_textbox";
            this.FullName_textbox.Size = new System.Drawing.Size(121, 26);
            this.FullName_textbox.TabIndex = 5;
            // 
            // Age_textbox
            // 
            this.Age_textbox.Location = new System.Drawing.Point(200, 132);
            this.Age_textbox.Name = "Age_textbox";
            this.Age_textbox.Size = new System.Drawing.Size(121, 26);
            this.Age_textbox.TabIndex = 7;
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.Location = new System.Drawing.Point(200, 96);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(121, 26);
            this.Phone_textbox.TabIndex = 8;
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(200, 60);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(121, 26);
            this.Email_textbox.TabIndex = 9;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.IndianRed;
            this.InsertButton.Location = new System.Drawing.Point(755, 25);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(187, 45);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Gender_comboBox1
            // 
            this.Gender_comboBox1.FormattingEnabled = true;
            this.Gender_comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_comboBox1.Location = new System.Drawing.Point(200, 169);
            this.Gender_comboBox1.Name = "Gender_comboBox1";
            this.Gender_comboBox1.Size = new System.Drawing.Size(121, 28);
            this.Gender_comboBox1.TabIndex = 11;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(755, 86);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(187, 39);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 271);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(755, 142);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(187, 39);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(24, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(200, 213);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(121, 26);
            this.Password_textbox.TabIndex = 15;
            // 
            // UserRole_textbox
            // 
            this.UserRole_textbox.Location = new System.Drawing.Point(536, 25);
            this.UserRole_textbox.Name = "UserRole_textbox";
            this.UserRole_textbox.Size = new System.Drawing.Size(121, 26);
            this.UserRole_textbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "User Role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 573);
            this.Controls.Add(this.UserRole_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Gender_comboBox1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.Age_textbox);
            this.Controls.Add(this.FullName_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullName_textbox;
        private System.Windows.Forms.TextBox Age_textbox;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ComboBox Gender_comboBox1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.TextBox UserRole_textbox;
        private System.Windows.Forms.Label label7;
    }
}

