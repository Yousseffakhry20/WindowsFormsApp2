using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AttendanceSheetProcessing : Form
    {


        DataTable dt = new DataTable();
        int totalMinutes = 0;
        public AttendanceSheetProcessing()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Excel Workbook|* .xlsx", Multiselect = false })
            {
                if (openFileDialog.ShowDialog()== DialogResult.OK)
                {
                    
                    using( XLWorkbook workbook= new XLWorkbook(openFileDialog.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach(IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
    
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i=0;
                                foreach(IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++]=cell.Value.ToString();   

                            }
                        }


                        
                        //dataGridView1.Columns[4].DefaultCellStyle.Format = "t";
                    }
                }
            }
            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Name"].ToString() == "Neveen Saleh" || row["Name"].ToString() == "Rehab Ali"
                    || row["Name"].ToString() == "Ahmed Moawad" || row["Name"].ToString() == "Hossam Mohamed"
                    || row["Name"].ToString() == "Mai Fawzy" || row["Name"].ToString() == "Nermine Mahmoud ElSayed")
                {
                    row.Delete();
                }

            }
            dt.AcceptChanges();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void Test_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dt.Rows[25][0].ToString()+ " " + dt.Rows.Count);


            DataTable dt2 = new DataTable();
            dt2.Clear();
            dt2.Columns.Add("Name");
            dt2.Columns.Add("Number of Days");
            dt2.Columns.Add("Lateness");
            dt2.Columns.Add("Overtime");

            DataRow newRow = dt2.NewRow();



            //var prod0Count = dt.AsEnumerable()
            //    .Where(row => row.Field<string>("Name"))
            //    .Select(row => row.Field<string>("ColumnA"))
            //    .Distinct()
            //    .Count();

            //var distinctNames = dt.Select().Distinct();
            //Console.WriteLine(distinctNames);
            //MessageBox.Show(prod0Count.ToString());

            var list = from x in dt.AsEnumerable()
                       group x by (string)x["Name"] into g
                       select g;
            var List=list.ToList();

            int i = 0;
            int[] attendanceCount = new int[List.Count];


            


            try
            {

                
                

                foreach (var x in list)
                {
                    List<int> lateness = new List<int>();
                    int count = 0;
                    int overtime = 0;
                    int Late = 0;

                    
                    
                    

                    
                    while (i < dt.Rows.Count && dt.Rows[i][0].ToString() == x.Key.ToString())
                    {
                        //Console.WriteLine(dt.Rows[i][0].ToString()+ " "+dt.Rows[i][4].ToString());

                        
                        string date = dt.Rows[i][4].ToString();
                        if (!date.Equals(""))
                        {
                            DateTime dateTime = DateTime.Parse(date);
                            TimeSpan interval = dateTime.TimeOfDay;

                            totalMinutes = int.Parse(interval.TotalMinutes.ToString());


                            //Console.WriteLine(dt.Rows[i][0].ToString() + " Work Time:::: " + date + " " + totalMinutes);
                        }
                        int late = 480 - totalMinutes;
                        lateness.Add(late);




                        lateness.ForEach(Console.WriteLine);




                        i++;
                        count++;








                    }
                    int[] Lateness = lateness.ToArray();
                    int sumTimeDifference = lateness.Sum();
                    Console.WriteLine(x.Key.ToString() + " " + count.ToString());
                    Console.WriteLine(sumTimeDifference);


                    if (sumTimeDifference>0 && sumTimeDifference>240)
                    {
                        Late = sumTimeDifference-240;
                        Console.WriteLine("Lateness " + Late.ToString());
                        newRow["Lateness"] = Late.ToString();
                        newRow["Overtime"] = 0;
                    }
                    else if (sumTimeDifference > 0 && sumTimeDifference < 240)
                    {
                        Console.WriteLine("No Lateness");
                        newRow["Lateness"] = "No Lateness";
                        newRow["Overtime"] = 0;
                    }
                    else if (sumTimeDifference<0)
                    {
                        overtime=Math.Abs(sumTimeDifference);
                        Console.WriteLine("Overtime " + overtime.ToString());
                        newRow["Lateness"] = 0;
                        newRow["Overtime"] = overtime.ToString();
                    }

                    newRow["Name"]=x.Key.ToString();
                    newRow["Number of Days"]=count.ToString();

                    dt2.Rows.Add(newRow.ItemArray);








                }




                dataGridView1.DataSource = dt2.DefaultView;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            

            

           






             


            


            
        }
    }
}
