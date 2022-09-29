namespace WindowsFormsApp2
{
    partial class Form2
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
            this.GoToEmployeeDataWindow = new System.Windows.Forms.Button();
            this.GoToAttSheetProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employees\' Data:";
            // 
            // GoToEmployeeDataWindow
            // 
            this.GoToEmployeeDataWindow.Location = new System.Drawing.Point(384, 55);
            this.GoToEmployeeDataWindow.Name = "GoToEmployeeDataWindow";
            this.GoToEmployeeDataWindow.Size = new System.Drawing.Size(75, 33);
            this.GoToEmployeeDataWindow.TabIndex = 1;
            this.GoToEmployeeDataWindow.Text = "Open";
            this.GoToEmployeeDataWindow.UseVisualStyleBackColor = true;
            this.GoToEmployeeDataWindow.Click += new System.EventHandler(this.GoToEmployeeDataWindow_Click);
            // 
            // GoToAttSheetProcess
            // 
            this.GoToAttSheetProcess.Location = new System.Drawing.Point(384, 108);
            this.GoToAttSheetProcess.Name = "GoToAttSheetProcess";
            this.GoToAttSheetProcess.Size = new System.Drawing.Size(75, 33);
            this.GoToAttSheetProcess.TabIndex = 3;
            this.GoToAttSheetProcess.Text = "Open";
            this.GoToAttSheetProcess.UseVisualStyleBackColor = true;
            this.GoToAttSheetProcess.Click += new System.EventHandler(this.GoToAttSheetProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Monthly Attendance Sheet:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoToAttSheetProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoToEmployeeDataWindow);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoToEmployeeDataWindow;
        private System.Windows.Forms.Button GoToAttSheetProcess;
        private System.Windows.Forms.Label label2;
    }
}