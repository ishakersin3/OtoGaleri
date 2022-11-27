using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OtoGaleriWinFormApp
{
    public partial class Customer_İnfo : Form
    {
        AutoGalleryEntities3 db = new AutoGalleryEntities3();
        public Customer_İnfo()
        {
            InitializeComponent();
        }

        private void customer_list_Click(object sender, EventArgs e)
        {
            AutoGalleryEntities3 db = new AutoGalleryEntities3();
            customer_datagridview.DataSource = db.Customer.ToList();
            customer_datagridview.Columns[7].Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_customer_Click(object sender, EventArgs e)
        {

            Customer c = new Customer();
            c.Name = customer_name.Text;
            c.Surname = customer_surname.Text;
            c.Identification_Number = customerıdentıfıcatıon_number.Text;
            c.Mail = customer_mail.Text;
            c.Phone_Number = customer_phonenumber.Text;
            c.Adress = customer_adress.Text;
            db.Customer.Add(c);
            db.SaveChanges();
            MessageBox.Show("Customer Registration Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var nesneler = customer_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = customer_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            customer_datagridview.DataSource = db.Customer.ToList();
            customer_datagridview.Columns[7].Visible = false;


        }



        private void Customer_İnfo_Load(object sender, EventArgs e)
        {
            customer_ıd.Enabled = false;
        }

        private void customer_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_ıd.Text = customer_datagridview.CurrentRow.Cells[0].Value.ToString();
            customer_name.Text = customer_datagridview.CurrentRow.Cells[1].Value.ToString();
            customer_surname.Text = customer_datagridview.CurrentRow.Cells[2].Value.ToString();
            customerıdentıfıcatıon_number.Text = customer_datagridview.CurrentRow.Cells[3].Value.ToString();
            customer_mail.Text = customer_datagridview.CurrentRow.Cells[4].Value.ToString();
            customer_phonenumber.Text = customer_datagridview.CurrentRow.Cells[5].Value.ToString();
            customer_adress.Text = customer_datagridview.CurrentRow.Cells[6].Value.ToString();
        }

        private void delete_customer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in customer_datagridview.SelectedRows)
            {
                int id = int.Parse(x.Cells[0].Value.ToString());
                var y = db.Customer.Find(id);
                db.Customer.Remove(y);
                db.SaveChanges();
                MessageBox.Show("Customer Deletion Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customer_datagridview.DataSource = db.Customer.ToList();
                customer_datagridview.Columns[7].Visible = false; //dbsavechangesunutma
            }
            var nesneler = customer_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = customer_ınfo.Controls.OfType<MaskedTextBox>();

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

        private void update_customer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(customer_ıd.Text);
            var x = db.Customer.Find(id);
            x.Name = customer_name.Text;
            x.Surname = customer_surname.Text;
            x.Identification_Number = customerıdentıfıcatıon_number.Text;
            x.Mail = customer_mail.Text;
            x.Phone_Number = customer_phonenumber.Text;
            x.Adress = customer_adress.Text;
            db.SaveChanges();
            MessageBox.Show("Customer Updating Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var nesneler = customer_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = customer_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            customer_datagridview.DataSource = db.Customer.ToList();
            customer_datagridview.Columns[7].Visible = false;

        }
    }
}
