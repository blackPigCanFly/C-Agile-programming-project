using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace frcparts
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string CString = "Provider = Microsoft.Jet.OleDB.4.0;Data Source = frcparts.mdb";
        OleDbConnection conn = new OleDbConnection();
        string strSql = "Select * From frc_parts";
        OleDbDataAdapter adap = new OleDbDataAdapter();
        DataSet dataSet = new DataSet();

        /// <summary>
        /// update dataSet
        /// </summary>
        private void updateDataSet()
        {
            adap.SelectCommand = new OleDbCommand(strSql, conn);    
            dataSet.Clear();
            adap.Fill(dataSet, "frc_parts");                                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
            conn.ConnectionString = CString;                        
            updateDataSet();                                                
            dataGridView1.DataSource = dataSet.Tables["frc_parts"];      // Data Binding Control    
        }


        private void button_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// add a part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder();            
            cb.DataAdapter = adap;
            adap.Update(dataSet.Tables["frc_parts"]);
            dataSet.AcceptChanges();
            updateDataSet();  
        }

        /// <summary>
        /// delete a part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string strDelete = "Delete from frc_parts where part_ID=" + dataGridView1.CurrentRow.Cells[0].Value;
            OleDbCommand cmd = new OleDbCommand(strDelete, conn);
            cmd.ExecuteNonQuery();
            dataSet.AcceptChanges();
            conn.Close();
            updateDataSet();           
        }

        /// <summary>
        /// update a part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Update_Click(object sender, EventArgs e)
        {
            conn.Open();
            string part_id       = dataGridView1.CurrentRow.Cells[0].Value.ToString();          
            string part_name     = dataGridView1.CurrentRow.Cells[1].Value.ToString();         
            string part_weight   = dataGridView1.CurrentRow.Cells[2].Value.ToString();       
            string part_unit     = dataGridView1.CurrentRow.Cells[3].Value.ToString();     
            string part_price    = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string part_category = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            string strUpdate = "Update frc_parts Set part_name='" + part_name + "',part_weight=" + part_weight +
                ",part_unit='" + part_unit + "',part_price=" + part_price + ",part_category='" + part_price + "' where part_Id=" + part_id;
            OleDbCommand cmd = new OleDbCommand(strUpdate, conn);
            cmd.ExecuteNonQuery();
            dataSet.AcceptChanges();
            conn.Close();
            updateDataSet();           
        }
    }
}
