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
using System.IO;

namespace frcparts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;                                   
        OleDbDataReader dr;                                 

        string CString = "Provider = Microsoft.Jet.OleDB.4.0;Data Source = frcparts.mdb";
        OleDbConnection conn = new OleDbConnection();
        string strSql = "Select * From frc_temp";
        OleDbDataAdapter adap = new OleDbDataAdapter();
        DataSet dataSet = new DataSet();
        /// <summary>
        /// update dataSetting
        /// </summary>
        private void updateDataSet()
        {
            adap.SelectCommand = new OleDbCommand(strSql, conn);   
            dataSet.Clear();
            adap.Fill(dataSet, "frc_temp");                                
        }
        /// <summary>
        /// Star to load the Form1
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.frc_tempTableAdapter.Fill(this.frcpartsDataSet1.frc_temp);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.ConnectionString = CString;
            updateDataSet();
            dataGridView1.DataSource = dataSet.Tables["frc_temp"];

            updatePartDetail();
            updatePartDetail_Total();
            updateComboBoxPartName();
            updateComboBoxProjectName();
        }

        /// <summary>
        /// Go to Form2 to edit parts
        /// Complete the modified, update the control of comboBox_PartName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_EditPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
            updateComboBoxPartName();
        }

        /// <summary>
        /// Add a part to the project then save to the database table(frc_temp)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddtoProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_PartName.Text) )
            {
                MessageBox.Show("please choose a part!!!");
                return;
            }


            conn.ConnectionString = CString;
            conn.Open();                                           
            string strSql = "insert into frc_temp(partName,partWeight,partPrice,partCategory,partNumber)"+
                " values ('" + comboBox_PartName.Text + "'," + textBox_TotalWeight.Text + "," + textBox_TotalCost.Text + ",'" + textBox_Category.Text+"',"+textBox_PartNumber.Text + ")";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);     

            try
            {
                cmd.ExecuteNonQuery();  
            }
            catch
            {
                MessageBox.Show("insert failed");
            }
            conn.Close();

            updateDataSet();
            // delete the part to prevent repeated to add
            comboBox_PartName.Items.RemoveAt(comboBox_PartName.SelectedIndex);
            comboBox_PartName.SelectedIndex = -1;
        }

        /// <summary>
        /// choose a part then refresh the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_PartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_PartName.Text ))
            {
                textBox_Price.Text = "";
                textBox_Weight.Text = "";
                textBox_Category.Text = "";
                textBox_TotalCost.Text = "";
                textBox_TotalWeight.Text = "";

                return;
            }

            updatePartDetail();
            updatePartDetail_Total();
        }

        /// <summary>
        /// get the part details
        /// </summary>
        private void updatePartDetail()
        {
            conn.ConnectionString = CString;
            conn.Open();                                            

            string strSql = "Select * from frc_parts where part_name='" + comboBox_PartName.Text + "'";
            cmd = new OleDbCommand(strSql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox_Weight.Text = (String)dr[2].ToString();
                textBox_Price.Text = (String)dr[4].ToString();
                textBox_Category.Text = (String)dr[5].ToString();
            }
            conn.Close();
        }

        /// <summary>
        /// Calculate the total weight (number * weight)
        /// Calculate the total price (number * price)
        /// then Calculate the project weight and cost
        /// </summary>
        private void updatePartDetail_Total()
        {
            string partNumber = textBox_PartNumber.Text;
            int number = 0;

            if (!int.TryParse(partNumber,out number))
            {
                textBox_PartNumber.Text = "0";
            }

            float cost = 0.0f;
            float weight = 0.0f;

            try
            {
                cost = number * float.Parse(textBox_Price.Text);
                weight = number * float.Parse(textBox_Weight.Text);

                textBox_TotalCost.Text = cost.ToString();
                textBox_TotalWeight.Text = weight.ToString();

                updateNowTotalParts(cost, weight);
            }
            catch
            {

            }
        }

        /// <summary>
        /// To calculate the total weight and cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_PartNumber_TextChanged(object sender, EventArgs e)
        {
            updatePartDetail_Total();
        }

        /// <summary>
        /// save the project to the database table(frc_projects)
        /// save the parts to the database table(frc_records)
        /// then empty the database table(frc_temp)
        /// </summary>
        private void saveProject()
        {

        }

        /// <summary>
        /// save the project
        /// Complete the modified, update the control of comboBox_ProjectName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveProject_Click(object sender, EventArgs e)
        {
            saveProject();
            updateComboBoxProjectName();
        }

        /// <summary>
        /// update the control of comboBox_ProjectName
        /// </summary>
        private void updateComboBoxProjectName()
        {
            comboBox_ProjectName.Items.Clear();

            conn.ConnectionString = CString;
            conn.Open();                                            
            string strSql = "Select project_name from frc_projects " ;
            cmd = new OleDbCommand(strSql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_ProjectName.Items.Add((String)dr[0].ToString());
            }
            conn.Close();
        }

        /// <summary>
        /// update the control of comboBox_PartName
        /// </summary>
        private void updateComboBoxPartName()
        {
            comboBox_PartName.Items.Clear();

            conn.ConnectionString = CString;
            conn.Open();                                            
            string strSql = "Select part_name from frc_parts " ;
            cmd = new OleDbCommand(strSql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_PartName.Items.Add((String)dr[0].ToString());
            }
            conn.Close();
        }

        /// <summary>
        /// calculate the total weight and cost
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="weight"></param>
        private void updateNowTotalParts(float cost, float weight)
        {
            float NowTotalWeight = weight, NowTotalCost = cost;

            conn.ConnectionString = CString;
            conn.Open();
            string strSql = "Select partWeight,partPrice from frc_temp ";
            cmd = new OleDbCommand(strSql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NowTotalWeight  += float.Parse((String)dr[0].ToString());
                NowTotalCost    += float.Parse((String)dr[1].ToString());
            }
            conn.Close();

            textBox_Now_Cost.Text = NowTotalCost.ToString();
            textBox_Now_Weight.Text = NowTotalWeight.ToString();

            float temp;
            if (float.TryParse(textBox_Target_Cost.Text, out temp))
            {
                if (NowTotalCost >= temp)
                {
                    textBox_Now_Cost.BackColor = Color.Red;
                }
                else
                {
                    textBox_Now_Cost.BackColor = Color.White;
                }
            }
            if (float.TryParse(textBox_Target_Weight.Text, out temp))
            {
                if (NowTotalWeight >= temp)
                {
                    textBox_Now_Weight.BackColor = Color.Red;
                }
                else
                {
                    textBox_Now_Weight.BackColor = Color.White;
                }
            }

        }

        private void textBox_Target_Cost_TextChanged(object sender, EventArgs e)
        {
            float temp;
            if (!float.TryParse(textBox_Target_Cost.Text,out temp))
            {
                textBox_Target_Cost.Text = "";
            }
            else
            {
                updatePartDetail_Total();
            }

        }

        private void textBox_Target_Weight_TextChanged(object sender, EventArgs e)
        {
            float temp;
            if (!float.TryParse(textBox_Target_Weight.Text, out temp))
            {
                textBox_Target_Weight.Text = "";
            }
            else
            {
                updatePartDetail_Total();
            }
        }

        /// <summary>
        /// showDialog to select a location to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            ////Call up the file save, pop-up dialog box
            sfd.InitialDirectory = System.Environment.CurrentDirectory;
            sfd.Filter = "Excel(*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               ExportToCSV(dataSet.Tables["frc_temp"] ,sfd.FileName);
            }
        }

        /// <summary>
        /// exporting the project to CSV
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="filePath"></param>
        /// Writes the data in the DataTable to a CSV file
        /// Provides a DataTable that holds data
        /// CSV file path
        private void ExportToCSV(DataTable dataTable, string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }
            FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);
            string tempData = "";

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                tempData += dataTable.Columns[i].ColumnName.ToString();
                if (i < dataTable.Columns.Count - 1)
                {
                    tempData += ",";
                }
            }
            streamWriter.WriteLine(tempData);
      
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                tempData = "";
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    tempData += dataTable.Rows[i][j].ToString();
                    if (j < dataTable.Columns.Count - 1)
                    {
                        tempData += ",";
                    }
                }
                streamWriter.WriteLine(tempData);
            }
            streamWriter.Close();
            fileStream.Close();
            MessageBox.Show("CSV file save successed！");
        }

        /// <summary>
        /// empty the database table(frc_temp)
        /// </summary>
        private void emptyFRC_Temp()

        ///Connect to the database
        ///Execute the SQL statement
        ///After that will colse database
        {
            conn.ConnectionString = CString;
            conn.Open();                                            
            string strSql = "DELETE FROM frc_temp " ;
            OleDbCommand cmd = new OleDbCommand(strSql, conn);      
            try
            {
                cmd.ExecuteNonQuery();                  
            }
            catch
            {
            }
            conn.Close();
        }

        /// <summary>
        /// delete the project from databass table(frc_projects)
        /// </summary>
        private void deleteFRC_Project()
        {
            conn.ConnectionString = CString;
            conn.Open();
            string strSql = "DELETE FROM frc_projects where project_name = '"+comboBox_ProjectName.Text +"'";
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            conn.Close();
        }

        /// <summary>
        /// open the project which you select
        /// empty the database table(frc_temp)
        /// ......
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_ProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_ProjectName.Text))
            {
                return;
            }
            updateComboBoxPartName();

        }

        /// <summary>
        /// Reset the current project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_EmptyProject_Click(object sender, EventArgs e)
        {
            emptyFRC_Temp();
            updateDataSet();
            updateComboBoxPartName();
            comboBox_ProjectName.SelectedIndex = -1;
        }

        /// <summary>
        /// do delete the project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeleteProject_Click(object sender, EventArgs e)
        {
            deleteFRC_Project();
            updateComboBoxPartName();
        }
    }
}
