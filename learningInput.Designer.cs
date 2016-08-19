﻿namespace Project
{
    partial class learningInput
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
            System.Windows.Forms.Label timeLineLabel;
            System.Windows.Forms.Label schoolIDLabel;
            System.Windows.Forms.Label camLabel;
            System.Windows.Forms.Label cnoonLabel;
            System.Windows.Forms.Label cpmLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learningInput));
            this.studentPerformanceDataSet = new Project.studentPerformanceDataSet();
            this.dailyLearningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyLearningTableAdapter = new Project.studentPerformanceDataSetTableAdapters.DailyLearningTableAdapter();
            this.tableAdapterManager = new Project.studentPerformanceDataSetTableAdapters.TableAdapterManager();
            this.dailyLearningBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dailyLearningBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timeLineTextBox = new System.Windows.Forms.TextBox();
            this.schoolIDTextBox = new System.Windows.Forms.TextBox();
            this.camTextBox = new System.Windows.Forms.TextBox();
            this.cnoonTextBox = new System.Windows.Forms.TextBox();
            this.cpmTextBox = new System.Windows.Forms.TextBox();
            this.dailyLearningDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timeLineLabel = new System.Windows.Forms.Label();
            schoolIDLabel = new System.Windows.Forms.Label();
            camLabel = new System.Windows.Forms.Label();
            cnoonLabel = new System.Windows.Forms.Label();
            cpmLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingNavigator)).BeginInit();
            this.dailyLearningBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLineLabel
            // 
            timeLineLabel.AutoSize = true;
            timeLineLabel.Location = new System.Drawing.Point(40, 60);
            timeLineLabel.Name = "timeLineLabel";
            timeLineLabel.Size = new System.Drawing.Size(74, 17);
            timeLineLabel.TabIndex = 1;
            timeLineLabel.Text = "Time Line:";
            // 
            // schoolIDLabel
            // 
            schoolIDLabel.AutoSize = true;
            schoolIDLabel.Location = new System.Drawing.Point(40, 88);
            schoolIDLabel.Name = "schoolIDLabel";
            schoolIDLabel.Size = new System.Drawing.Size(72, 17);
            schoolIDLabel.TabIndex = 3;
            schoolIDLabel.Text = "School ID:";
            // 
            // camLabel
            // 
            camLabel.AutoSize = true;
            camLabel.Location = new System.Drawing.Point(40, 116);
            camLabel.Name = "camLabel";
            camLabel.Size = new System.Drawing.Size(40, 17);
            camLabel.TabIndex = 5;
            camLabel.Text = "Cam:";
            // 
            // cnoonLabel
            // 
            cnoonLabel.AutoSize = true;
            cnoonLabel.Location = new System.Drawing.Point(40, 144);
            cnoonLabel.Name = "cnoonLabel";
            cnoonLabel.Size = new System.Drawing.Size(53, 17);
            cnoonLabel.TabIndex = 7;
            cnoonLabel.Text = "Cnoon:";
            // 
            // cpmLabel
            // 
            cpmLabel.AutoSize = true;
            cpmLabel.Location = new System.Drawing.Point(40, 172);
            cpmLabel.Name = "cpmLabel";
            cpmLabel.Size = new System.Drawing.Size(40, 17);
            cpmLabel.TabIndex = 9;
            cpmLabel.Text = "Cpm:";
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "studentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DailyLearningTableAdapter = this.dailyLearningTableAdapter;
            this.tableAdapterManager.DailyPerformanceTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.studentPerformanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dailyLearningBindingNavigator
            // 
            this.dailyLearningBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dailyLearningBindingNavigator.BindingSource = this.dailyLearningBindingSource;
            this.dailyLearningBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dailyLearningBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dailyLearningBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dailyLearningBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dailyLearningBindingNavigatorSaveItem});
            this.dailyLearningBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dailyLearningBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dailyLearningBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dailyLearningBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dailyLearningBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dailyLearningBindingNavigator.Name = "dailyLearningBindingNavigator";
            this.dailyLearningBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dailyLearningBindingNavigator.Size = new System.Drawing.Size(920, 27);
            this.dailyLearningBindingNavigator.TabIndex = 0;
            this.dailyLearningBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dailyLearningBindingNavigatorSaveItem
            // 
            this.dailyLearningBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dailyLearningBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dailyLearningBindingNavigatorSaveItem.Image")));
            this.dailyLearningBindingNavigatorSaveItem.Name = "dailyLearningBindingNavigatorSaveItem";
            this.dailyLearningBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.dailyLearningBindingNavigatorSaveItem.Text = "Save Data";
            this.dailyLearningBindingNavigatorSaveItem.Click += new System.EventHandler(this.dailyLearningBindingNavigatorSaveItem_Click);
            // 
            // timeLineTextBox
            // 
            this.timeLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyLearningBindingSource, "TimeLine", true));
            this.timeLineTextBox.Location = new System.Drawing.Point(120, 57);
            this.timeLineTextBox.Name = "timeLineTextBox";
            this.timeLineTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeLineTextBox.TabIndex = 2;
            // 
            // schoolIDTextBox
            // 
            this.schoolIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyLearningBindingSource, "SchoolID", true));
            this.schoolIDTextBox.Location = new System.Drawing.Point(120, 85);
            this.schoolIDTextBox.Name = "schoolIDTextBox";
            this.schoolIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.schoolIDTextBox.TabIndex = 4;
            // 
            // camTextBox
            // 
            this.camTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyLearningBindingSource, "Cam", true));
            this.camTextBox.Location = new System.Drawing.Point(120, 113);
            this.camTextBox.Name = "camTextBox";
            this.camTextBox.Size = new System.Drawing.Size(100, 22);
            this.camTextBox.TabIndex = 6;
            // 
            // cnoonTextBox
            // 
            this.cnoonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyLearningBindingSource, "Cnoon", true));
            this.cnoonTextBox.Location = new System.Drawing.Point(120, 141);
            this.cnoonTextBox.Name = "cnoonTextBox";
            this.cnoonTextBox.Size = new System.Drawing.Size(100, 22);
            this.cnoonTextBox.TabIndex = 8;
            // 
            // cpmTextBox
            // 
            this.cpmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyLearningBindingSource, "Cpm", true));
            this.cpmTextBox.Location = new System.Drawing.Point(120, 169);
            this.cpmTextBox.Name = "cpmTextBox";
            this.cpmTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpmTextBox.TabIndex = 10;
            // 
            // dailyLearningDataGridView
            // 
            this.dailyLearningDataGridView.AutoGenerateColumns = false;
            this.dailyLearningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyLearningDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dailyLearningDataGridView.DataSource = this.dailyLearningBindingSource;
            this.dailyLearningDataGridView.Location = new System.Drawing.Point(302, 57);
            this.dailyLearningDataGridView.Name = "dailyLearningDataGridView";
            this.dailyLearningDataGridView.RowTemplate.Height = 24;
            this.dailyLearningDataGridView.Size = new System.Drawing.Size(586, 179);
            this.dailyLearningDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TimeLine";
            this.dataGridViewTextBoxColumn1.HeaderText = "TimeLine";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SchoolID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SchoolID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cnoon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cnoon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cpm";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cpm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // learningInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 315);
            this.Controls.Add(this.dailyLearningDataGridView);
            this.Controls.Add(timeLineLabel);
            this.Controls.Add(this.timeLineTextBox);
            this.Controls.Add(schoolIDLabel);
            this.Controls.Add(this.schoolIDTextBox);
            this.Controls.Add(camLabel);
            this.Controls.Add(this.camTextBox);
            this.Controls.Add(cnoonLabel);
            this.Controls.Add(this.cnoonTextBox);
            this.Controls.Add(cpmLabel);
            this.Controls.Add(this.cpmTextBox);
            this.Controls.Add(this.dailyLearningBindingNavigator);
            this.Name = "learningInput";
            this.Text = "learningInput";
            this.Load += new System.EventHandler(this.learningInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningBindingNavigator)).EndInit();
            this.dailyLearningBindingNavigator.ResumeLayout(false);
            this.dailyLearningBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyLearningDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource dailyLearningBindingSource;
        private studentPerformanceDataSetTableAdapters.DailyLearningTableAdapter dailyLearningTableAdapter;
        private studentPerformanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dailyLearningBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dailyLearningBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox timeLineTextBox;
        private System.Windows.Forms.TextBox schoolIDTextBox;
        private System.Windows.Forms.TextBox camTextBox;
        private System.Windows.Forms.TextBox cnoonTextBox;
        private System.Windows.Forms.TextBox cpmTextBox;
        private System.Windows.Forms.DataGridView dailyLearningDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}