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
    public partial class Report_Screen : Form
    {
        AutoGalleryEntities9 db = new AutoGalleryEntities9();
        public Report_Screen()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (radioButtonexpensivelist.Checked==true)
            {
                List<Car> listexpensive = db.Car.OrderByDescending(x=>x.Price).ToList();
                car_datagridview.DataSource = listexpensive;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }                     

            if (radioButtonnewlist.Checked==true)
            {
                List<Car> listnew = db.Car.OrderBy(x => x.Year).ToList();
                car_datagridview.DataSource = listnew;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }
            if (radioButtonlistpersonel.Checked==true)
            {
                List<Personel> listold = db.Personel.OrderBy(x => x.Age).ToList();
                car_datagridview.DataSource = listold;
                car_datagridview.Columns[8].Visible = false;
                car_datagridview.Columns[9].Visible = false;
            }
            if(radioButtonlistendorsement.Checked==true)
            {
                List<Department> listendorsement = db.Department.OrderByDescending(x=>x.Endorsement).ToList();
                car_datagridview.DataSource = listendorsement;
                car_datagridview.Columns[4].Visible = false;
                car_datagridview.Columns[5].Visible = false;
                car_datagridview.Columns[6].Visible = false;
            }
            if (radioButtonsortstock.Checked==true)
            {
                List<Car> listcar = db.Car.OrderBy(x => x.Stock).ToList();
                car_datagridview.DataSource = listcar;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }
            if (radioButtonlistenginevolume.Checked == true)
            {
                List<Car> listenginevolume = db.Car.OrderByDescending(x => x.Engine_Volume).ToList();
                car_datagridview.DataSource = listenginevolume;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }
            if (radioButtonyilanedition.Checked==true)
            {
                List<Car> listyilanedition = db.Car.Where(x => x.Packet.StartsWith("YılanEdition")).ToList();
                car_datagridview.DataSource = listyilanedition;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }
            if (radioButtonshowbmw.Checked == true)
            {
                List<Car> listBMW = db.Car.Where(x => x.Brand.StartsWith("BMW")).ToList();
                car_datagridview.DataSource = listBMW;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
            }
            if (radioButtondepartment7.Checked==true)
            {
                List<Personel> personel7 = db.Personel.Where(x => x.Department_Id == 7).ToList();
                car_datagridview.DataSource = personel7;
                car_datagridview.Columns[8].Visible = false;
                car_datagridview.Columns[9].Visible = false;
            }
            if (radioButtondepartment6.Checked == true)
            {
                List<Car> car7 = db.Car.Where(x => x.Department_Id == 6).ToList();
                car_datagridview.DataSource = car7;
                car_datagridview.Columns[12].Visible = false;
                car_datagridview.Columns[13].Visible = false;
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

        private void radioButtondepartment6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
