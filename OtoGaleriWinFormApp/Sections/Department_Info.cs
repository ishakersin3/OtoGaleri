using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriWinFormApp
{
    public partial class Department_Info : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();
        public Department_Info()
        {
            InitializeComponent();
        }

        private void car_list_Click(object sender, EventArgs e)
        {

            department_datagridview.DataSource=db.Department.ToList();
            department_datagridview.Columns[4].Visible = false;
            department_datagridview.Columns[5].Visible = false;
            department_datagridview.Columns[6].Visible = false;
        }

        private void add_departments_Click(object sender, EventArgs e)
        {
            
            Department d= new Department();
            d.Name = department_name.Text;
            d.Personels_Number = department_personelnumber.Text;
            d.Endorsement = department_endorsement.Text;
            db.Department.Add(d);
            db.SaveChanges();

            MessageBox.Show("Department Registration Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            department_datagridview.DataSource = db.Department.ToList();
            department_datagridview.Columns[4].Visible = false;
            department_datagridview.Columns[5].Visible = false;
            department_datagridview.Columns[6].Visible = false;

            var nesneler = deparment_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
                       
        }

        private void department_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            department_ıd.Text = department_datagridview.CurrentRow.Cells[0].Value.ToString();
            department_name.Text = department_datagridview.CurrentRow.Cells[1].Value.ToString();
            department_personelnumber.Text = department_datagridview.CurrentRow.Cells[2].Value.ToString();
            department_endorsement.Text = department_datagridview.CurrentRow.Cells[3].Value.ToString();
        }

        private void Department_Info_Load(object sender, EventArgs e)
        {
            department_ıd.Enabled= false;
        }

        private void delete_departments_Click(object sender, EventArgs e)
        {
            int id = int.Parse(department_ıd.Text);
            var x = db.Department.Find(id);
            db.Department.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Department Deletion Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            department_datagridview.DataSource = db.Department.ToList();
            department_datagridview.Columns[4].Visible = false;
            department_datagridview.Columns[5].Visible = false;
            department_datagridview.Columns[6].Visible = false;
            

            var nesneler = deparment_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = deparment_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_Section selsec = new Select_Section();
            selsec.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enter_Form enter = new Enter_Form();
            enter.Show();
            this.Close();
        }

        private void update_personel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(department_ıd.Text);
            var x = db.Department.Find(id);
            x.Name = department_name.Text;
            x.Personels_Number = department_personelnumber.Text;
            x.Endorsement = department_endorsement.Text;
            
            db.SaveChanges();

            MessageBox.Show("Department Update Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            department_datagridview.DataSource = db.Department.ToList();
            department_datagridview.Columns[4].Visible = false;
            department_datagridview.Columns[5].Visible = false;
            department_datagridview.Columns[6].Visible = false;

            var nesneler = deparment_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nesneler = deparment_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            search_richtexbox.Clear();
            label9.Text = "Search:";
            label9.Location = new Point(212, 224);
        }

        private void search_richtexbox_TextChanged(object sender, EventArgs e)
        {
            label9.Location = new Point(186, 224);
            label9.Text = "Searching...";
            string search = search_richtexbox.Text;
            var value = from x in db.Department
                        where x.Name.Contains(search) ||
                         x.Personels_Number.ToString().Contains(search) ||
                         x.Id.ToString().Contains(search) 
                         
                        select x;
            department_datagridview.DataSource = value.ToList();

            //department_datagridview.Columns[12].Visible = false;
            //department_datagridview.Columns[13].Visible = false;
            if (search_richtexbox.Text == "")
            {
                label9.Text = "Search:";
                label9.Location = new Point(212, 224);
            }
        }
    }
}
