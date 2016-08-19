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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.Student' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.StudentTableAdapter.Fill(this.DataSet4.Student,Int32.Parse(textBox1.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
