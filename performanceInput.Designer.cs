namespace Project
{
    partial class performanceInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(performanceInput));
            System.Windows.Forms.Label timeLineLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label pamLabel;
            System.Windows.Forms.Label pnoonLabel;
            System.Windows.Forms.Label ppmLabel;
            this.studentPerformanceDataSet = new Project.studentPerformanceDataSet();
            this.dailyPerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyPerformanceTableAdapter = new Project.studentPerformanceDataSetTableAdapters.DailyPerformanceTableAdapter();
            this.tableAdapterManager = new Project.studentPerformanceDataSetTableAdapters.TableAdapterManager();
            this.dailyPerformanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dailyPerformanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timeLineTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.pamTextBox = new System.Windows.Forms.TextBox();
            this.pnoonTextBox = new System.Windows.Forms.TextBox();
            this.ppmTextBox = new System.Windows.Forms.TextBox();
            this.dailyLearningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyLearningTableAdapter = new Project.studentPerformanceDataSetTableAdapters.DailyLearningTableAdapter();
            this.dailyPerformanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timeLineLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            pamLabel = new System.Windows.Forms.Label();
            pnoonLabel = new System.Windows.Forms.Label();
            ppmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceBindingNavigator)).BeginInit();
            this.dailyPerformanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "studentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyPerformanceBindingSource
            // 
            this.dailyPerformanceBindingSource.DataMember = "DailyPerformance";
            this.dailyPerformanceBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // dailyPerformanceTableAdapter
            // 
            this.dailyPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyLearningTableAdapter = this.dailyLearningTableAdapter;
            this.tableAdapterManager.DailyPerformanceTableAdapter = this.dailyPerformanceTableAdapter;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.studentPerformanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dailyPerformanceBindingNavigator
            // 
            this.dailyPerformanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dailyPerformanceBindingNavigator.BindingSource = this.dailyPerformanceBindingSource;
            this.dailyPerformanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dailyPerformanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dailyPerformanceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dailyPerformanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dailyPerformanceBindingNavigatorSaveItem});
            this.dailyPerformanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dailyPerformanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dailyPerformanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dailyPerformanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dailyPerformanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dailyPerformanceBindingNavigator.Name = "dailyPerformanceBindingNavigator";
            this.dailyPerformanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dailyPerformanceBindingNavigator.Size = new System.Drawing.Size(1176, 27);
            this.dailyPerformanceBindingNavigator.TabIndex = 0;
            this.dailyPerformanceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dailyPerformanceBindingNavigatorSaveItem
            // 
            this.dailyPerformanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dailyPerformanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dailyPerformanceBindingNavigatorSaveItem.Image")));
            this.dailyPerformanceBindingNavigatorSaveItem.Name = "dailyPerformanceBindingNavigatorSaveItem";
            this.dailyPerformanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dailyPerformanceBindingNavigatorSaveItem.Text = "Save Data";
            this.dailyPerformanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.dailyPerformanceBindingNavigatorSaveItem_Click);
            // 
            // timeLineLabel
            // 
            timeLineLabel.AutoSize = true;
            timeLineLabel.Location = new System.Drawing.Point(24, 54);
            timeLineLabel.Name = "timeLineLabel";
            timeLineLabel.Size = new System.Drawing.Size(74, 17);
            timeLineLabel.TabIndex = 1;
            timeLineLabel.Text = "Time Line:";
            // 
            // timeLineTextBox
            // 
            this.timeLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPerformanceBindingSource, "TimeLine", true));
            this.timeLineTextBox.Location = new System.Drawing.Point(108, 51);
            this.timeLineTextBox.Name = "timeLineTextBox";
            this.timeLineTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeLineTextBox.TabIndex = 2;
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(24, 82);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(78, 17);
            studentIDLabel.TabIndex = 3;
            studentIDLabel.Text = "Student ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPerformanceBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(108, 79);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentIDTextBox.TabIndex = 4;
            // 
            // pamLabel
            // 
            pamLabel.AutoSize = true;
            pamLabel.Location = new System.Drawing.Point(24, 110);
            pamLabel.Name = "pamLabel";
            pamLabel.Size = new System.Drawing.Size(40, 17);
            pamLabel.TabIndex = 5;
            pamLabel.Text = "Pam:";
            // 
            // pamTextBox
            // 
            this.pamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPerformanceBindingSource, "Pam", true));
            this.pamTextBox.Location = new System.Drawing.Point(108, 107);
            this.pamTextBox.Name = "pamTextBox";
            this.pamTextBox.Size = new System.Drawing.Size(100, 22);
            this.pamTextBox.TabIndex = 6;
            // 
            // pnoonLabel
            // 
            pnoonLabel.AutoSize = true;
            pnoonLabel.Location = new System.Drawing.Point(24, 138);
            pnoonLabel.Name = "pnoonLabel";
            pnoonLabel.Size = new System.Drawing.Size(53, 17);
            pnoonLabel.TabIndex = 7;
            pnoonLabel.Text = "Pnoon:";
            // 
            // pnoonTextBox
            // 
            this.pnoonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPerformanceBindingSource, "Pnoon", true));
            this.pnoonTextBox.Location = new System.Drawing.Point(108, 135);
            this.pnoonTextBox.Name = "pnoonTextBox";
            this.pnoonTextBox.Size = new System.Drawing.Size(100, 22);
            this.pnoonTextBox.TabIndex = 8;
            // 
            // ppmLabel
            // 
            ppmLabel.AutoSize = true;
            ppmLabel.Location = new System.Drawing.Point(24, 166);
            ppmLabel.Name = "ppmLabel";
            ppmLabel.Size = new System.Drawing.Size(40, 17);
            ppmLabel.TabIndex = 9;
            ppmLabel.Text = "Ppm:";
            // 
            // ppmTextBox
            // 
            this.ppmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyPerformanceBindingSource, "Ppm", true));
            this.ppmTextBox.Location = new System.Drawing.Point(108, 163);
            this.ppmTextBox.Name = "ppmTextBox";
            this.ppmTextBox.Size = new System.Drawing.Size(100, 22);
            this.ppmTextBox.TabIndex = 10;
            // 
            // dailyLearningBindingSource
            // 
            this.dailyLearningBindingSource.DataMember = "DailyLearning";
            this.dailyLearningBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // dailyLearningTableAdapter
            // 
            this.dailyLearningTableAdapter.ClearBeforeFill = true;
            // 
            // dailyPerformanceDataGridView
            // 
            this.dailyPerformanceDataGridView.AutoGenerateColumns = false;
            this.dailyPerformanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyPerformanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dailyPerformanceDataGridView.DataSource = this.dailyPerformanceBindingSource;
            this.dailyPerformanceDataGridView.Location = new System.Drawing.Point(266, 54);
            this.dailyPerformanceDataGridView.Name = "dailyPerformanceDataGridView";
            this.dailyPerformanceDataGridView.RowTemplate.Height = 24;
            this.dailyPerformanceDataGridView.Size = new System.Drawing.Size(742, 220);
            this.dailyPerformanceDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TimeLine";
            this.dataGridViewTextBoxColumn1.HeaderText = "TimeLine";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pnoon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pnoon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ppm";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ppm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // performanceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 351);
            this.Controls.Add(this.dailyPerformanceDataGridView);
            this.Controls.Add(timeLineLabel);
            this.Controls.Add(this.timeLineTextBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(pamLabel);
            this.Controls.Add(this.pamTextBox);
            this.Controls.Add(pnoonLabel);
            this.Controls.Add(this.pnoonTextBox);
            this.Controls.Add(ppmLabel);
            this.Controls.Add(this.ppmTextBox);
            this.Controls.Add(this.dailyPerformanceBindingNavigator);
            this.Name = "performanceInput";
            this.Text = "performanceInput";
            this.Load += new System.EventHandler(this.performanceInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceBindingNavigator)).EndInit();
            this.dailyPerformanceBindingNavigator.ResumeLayout(false);
            this.dailyPerformanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyPerformanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource dailyPerformanceBindingSource;
        private studentPerformanceDataSetTableAdapters.DailyPerformanceTableAdapter dailyPerformanceTableAdapter;
        private studentPerformanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dailyPerformanceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dailyPerformanceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox timeLineTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox pamTextBox;
        private System.Windows.Forms.TextBox pnoonTextBox;
        private System.Windows.Forms.TextBox ppmTextBox;
        private studentPerformanceDataSetTableAdapters.DailyLearningTableAdapter dailyLearningTableAdapter;
        private System.Windows.Forms.BindingSource dailyLearningBindingSource;
        private System.Windows.Forms.DataGridView dailyPerformanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}