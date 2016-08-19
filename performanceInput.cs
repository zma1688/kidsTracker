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
    public partial class performanceInput : Form
    {
        public performanceInput()
        {
            InitializeComponent();
        }

        private void dailyPerformanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dailyPerformanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentPerformanceDataSet);

        }

        private void performanceInput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.DailyLearning' table. You can move, or remove it, as needed.
            this.dailyLearningTableAdapter.Fill(this.studentPerformanceDataSet.DailyLearning);
            // TODO: This line of code loads data into the 'studentPerformanceDataSet.DailyPerformance' table. You can move, or remove it, as needed.
            this.dailyPerformanceTableAdapter.Fill(this.studentPerformanceDataSet.DailyPerformance);

        }
    }
}
