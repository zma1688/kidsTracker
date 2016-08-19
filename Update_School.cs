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
    public partial class Update_School : Form
    {
        public Update_School()
        {
            InitializeComponent();
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schoolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentPerformanceDataSet);

        }

        private void Add_School_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.studentPerformanceDataSet.School);

        }
    }
}
