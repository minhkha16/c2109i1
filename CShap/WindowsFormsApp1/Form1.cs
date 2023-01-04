using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            SqlConnection con = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["minhkha"].ConnectionString;
                command.Connection = con;
                command.CommandText = "GetAllStudent";
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                bindingSource1.DataSource = ds.Tables[0];
            //table.DataSource = ds.Tables[0].DefaultView;
            table.DataSource = bindingSource1;
            bindingNavigator1.BindingSource= bindingSource1;
            txtFirsName.DataBindings.Add("Text", bindingSource1, "FirstName", true , DataSourceUpdateMode.OnPropertyChanged);
            txtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            chkGender.DataBindings.Add("Checked", bindingSource1, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpDob.DataBindings.Add("Value", bindingSource1, "Dob", true, DataSourceUpdateMode.OnPropertyChanged);
            txtId.DataBindings.Add("Text", bindingSource1, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = $" FirstName like '%{toolStripTextBox1.Text}%'";
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBox1.Text = table.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            command.CommandText = "UpdateStudent";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirsName",txtFirsName.Text);
            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
            command.Parameters.AddWithValue("@Gender", chkGender.Checked);
            command.Parameters.AddWithValue("@Dob", dtpDob.Value);
            command.Parameters.AddWithValue("@Id", txtId.Text);
            con.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("suscess","info");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error");
            }
            finally { con.Close();
                command.Parameters.Clear();
            }

        }

        private void BtnUpdateAdapter_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            SqlCommandBuilder buler = new SqlCommandBuilder(adapter);
            buler.GetUpdateCommand();
            try
            {
                adapter.Update(ds.Tables[0]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
