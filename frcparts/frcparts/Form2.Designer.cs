namespace frcparts
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frcpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frcpartsDataSet1 = new frcparts.frcpartsDataSet();
            this.frcpartsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.frc_partsTableAdapter1 = new frcparts.frcpartsDataSetTableAdapters.frc_partsTableAdapter();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(649, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // frcpartsBindingSource
            // 
            this.frcpartsBindingSource.DataMember = "frc_parts";
            // 
            // frcpartsDataSet1
            // 
            this.frcpartsDataSet1.DataSetName = "frcpartsDataSet";
            this.frcpartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frcpartsBindingSource1
            // 
            this.frcpartsBindingSource1.DataMember = "frc_parts";
            this.frcpartsBindingSource1.DataSource = this.frcpartsDataSet1;
            // 
            // frc_partsTableAdapter1
            // 
            this.frc_partsTableAdapter1.ClearBeforeFill = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(96, 419);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(227, 419);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(358, 419);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(489, 419);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(75, 23);
            this.button_Return.TabIndex = 1;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 464);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Parts management";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frcpartsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private frcpartsDataSet frcpartsDataSet;
        private System.Windows.Forms.BindingSource frcpartsBindingSource;
        private frcpartsDataSetTableAdapters.frc_partsTableAdapter frc_partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partcategoryDataGridViewTextBoxColumn;
        private frcpartsDataSet frcpartsDataSet1;
        private System.Windows.Forms.BindingSource frcpartsBindingSource1;
        private frcpartsDataSetTableAdapters.frc_partsTableAdapter frc_partsTableAdapter1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Return;
    }
}