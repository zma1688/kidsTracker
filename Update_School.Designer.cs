namespace Project
{
    partial class Update_School
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_School));
            System.Windows.Forms.Label schIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label numStudentsLabel;
            System.Windows.Forms.Label streetAddressLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label contactNumberLabel;
            this.studentPerformanceDataSet = new Project.studentPerformanceDataSet();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new Project.studentPerformanceDataSetTableAdapters.SchoolTableAdapter();
            this.tableAdapterManager = new Project.studentPerformanceDataSetTableAdapters.TableAdapterManager();
            this.schoolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.schoolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.schIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numStudentsTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.schoolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            schIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            numStudentsLabel = new System.Windows.Forms.Label();
            streetAddressLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).BeginInit();
            this.schoolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "studentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "School";
            this.schoolBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyLearningTableAdapter = null;
            this.tableAdapterManager.DailyPerformanceTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = this.schoolTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.studentPerformanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // schoolBindingNavigator
            // 
            this.schoolBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schoolBindingNavigator.BindingSource = this.schoolBindingSource;
            this.schoolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.schoolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schoolBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.schoolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.schoolBindingNavigatorSaveItem});
            this.schoolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.schoolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.schoolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.schoolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.schoolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.schoolBindingNavigator.Name = "schoolBindingNavigator";
            this.schoolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.schoolBindingNavigator.Size = new System.Drawing.Size(1151, 27);
            this.schoolBindingNavigator.TabIndex = 0;
            this.schoolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // schoolBindingNavigatorSaveItem
            // 
            this.schoolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schoolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolBindingNavigatorSaveItem.Image")));
            this.schoolBindingNavigatorSaveItem.Name = "schoolBindingNavigatorSaveItem";
            this.schoolBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.schoolBindingNavigatorSaveItem.Text = "Save Data";
            this.schoolBindingNavigatorSaveItem.Click += new System.EventHandler(this.schoolBindingNavigatorSaveItem_Click);
            // 
            // schIDLabel
            // 
            schIDLabel.AutoSize = true;
            schIDLabel.Location = new System.Drawing.Point(17, 43);
            schIDLabel.Name = "schIDLabel";
            schIDLabel.Size = new System.Drawing.Size(53, 17);
            schIDLabel.TabIndex = 1;
            schIDLabel.Text = "Sch ID:";
            // 
            // schIDTextBox
            // 
            this.schIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "SchID", true));
            this.schIDTextBox.Location = new System.Drawing.Point(137, 40);
            this.schIDTextBox.Name = "schIDTextBox";
            this.schIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.schIDTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(137, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // numStudentsLabel
            // 
            numStudentsLabel.AutoSize = true;
            numStudentsLabel.Location = new System.Drawing.Point(17, 99);
            numStudentsLabel.Name = "numStudentsLabel";
            numStudentsLabel.Size = new System.Drawing.Size(101, 17);
            numStudentsLabel.TabIndex = 5;
            numStudentsLabel.Text = "Num Students:";
            // 
            // numStudentsTextBox
            // 
            this.numStudentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "NumStudents", true));
            this.numStudentsTextBox.Location = new System.Drawing.Point(137, 96);
            this.numStudentsTextBox.Name = "numStudentsTextBox";
            this.numStudentsTextBox.Size = new System.Drawing.Size(100, 22);
            this.numStudentsTextBox.TabIndex = 6;
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new System.Drawing.Point(17, 127);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new System.Drawing.Size(106, 17);
            streetAddressLabel.TabIndex = 7;
            streetAddressLabel.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "StreetAddress", true));
            this.streetAddressTextBox.Location = new System.Drawing.Point(137, 124);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.streetAddressTextBox.TabIndex = 8;
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(17, 155);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 17);
            zipLabel.TabIndex = 9;
            zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(137, 152);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 22);
            this.zipTextBox.TabIndex = 10;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(17, 183);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(137, 180);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 12;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(17, 211);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(137, 208);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 22);
            this.stateTextBox.TabIndex = 14;
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new System.Drawing.Point(17, 239);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(114, 17);
            contactNumberLabel.TabIndex = 15;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "ContactNumber", true));
            this.contactNumberTextBox.Location = new System.Drawing.Point(137, 236);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.contactNumberTextBox.TabIndex = 16;
            // 
            // schoolDataGridView
            // 
            this.schoolDataGridView.AutoGenerateColumns = false;
            this.schoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.schoolDataGridView.DataSource = this.schoolBindingSource;
            this.schoolDataGridView.Location = new System.Drawing.Point(272, 43);
            this.schoolDataGridView.Name = "schoolDataGridView";
            this.schoolDataGridView.RowTemplate.Height = 24;
            this.schoolDataGridView.Size = new System.Drawing.Size(863, 234);
            this.schoolDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SchID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SchID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumStudents";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumStudents";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StreetAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "StreetAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Zip";
            this.dataGridViewTextBoxColumn5.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ContactNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "ContactNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // Update_School
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 286);
            this.Controls.Add(this.schoolDataGridView);
            this.Controls.Add(schIDLabel);
            this.Controls.Add(this.schIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(numStudentsLabel);
            this.Controls.Add(this.numStudentsTextBox);
            this.Controls.Add(streetAddressLabel);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(contactNumberLabel);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.schoolBindingNavigator);
            this.Name = "Update_School";
            this.Text = "Update_School";
            this.Load += new System.EventHandler(this.Add_School_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingNavigator)).EndInit();
            this.schoolBindingNavigator.ResumeLayout(false);
            this.schoolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private studentPerformanceDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
        private studentPerformanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator schoolBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton schoolBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox schIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numStudentsTextBox;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.DataGridView schoolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}