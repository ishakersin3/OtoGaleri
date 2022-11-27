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
    public partial class On_Sale : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();

        public On_Sale()
        {
            InitializeComponent();
        }

        private void On_Sale_Load(object sender, EventArgs e)
        {
            List<Car> cars = db.Car.Where(x => x.Sale_Information == "On Sale").ToList();
            listcars.DataSource = cars.ToList();
            listcars.Columns[12].Visible = false;
            listcars.Columns[13].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enter_Form enter = new Enter_Form();
            enter.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_Section selsec = new Select_Section();
            selsec.Show();
            this.Close();
        }
    }
}
