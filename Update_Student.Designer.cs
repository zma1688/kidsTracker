namespace Project
{
    partial class Update_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Student));
            System.Windows.Forms.Label sIDLabel;
            System.Windows.Forms.Label schIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label emergencyContactNumberLabel;
            this.studentPerformanceDataSet = new Project.studentPerformanceDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Project.studentPerformanceDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Project.studentPerformanceDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sIDTextBox = new System.Windows.Forms.TextBox();
            this.schIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.emergencyContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sIDLabel = new System.Windows.Forms.Label();
            schIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            emergencyContactNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "studentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyLearningTableAdapter = null;
            this.tableAdapterManager.DailyPerformanceTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project.studentPerformanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(1122, 27);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
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
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // sIDLabel
            // 
            sIDLabel.AutoSize = true;
            sIDLabel.Location = new System.Drawing.Point(22, 64);
            sIDLabel.Name = "sIDLabel";
            sIDLabel.Size = new System.Drawing.Size(34, 17);
            sIDLabel.TabIndex = 1;
            sIDLabel.Text = "SID:";
            // 
            // sIDTextBox
            // 
            this.sIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "SID", true));
            this.sIDTextBox.Location = new System.Drawing.Point(217, 61);
            this.sIDTextBox.Name = "sIDTextBox";
            this.sIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.sIDTextBox.TabIndex = 2;
            // 
            // schIDLabel
            // 
            schIDLabel.AutoSize = true;
            schIDLabel.Location = new System.Drawing.Point(22, 92);
            schIDLabel.Name = "schIDLabel";
            schIDLabel.Size = new System.Drawing.Size(53, 17);
            schIDLabel.TabIndex = 3;
            schIDLabel.Text = "Sch ID:";
            // 
            // schIDTextBox
            // 
            this.schIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "SchID", true));
            this.schIDTextBox.Location = new System.Drawing.Point(217, 89);
            this.schIDTextBox.Name = "schIDTextBox";
            this.schIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.schIDTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(22, 120);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(217, 117);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(22, 148);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(217, 145);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(22, 176);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(94, 17);
            dateOfBirthLabel.TabIndex = 9;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "DateOfBirth", true));
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(217, 173);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateOfBirthTextBox.TabIndex = 10;
            // 
            // emergencyContactNumberLabel
            // 
            emergencyContactNumberLabel.AutoSize = true;
            emergencyContactNumberLabel.Location = new System.Drawing.Point(22, 204);
            emergencyContactNumberLabel.Name = "emergencyContactNumberLabel";
            emergencyContactNumberLabel.Size = new System.Drawing.Size(189, 17);
            emergencyContactNumberLabel.TabIndex = 11;
            emergencyContactNumberLabel.Text = "Emergency Contact Number:";
            // 
            // emergencyContactNumberTextBox
            // 
            this.emergencyContactNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "EmergencyContactNumber", true));
            this.emergencyContactNumberTextBox.Location = new System.Drawing.Point(217, 201);
            this.emergencyContactNumberTextBox.Name = "emergencyContactNumberTextBox";
            this.emergencyContactNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.emergencyContactNumberTextBox.TabIndex = 12;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(363, 44);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(723, 295);
            this.studentDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SchID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SchID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmergencyContactNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "EmergencyContactNumber";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // Update_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 351);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(sIDLabel);
            this.Controls.Add(this.sIDTextBox);
            this.Controls.Add(schIDLabel);
            this.Controls.Add(this.schIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(emergencyContactNumberLabel);
            this.Controls.Add(this.emergencyContactNumberTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "Update_Student";
            this.Text = "Update_Student";
            this.Load += new System.EventHandler(this.Update_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentPerformanceDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private studentPerformanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sIDTextBox;
        private System.Windows.Forms.TextBox schIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox emergencyContactNumberTextBox;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}