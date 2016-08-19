namespace Project
{
    partial class Add
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.studentPerformanceDataSet = new Project.studentPerformanceDataSet();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTableAdapter = new Project.studentPerformanceDataSetTableAdapters.SchoolTableAdapter();
            this.tableAdapterManager = new Project.studentPerformanceDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Update School";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 26;
            this.button2.Text = "Update Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 33);
            this.button3.TabIndex = 27;
            this.button3.Text = "Performance Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 33);
            this.button4.TabIndex = 28;
            this.button4.Text = "School Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 33);
            this.button5.TabIndex = 29;
            this.button5.Text = "Learning Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kids Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "User";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(492, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 32);
            this.button6.TabIndex = 33;
            this.button6.Text = "Student List";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(543, -3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 32);
            this.button7.TabIndex = 34;
            this.button7.Text = "Backup";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(309, 92);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 33);
            this.button8.TabIndex = 35;
            this.button8.Text = "performance Input";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(473, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 33);
            this.button9.TabIndex = 36;
            this.button9.Text = "learning input";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 218);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.Text = "Kids Tracker";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private studentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private studentPerformanceDataSetTableAdapters.SchoolTableAdapter schoolTableAdapter;
        private studentPerformanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

