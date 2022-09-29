namespace WindowsFormsApp2
{
    partial class AttendanceSheetProcessing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Test_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(695, 478);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(146, 39);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Choose File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Test_button
            // 
            this.Test_button.Location = new System.Drawing.Point(332, 478);
            this.Test_button.Name = "Test_button";
            this.Test_button.Size = new System.Drawing.Size(124, 39);
            this.Test_button.TabIndex = 2;
            this.Test_button.Text = "Execute";
            this.Test_button.UseVisualStyleBackColor = true;
            this.Test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // AttendanceSheetProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 619);
            this.Controls.Add(this.Test_button);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttendanceSheetProcessing";
            this.Text = "AttendanceSheetProcessing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Test_button;
    }
}