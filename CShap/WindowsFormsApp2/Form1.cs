using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //CShapEntities ef = new CShapEntities();
            //dataGridView1.DataSource = ef.Students.ToList();
            using (var ef = new CShapEntities())
            {
                bindingSource1.DataSource  = await ef.Students.ToListAsync();
                bindingNavigator1.BindingSource = bindingSource1;
                dataGridView1.DataSource = bindingSource1;
                txtId.DataBindings.Add("Text", bindingSource1, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
                txtFirsName.DataBindings.Add("Text", bindingSource1, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
                txtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
                ChbGender.DataBindings.Add("Checked", bindingSource1, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
                dateDob.DataBindings.Add("Value", bindingSource1, "Dob", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new CShapEntities())
            {
                var id = Convert.ToInt32(txtId.Text);
                var obj = await ef.Students.FirstOrDefaultAsync(i => i.Id == id);
                if(obj != null)
                {
                    obj.FirstName = txtFirsName.Text;
                    obj.LastName = txtLastName.Text;
                    obj.Gender = ChbGender.Checked;
                    obj.Dob = dateDob.Value; 
                }
                // xong hết mới update
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("seccess", "info");
            }
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var ef = new CShapEntities())
            {
                var stu = new Student();
                stu.FirstName = txtFirsName.Text;
                stu.LastName = txtLastName.Text;
                stu.Gender = ChbGender.Checked;
                stu.Dob = dateDob.Value;
                ef.Students.Add(stu);
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("seccess", "info");
            }
        }

        private async void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (var ef = new CShapEntities())
            {
                var id = Convert.ToInt32(txtId.Text);
                foreach (var stu in ef.Students)
                {
                    if(stu.Id == id)
                    {
                        ef.Students.Remove(stu);
                    }
                }
                ef.Students.RemoveRange(i => ef.Students.Where(t => t.Id == id).AsEnumerable());
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("seccess", "info");
            }
        }
    }
}
