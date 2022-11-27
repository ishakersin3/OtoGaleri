using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriWinFormApp
{
    public partial class Sold_Car : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();
        public Sold_Car()
        {
            InitializeComponent();
        }

        private void Sold_Car_Load(object sender, EventArgs e)
        {
            var query = from x in db.Sale
                        join y in db.Car on x.Car_Id equals y.Id
                        join z in db.Department on x.Department_Id equals z.Id
                        join t in db.Customer on x.Customer_Id equals t.Id
                        join u in db.Personel on x.Personel_Id equals u.Id
                        select new
                        {
                            Process_Number = x.Id,
                            Process_Time = x.Sale_Time,
                            Process_Price = x.Sale_Price,
                            Process_Department=z.Name,
                            Personel_Name=u.Name_Surname,
                            Customer_Name_Surname = t.Name +" "+t.Surname,
                            Customer_Identification_Number = t.Identification_Number,
                            Car_Department_Id=y.Department_Id,
                            Car_Brand=y.Brand,
                            Car_Model=y.Model,
                            Car_Year=y.Year
                        };
            listcars.DataSource = query.ToList();
                        
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

        private void listcars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
