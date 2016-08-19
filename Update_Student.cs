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
    public partial class Update_Student : Form
    {
        public Update_Student()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentPerformanceDataSet);

        }

        private void Update_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentPerformanceDataSet.Student);

        }
    }
}
