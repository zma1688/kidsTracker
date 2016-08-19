using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                Student_Performance_Report f = new Student_Performance_Report();
                f.ShowDialog();
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Student_Learning_report s = new Student_Learning_report();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SchoolReport sr = new SchoolReport();
            sr.ShowDialog();
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schoolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentPerformanceDataSet);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.studentPerformanceDataSet.School);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_School up = new Update_School();
            up.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Student us = new Update_Student();
            us.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report rr = new Report();
            rr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\mazhe\Documents\Visual Studio 2015\Projects\Project\Project\studentPerformance.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand comd = new SqlCommand();
                comd.Connection = conn;
                
                comd.CommandType = CommandType.Text;
                comd.CommandText = "BACKUP DATABASE studentPerformance.mdf TO DISK = 'C:\\BU\\studentPerformance_db.bak'";
                comd.ExecuteNonQuery();
                MessageBox.Show("back up is successful!");
            }
            catch (Exception ex) { throw ex;}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            performanceInput p = new performanceInput();
            p.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            learningInput li = new learningInput();
            li.ShowDialog();
        }
    }
}
