namespace frcparts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up all resources that are being used.
        /// </summary>
        /// <param name="disposing">True if the managed resource should be released; otherwise false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows The form designer generates the code

        /// <summary>
        /// The designer supports the required method - do not modify it
        /// Use the code editor to modify the contents of this method.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Parts = new System.Windows.Forms.GroupBox();
            this.button_DeleteProject = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.comboBox_ProjectName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_EmptyProject = new System.Windows.Forms.Button();
            this.button_SaveProject = new System.Windows.Forms.Button();
            this.frcprojectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frcpartsDataSet = new frcparts.frcpartsDataSet();
            this.groupBox_PartDetails = new System.Windows.Forms.GroupBox();
            this.comboBox_PartName = new System.Windows.Forms.ComboBox();
            this.textBox_TotalWeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_TotalCost = new System.Windows.Forms.TextBox();
            this.button_AddtoProject = new System.Windows.Forms.Button();
            this.button_EditPart = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_PartNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Category = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.frcpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_OverAll = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Now_Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Now_Cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Target_Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Target_Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frc_projectsTableAdapter = new frcparts.frcpartsDataSetTableAdapters.frc_projectsTableAdapter();
            this.frc_partsTableAdapter = new frcparts.frcpartsDataSetTableAdapters.frc_partsTableAdapter();
            this.frcpartsDataSet1 = new frcparts.frcpartsDataSet();
            this.frctempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frc_tempTableAdapter = new frcparts.frcpartsDataSetTableAdapters.frc_tempTableAdapter();
            this.groupBox_Parts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcprojectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet)).BeginInit();
            this.groupBox_PartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource)).BeginInit();
            this.groupBox_OverAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frctempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Parts
            // 
            this.groupBox_Parts.Controls.Add(this.button_DeleteProject);
            this.groupBox_Parts.Controls.Add(this.button_Export);
            this.groupBox_Parts.Controls.Add(this.comboBox_ProjectName);
            this.groupBox_Parts.Controls.Add(this.label1);
            this.groupBox_Parts.Controls.Add(this.dataGridView1);
            this.groupBox_Parts.Controls.Add(this.button_EmptyProject);
            this.groupBox_Parts.Controls.Add(this.button_SaveProject);
            this.groupBox_Parts.Location = new System.Drawing.Point(12, 28);
            this.groupBox_Parts.Name = "groupBox_Parts";
            this.groupBox_Parts.Size = new System.Drawing.Size(765, 293);
            this.groupBox_Parts.TabIndex = 0;
            this.groupBox_Parts.TabStop = false;
            this.groupBox_Parts.Text = "Parts";
            // 
            // button_DeleteProject
            // 
            this.button_DeleteProject.Location = new System.Drawing.Point(252, 19);
            this.button_DeleteProject.Name = "button_DeleteProject";
            this.button_DeleteProject.Size = new System.Drawing.Size(105, 23);
            this.button_DeleteProject.TabIndex = 5;
            this.button_DeleteProject.Text = "Delete Project";
            this.button_DeleteProject.UseVisualStyleBackColor = true;
            this.button_DeleteProject.Click += new System.EventHandler(this.button_DeleteProject_Click);
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(343, 251);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(105, 23);
            this.button_Export.TabIndex = 4;
            this.button_Export.Text = "Export to CSV";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // comboBox_ProjectName
            // 
            this.comboBox_ProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProjectName.FormattingEnabled = true;
            this.comboBox_ProjectName.Location = new System.Drawing.Point(115, 21);
            this.comboBox_ProjectName.Name = "comboBox_ProjectName";
            this.comboBox_ProjectName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_ProjectName.TabIndex = 3;
            this.comboBox_ProjectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ProjectName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Project:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(748, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_EmptyProject
            // 
            this.button_EmptyProject.Location = new System.Drawing.Point(474, 251);
            this.button_EmptyProject.Name = "button_EmptyProject";
            this.button_EmptyProject.Size = new System.Drawing.Size(102, 23);
            this.button_EmptyProject.TabIndex = 0;
            this.button_EmptyProject.Text = "Empty Project";
            this.button_EmptyProject.UseVisualStyleBackColor = true;
            this.button_EmptyProject.Click += new System.EventHandler(this.button_EmptyProject_Click);
            // 
            // button_SaveProject
            // 
            this.button_SaveProject.Location = new System.Drawing.Point(605, 251);
            this.button_SaveProject.Name = "button_SaveProject";
            this.button_SaveProject.Size = new System.Drawing.Size(102, 23);
            this.button_SaveProject.TabIndex = 0;
            this.button_SaveProject.Text = "Save Project";
            this.button_SaveProject.UseVisualStyleBackColor = true;
            this.button_SaveProject.Click += new System.EventHandler(this.button_SaveProject_Click);
            // 
            // frcprojectsBindingSource
            // 
            this.frcprojectsBindingSource.DataMember = "frc_projects";
            this.frcprojectsBindingSource.DataSource = this.frcpartsDataSet;
            // 
            // frcpartsDataSet
            // 
            this.frcpartsDataSet.DataSetName = "frcpartsDataSet";
            this.frcpartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox_PartDetails
            // 
            this.groupBox_PartDetails.Controls.Add(this.comboBox_PartName);
            this.groupBox_PartDetails.Controls.Add(this.textBox_TotalWeight);
            this.groupBox_PartDetails.Controls.Add(this.label14);
            this.groupBox_PartDetails.Controls.Add(this.textBox_TotalCost);
            this.groupBox_PartDetails.Controls.Add(this.button_AddtoProject);
            this.groupBox_PartDetails.Controls.Add(this.button_EditPart);
            this.groupBox_PartDetails.Controls.Add(this.label13);
            this.groupBox_PartDetails.Controls.Add(this.textBox_PartNumber);
            this.groupBox_PartDetails.Controls.Add(this.label12);
            this.groupBox_PartDetails.Controls.Add(this.textBox_Category);
            this.groupBox_PartDetails.Controls.Add(this.label11);
            this.groupBox_PartDetails.Controls.Add(this.textBox_Weight);
            this.groupBox_PartDetails.Controls.Add(this.label10);
            this.groupBox_PartDetails.Controls.Add(this.textBox_Price);
            this.groupBox_PartDetails.Controls.Add(this.label16);
            this.groupBox_PartDetails.Controls.Add(this.label15);
            this.groupBox_PartDetails.Controls.Add(this.label9);
            this.groupBox_PartDetails.Controls.Add(this.label8);
            this.groupBox_PartDetails.Location = new System.Drawing.Point(319, 327);
            this.groupBox_PartDetails.Name = "groupBox_PartDetails";
            this.groupBox_PartDetails.Size = new System.Drawing.Size(458, 228);
            this.groupBox_PartDetails.TabIndex = 1;
            this.groupBox_PartDetails.TabStop = false;
            this.groupBox_PartDetails.Text = "Part Details";
            // 
            // comboBox_PartName
            // 
            this.comboBox_PartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PartName.FormattingEnabled = true;
            this.comboBox_PartName.Location = new System.Drawing.Point(300, 54);
            this.comboBox_PartName.Name = "comboBox_PartName";
            this.comboBox_PartName.Size = new System.Drawing.Size(100, 20);
            this.comboBox_PartName.TabIndex = 2;
            this.comboBox_PartName.SelectedIndexChanged += new System.EventHandler(this.comboBox_PartName_SelectedIndexChanged);
            // 
            // textBox_TotalWeight
            // 
            this.textBox_TotalWeight.Location = new System.Drawing.Point(103, 161);
            this.textBox_TotalWeight.Name = "textBox_TotalWeight";
            this.textBox_TotalWeight.ReadOnly = true;
            this.textBox_TotalWeight.Size = new System.Drawing.Size(100, 21);
            this.textBox_TotalWeight.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Weight";
            // 
            // textBox_TotalCost
            // 
            this.textBox_TotalCost.Location = new System.Drawing.Point(103, 132);
            this.textBox_TotalCost.Name = "textBox_TotalCost";
            this.textBox_TotalCost.ReadOnly = true;
            this.textBox_TotalCost.Size = new System.Drawing.Size(100, 21);
            this.textBox_TotalCost.TabIndex = 1;
            // 
            // button_AddtoProject
            // 
            this.button_AddtoProject.Location = new System.Drawing.Point(300, 135);
            this.button_AddtoProject.Name = "button_AddtoProject";
            this.button_AddtoProject.Size = new System.Drawing.Size(100, 23);
            this.button_AddtoProject.TabIndex = 0;
            this.button_AddtoProject.Text = "Add to Project";
            this.button_AddtoProject.UseVisualStyleBackColor = true;
            this.button_AddtoProject.Click += new System.EventHandler(this.button_AddtoProject_Click);
            // 
            // button_EditPart
            // 
            this.button_EditPart.Location = new System.Drawing.Point(130, 192);
            this.button_EditPart.Name = "button_EditPart";
            this.button_EditPart.Size = new System.Drawing.Size(75, 23);
            this.button_EditPart.TabIndex = 0;
            this.button_EditPart.Text = "Edit Part";
            this.button_EditPart.UseVisualStyleBackColor = true;
            this.button_EditPart.Click += new System.EventHandler(this.button_EditPart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Cost";
            // 
            // textBox_PartNumber
            // 
            this.textBox_PartNumber.Location = new System.Drawing.Point(300, 80);
            this.textBox_PartNumber.Name = "textBox_PartNumber";
            this.textBox_PartNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_PartNumber.TabIndex = 1;
            this.textBox_PartNumber.Text = "1";
            this.textBox_PartNumber.TextChanged += new System.EventHandler(this.textBox_PartNumber_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number";
            // 
            // textBox_Category
            // 
            this.textBox_Category.Location = new System.Drawing.Point(103, 104);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.ReadOnly = true;
            this.textBox_Category.Size = new System.Drawing.Size(100, 21);
            this.textBox_Category.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Category";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(103, 77);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.ReadOnly = true;
            this.textBox_Weight.Size = new System.Drawing.Size(100, 21);
            this.textBox_Weight.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Weight";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(103, 52);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.Size = new System.Drawing.Size(100, 21);
            this.textBox_Price.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "Choose Part:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "Show Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Part";
            // 
            // frcpartsBindingSource
            // 
            this.frcpartsBindingSource.DataMember = "frc_parts";
            this.frcpartsBindingSource.DataSource = this.frcpartsDataSet;
            // 
            // groupBox_OverAll
            // 
            this.groupBox_OverAll.Controls.Add(this.label7);
            this.groupBox_OverAll.Controls.Add(this.label6);
            this.groupBox_OverAll.Controls.Add(this.textBox_Now_Weight);
            this.groupBox_OverAll.Controls.Add(this.label5);
            this.groupBox_OverAll.Controls.Add(this.textBox_Now_Cost);
            this.groupBox_OverAll.Controls.Add(this.label4);
            this.groupBox_OverAll.Controls.Add(this.textBox_Target_Weight);
            this.groupBox_OverAll.Controls.Add(this.label3);
            this.groupBox_OverAll.Controls.Add(this.textBox_Target_Cost);
            this.groupBox_OverAll.Controls.Add(this.label2);
            this.groupBox_OverAll.Location = new System.Drawing.Point(12, 327);
            this.groupBox_OverAll.Name = "groupBox_OverAll";
            this.groupBox_OverAll.Size = new System.Drawing.Size(284, 228);
            this.groupBox_OverAll.TabIndex = 2;
            this.groupBox_OverAll.TabStop = false;
            this.groupBox_OverAll.Text = "OverAll";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Show Now：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Input Target：";
            // 
            // textBox_Now_Weight
            // 
            this.textBox_Now_Weight.Location = new System.Drawing.Point(136, 159);
            this.textBox_Now_Weight.Name = "textBox_Now_Weight";
            this.textBox_Now_Weight.ReadOnly = true;
            this.textBox_Now_Weight.Size = new System.Drawing.Size(100, 21);
            this.textBox_Now_Weight.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight";
            // 
            // textBox_Now_Cost
            // 
            this.textBox_Now_Cost.Location = new System.Drawing.Point(136, 132);
            this.textBox_Now_Cost.Name = "textBox_Now_Cost";
            this.textBox_Now_Cost.ReadOnly = true;
            this.textBox_Now_Cost.Size = new System.Drawing.Size(100, 21);
            this.textBox_Now_Cost.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cost";
            // 
            // textBox_Target_Weight
            // 
            this.textBox_Target_Weight.Location = new System.Drawing.Point(136, 80);
            this.textBox_Target_Weight.Name = "textBox_Target_Weight";
            this.textBox_Target_Weight.Size = new System.Drawing.Size(100, 21);
            this.textBox_Target_Weight.TabIndex = 1;
            this.textBox_Target_Weight.Text = "10";
            this.textBox_Target_Weight.TextChanged += new System.EventHandler(this.textBox_Target_Weight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight";
            // 
            // textBox_Target_Cost
            // 
            this.textBox_Target_Cost.Location = new System.Drawing.Point(136, 53);
            this.textBox_Target_Cost.Name = "textBox_Target_Cost";
            this.textBox_Target_Cost.Size = new System.Drawing.Size(100, 21);
            this.textBox_Target_Cost.TabIndex = 1;
            this.textBox_Target_Cost.Text = "10";
            this.textBox_Target_Cost.TextChanged += new System.EventHandler(this.textBox_Target_Cost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frc_projectsTableAdapter
            // 
            this.frc_projectsTableAdapter.ClearBeforeFill = true;
            // 
            // frc_partsTableAdapter
            // 
            this.frc_partsTableAdapter.ClearBeforeFill = true;
            // 
            // frcpartsDataSet1
            // 
            this.frcpartsDataSet1.DataSetName = "frcpartsDataSet";
            this.frcpartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frctempBindingSource
            // 
            this.frctempBindingSource.DataMember = "frc_temp";
            this.frctempBindingSource.DataSource = this.frcpartsDataSet1;
            // 
            // frc_tempTableAdapter
            // 
            this.frc_tempTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 567);
            this.Controls.Add(this.groupBox_OverAll);
            this.Controls.Add(this.groupBox_PartDetails);
            this.Controls.Add(this.groupBox_Parts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FIRST FRC Parts Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Parts.ResumeLayout(false);
            this.groupBox_Parts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcprojectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet)).EndInit();
            this.groupBox_PartDetails.ResumeLayout(false);
            this.groupBox_PartDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource)).EndInit();
            this.groupBox_OverAll.ResumeLayout(false);
            this.groupBox_OverAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frctempBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Parts;
        private System.Windows.Forms.GroupBox groupBox_PartDetails;
        private System.Windows.Forms.GroupBox groupBox_OverAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_SaveProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private frcpartsDataSet frcpartsDataSet;
        private System.Windows.Forms.ComboBox comboBox_ProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource frcprojectsBindingSource;
        private frcpartsDataSetTableAdapters.frc_projectsTableAdapter frc_projectsTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Now_Weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Now_Cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Target_Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Target_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Category;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_PartName;
        private System.Windows.Forms.TextBox textBox_TotalWeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_TotalCost;
        private System.Windows.Forms.Button button_EditPart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_PartNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource frcpartsBindingSource;
        private frcpartsDataSetTableAdapters.frc_partsTableAdapter frc_partsTableAdapter;
        private System.Windows.Forms.Button button_AddtoProject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private frcpartsDataSet frcpartsDataSet1;
        private System.Windows.Forms.BindingSource frctempBindingSource;
        private frcpartsDataSetTableAdapters.frc_tempTableAdapter frc_tempTableAdapter;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_EmptyProject;
        private System.Windows.Forms.Button button_DeleteProject;
    }
}

