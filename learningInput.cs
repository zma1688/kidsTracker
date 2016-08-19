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
    public partial class learningInput : Form
    {
        public learningInput()
        {
            InitializeComponent();
        }

        private void dailyLearningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dailyLearningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentPerformanceDataSet);

        }

        private void learningInput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.DailyLearning' table. You can move, or remove it, as needed.
            this.dailyLearningTableAdapter.Fill(this.studentPerformanceDataSet.DailyLearning);

        }
    }
}
