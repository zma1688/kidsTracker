using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Student_Performance_Report : Form
    {
        public Student_Performance_Report()
        {
            InitializeComponent();
        }

        private void Student_Performance_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DailyPerformance' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            this.DailyPerformanceTableAdapter.Fill(this.DataSet1.DailyPerformance,textBox3.Text,a );

            this.reportViewer1.RefreshReport();
        }
    }
}
