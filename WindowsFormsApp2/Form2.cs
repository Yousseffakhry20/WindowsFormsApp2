using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 Form1 = new Form1();
        AttendanceSheetProcessing AttendanceSheetProcessing= new AttendanceSheetProcessing();

        public Form2()
        {
            InitializeComponent();
        }

        private void GoToEmployeeDataWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Show(); 
            
        }

        private void GoToAttSheetProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceSheetProcessing.Show();
        }
    }
}
