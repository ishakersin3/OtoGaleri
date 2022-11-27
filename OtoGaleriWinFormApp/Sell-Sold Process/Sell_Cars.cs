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
    public partial class Sell_Cars : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();
        public Sell_Cars()
        {
            InitializeComponent();
        }

        private void Sell_Cars_Load(object sender, EventArgs e)
        {
            
            List<Car> cars = db.Car.Where(x => x.Sale_Information == "On Sale").ToList();
            listcars.DataSource = cars.ToList();
            listcars.Columns[12].Visible = false;
            listcars.Columns[13].Visible = false;
            car_ınfox.Enabled=false;
            customer_ınfo.Enabled=false;
            customer_ıd.Enabled = false;
            list_customers.DataSource = db.Customer.ToList();
            list_customers.Columns[7].Visible = false;                        
            label15.Enabled = false;
            label19.Enabled = false;
            personel_ıd.Enabled = false;
            personel_ıdentıfıcatıonnumber.Enabled = false;

           
            using (AutoGalleryEntities9 db = new AutoGalleryEntities9())
            {
                personel_name_surnamex.DataSource = db.Personel.ToList();
                personel_name_surnamex.ValueMember = "Id";
                personel_name_surnamex.DisplayMember = "Name_Surname";
            }
        }

        private void listcars_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (car_ınfox.Enabled==true)
            {
                car_ıd.Text = listcars.CurrentRow.Cells[0].Value.ToString();
                car_price.Text = listcars.CurrentRow.Cells[1].Value.ToString();
                car_brand.Text = listcars.CurrentRow.Cells[3].Value.ToString();
                car_model.Text = listcars.CurrentRow.Cells[4].Value.ToString();
                car_year.Text = listcars.CurrentRow.Cells[5].Value.ToString();
                car_packet.Text = listcars.CurrentRow.Cells[8].Value.ToString();
                car_department_ıd.Text = listcars.CurrentRow.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Customer İnformation", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var nesneler = car_ınfox.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }

            var nesneler1 = customer_ınfo.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler1)
            {
                nesne.Clear();
            }
            var nesneler2 = customer_ınfo.Controls.OfType<MaskedTextBox>();

            foreach (var nesne in nesneler2)
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

        private void sell_Click(object sender, EventArgs e)
        {
            int id = int.Parse(car_ıd.Text);
            var x = db.Car.Find(id);
            x.Sale_Information = "Sold";

            //var query = db.Car.FirstOrDefault(y => y.Model == car_model.Text);
            //int a = query.Id;
            //var z = db.Car.Find(a);
            //var l = int.Parse(z.Stock) - 1;
            //z.Stock = l.ToString();

            db.SaveChanges();
            Sale sa = new Sale();
            sa.Personel_Id = int.Parse(personel_ıd.Text); 
            sa.Car_Id = int.Parse(car_ıd.Text);                                   
            sa.Customer_Id = int.Parse(customer_ıd.Text);
            sa.Department_Id = int.Parse(car_department_ıd.Text);
            sa.Sale_Price = (car_price.Text);
            
            sa.Sale_Time = DateTime.Now.ToLongDateString();
            db.Sale.Add(sa);
            db.SaveChanges();
            MessageBox.Show("Car Sale Successfully Completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var nesneler = car_ınfox.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            List<Car> cars = db.Car.Where(q => q.Sale_Information == "On Sale").ToList();
            listcars.DataSource = cars.ToList();
            listcars.Columns[12].Visible = false;
            listcars.Columns[13].Visible = false;     

        }

        private void list_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customer_ınfo.Enabled==true)
            {
                customer_ıd.Text = list_customers.CurrentRow.Cells[0].Value.ToString();
                customer_name.Text = list_customers.CurrentRow.Cells[1].Value.ToString();
                customer_surname.Text = list_customers.CurrentRow.Cells[2].Value.ToString();
                customerıdentıfıcatıon_number.Text = list_customers.CurrentRow.Cells[3].Value.ToString();
                customer_mail.Text = list_customers.CurrentRow.Cells[4].Value.ToString();
                customer_phonenumber.Text = list_customers.CurrentRow.Cells[5].Value.ToString();
                customer_adress.Text = list_customers.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter Personel İnformation","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            car_ınfox.Enabled = true;
            car_ıd.Enabled = false;
            Customer c = new Customer();
            c.Name = customer_name.Text;
            c.Surname = customer_surname.Text;
            c.Identification_Number = customerıdentıfıcatıon_number.Text;
            c.Mail = customer_mail.Text;
            c.Phone_Number = customer_phonenumber.Text;
            c.Adress = customer_adress.Text;
            db.Customer.Add(c);
            db.SaveChanges();
            var query = db.Customer.FirstOrDefault(y => y.Identification_Number == customerıdentıfıcatıon_number.Text);
            customer_ıd.Text = query.Id + " ";
        }

        private void customer_ıd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            customer_ınfo.Enabled = true;
        }

        private void personel_name_surname_MouseMove(object sender, MouseEventArgs e)
        {
            var query = db.Personel.FirstOrDefault(z => z.Name_Surname == personel_name_surnamex.Text);
            personel_ıd.Text = query.Id + " ";

            var query2 = db.Personel.FirstOrDefault(t => t.Name_Surname == personel_name_surnamex.Text);
            personel_ıdentıfıcatıonnumber.Text = query2.Identification_Number + " ";

        }

        private void personel_name_surnamex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
