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
    public partial class Personel_İnfo : Form
    {
                     
        AutoGalleryEntities3 db = new AutoGalleryEntities3();
        public Personel_İnfo()
        {
            InitializeComponent();
        }

        private void personel_list_Click(object sender, EventArgs e)
        {           
            personel_datagridview.DataSource = db.Personel.ToList();
            personel_datagridview.Columns[9].Visible = false;
            personel_datagridview.Columns[10].Visible = false;
        }

        private void Personel_İnfo_Load(object sender, EventArgs e)
        {
            personel_ıd.Enabled= false;
                     
        }

        private void add_personel_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Name = personel_name.Text;
            p.Surname = personel_surname.Text;
            p.Age = (personel_age.Text);
            p.Identification_Number = personel_ıdentıfıcatıon_number.Text;
            p.Mail = personel_mail.Text;
            p.Phone_Number = personel_phonenumber.Text;
            p.Adress = personel_adress.Text;
            p.Department_Id = int.Parse(personel_depertmentıd.Text);
            db.Personel.Add(p);
            db.SaveChanges();
            MessageBox.Show("Personnel Registration Successfully Completed","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);

            var nesneler = personel_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = personel_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            personel_datagridview.DataSource = db.Personel.ToList();
            personel_datagridview.Columns[9].Visible = false;
            personel_datagridview.Columns[10].Visible = false;
        }

        private void personel_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            personel_ıd.Text = personel_datagridview.CurrentRow.Cells[0].Value.ToString();
            personel_name.Text = personel_datagridview.CurrentRow.Cells[1].Value.ToString();
            personel_surname.Text = personel_datagridview.CurrentRow.Cells[2].Value.ToString();
            personel_age.Text = personel_datagridview.CurrentRow.Cells[3].Value.ToString();
            personel_ıdentıfıcatıon_number.Text = personel_datagridview.CurrentRow.Cells[4].Value.ToString();
            personel_mail.Text = personel_datagridview.CurrentRow.Cells[5].Value.ToString();
            personel_phonenumber.Text = personel_datagridview.CurrentRow.Cells[6].Value.ToString();
            personel_adress.Text = personel_datagridview.CurrentRow.Cells[7].Value.ToString();
            personel_depertmentıd.Text = personel_datagridview.CurrentRow.Cells[8].Value.ToString();

        }

        private void delete_personel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in personel_datagridview.SelectedRows)
            {
                int id = int.Parse(x.Cells[0].Value.ToString());
                var y = db.Personel.Find(id);
                db.Personel.Remove(y);
                db.SaveChanges();
                personel_datagridview.DataSource = db.Personel.ToList();
                personel_datagridview.Columns[9].Visible = false;
                personel_datagridview.Columns[10].Visible = false; //dbsavechangesunutma
            }
            var nesneler = personel_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = personel_ınfo.Controls.OfType<MaskedTextBox>();

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
            int id = int.Parse(personel_ıd.Text);
            var x = db.Personel.Find(id);
            x.Name = personel_name.Text;
            x.Surname = personel_surname.Text;
            x.Age = (personel_age.Text);
            x.Identification_Number = personel_ıdentıfıcatıon_number.Text;
            x.Mail = personel_mail.Text;
            x.Phone_Number = personel_phonenumber.Text;
            x.Adress = personel_adress.Text;
            x.Department_Id = int.Parse(personel_depertmentıd.Text);            
            db.SaveChanges();
            MessageBox.Show("Personnel Update Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var nesneler = personel_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = personel_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            personel_datagridview.DataSource = db.Personel.ToList();
            personel_datagridview.Columns[9].Visible = false;
            personel_datagridview.Columns[10].Visible = false;
        }
    }
}
