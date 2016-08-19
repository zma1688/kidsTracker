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
    public partial class Student_Learning_report : Form
    {
        public Student_Learning_report()
        {
            InitializeComponent();
        }

        private void Student_Learning_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Int32.Parse(textBox2.Text);
            this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, textBox3.Text, b);

            this.reportViewer1.RefreshReport();
        }
    }
}
