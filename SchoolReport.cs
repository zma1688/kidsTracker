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
    public partial class SchoolReport : Form
    {
        public SchoolReport()
        {
            InitializeComponent();
        }

        private void SchoolReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.DataTable1' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(textBox1.Text);
            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1,textBox3.Text,c);
            this.reportViewer1.RefreshReport();
        }
    }
}
