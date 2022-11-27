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
    public partial class Car_İnfo : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();
        public Car_İnfo()
        {
            InitializeComponent();
        }

        private void car_list_Click(object sender, EventArgs e)
        {
            
            car_datagridview.DataSource= db.Car.ToList();    
            car_datagridview.Columns[12].Visible=false;
            car_datagridview.Columns[13].Visible=false;
            
        }

        private void add_car_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            int a = 0;
            do
            {
                c.Price = car_price.Text;
                c.Stock = car_stock.Text;
                c.Brand = car_brand.Text;
                c.Model = car_model.Text;
                c.Year = car_year.Text;
                c.Gearbox = car_gearbox.Text;
                c.Engine_Volume = car_enginevolume.Text;
                c.Packet = car_packet.Text;
                c.Color = car_color.Text;
                c.Department_Id = int.Parse(car_depertmentıd.SelectedValue.ToString());
                c.Sale_Information = "On Sale";
                db.Car.Add(c);
                db.SaveChanges();
                a++;

            } while (a<int.Parse(car_stock.Text));
            
            
            MessageBox.Show("Car Add Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            car_datagridview.DataSource = db.Car.ToList();           
            car_datagridview.Columns[12].Visible = false;
            car_datagridview.Columns[13].Visible = false;           
            var nesneler = car_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = car_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }

        }

        private void delete_car_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in car_datagridview.SelectedRows)
            {
                int id = int.Parse(x.Cells[0].Value.ToString());
                var y = db.Car.Find(id);
                db.Car.Remove(y);
                db.SaveChanges();
                car_datagridview.DataSource = db.Car.ToList();
                MessageBox.Show("Car Delete Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
                //dbsavechangesunutma
            }
            var nesneler = car_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = car_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
        }

        private void car_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            car_ıd.Text = car_datagridview.CurrentRow.Cells[0].Value.ToString();
            car_price.Text = car_datagridview.CurrentRow.Cells[1].Value.ToString();
            car_stock.Text = car_datagridview.CurrentRow.Cells[2].Value.ToString();
            car_brand.Text = car_datagridview.CurrentRow.Cells[3].Value.ToString();
            car_model.Text = car_datagridview.CurrentRow.Cells[4].Value.ToString();
            car_year.Text = car_datagridview.CurrentRow.Cells[5].Value.ToString();
            car_gearbox.Text = car_datagridview.CurrentRow.Cells[6].Value.ToString();
            car_enginevolume.Text = car_datagridview.CurrentRow.Cells[7].Value.ToString();
            car_packet.Text = car_datagridview.CurrentRow.Cells[8].Value.ToString();
            car_color.Text = car_datagridview.CurrentRow.Cells[9].Value.ToString();
            car_depertmentıd.Text = car_datagridview.CurrentRow.Cells[10].Value.ToString();
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

        private void update_car_Click(object sender, EventArgs e)
        {            
            int id = int.Parse(car_ıd.Text);
            var x = db.Car.Find(id);
            x.Price = car_price.Text;
            x.Stock = car_stock.Text;
            x.Brand = car_brand.Text;
            x.Model = car_model.Text;
            x.Year = car_year.Text;
            x.Gearbox = car_gearbox.Text;
            x.Engine_Volume = car_enginevolume.Text;
            x.Packet = car_packet.Text;
            x.Color = car_color.Text;
            x.Department_Id = int.Parse(car_depertmentıd.Text);           
            db.SaveChanges();
            MessageBox.Show("Car Update Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            car_datagridview.DataSource = db.Car.ToList();
            
            car_datagridview.Columns[12].Visible = false;
            car_datagridview.Columns[13].Visible = false;
            
            var nesneler = car_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = car_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }

        }

        private void Car_İnfo_Load(object sender, EventArgs e)
        {
            using (AutoGalleryEntities9 db = new AutoGalleryEntities9())
            {
                car_depertmentıd.DataSource = db.Department.ToList();
                car_depertmentıd.ValueMember = "Id";
                car_depertmentıd.DisplayMember = "Name";
            }
            car_ıd.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nesneler = car_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            var nesneler1 = car_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            search_richtexbox.Clear();
            label9.Text = "Search:";
            label9.Location = new Point(588, 331);
        }

        private void search_richtexbox_TextChanged(object sender, EventArgs e)
        {
            label9.Location = new Point(560, 331);
            label9.Text = "Searching...";
            string search = search_richtexbox.Text;
            var value = from x in db.Car
                        where x.Price.Contains(search) ||
                         x.Stock.ToString().Contains(search) ||
                         x.Brand.Contains(search) ||
                         x.Model.Contains(search) ||
                         x.Year.Contains(search) ||
                         x.Gearbox.Contains(search) ||
                         x.Engine_Volume.Contains(search) ||
                         x.Color.Contains(search) ||
                         x.Packet.Contains(search) ||
                         x.Sale_Information.Contains(search) ||
                         x.Department_Id.ToString().Contains(search)
                        select x;
            car_datagridview.DataSource = value.ToList();

            car_datagridview.Columns[12].Visible = false;
            car_datagridview.Columns[13].Visible = false;
            if (search_richtexbox.Text == "")
            {
                label9.Text = "Search:";
                label9.Location = new Point(588, 331);
            }
        }
    }
}
