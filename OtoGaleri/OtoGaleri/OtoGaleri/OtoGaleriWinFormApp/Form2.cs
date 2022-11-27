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
    public partial class Select_Section : Form
    {
        public Select_Section()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerınfo_button_Click(object sender, EventArgs e)
        {
            Customer_İnfo cstmrınf = new Customer_İnfo();
            cstmrınf.Show();
            this.Hide();
        }

        private void personelınfo_button_Click(object sender, EventArgs e)
        {
            Personel_İnfo prsinf = new Personel_İnfo();
            prsinf.Show();
            this.Hide();
        }

        private void carınfo_button_Click(object sender, EventArgs e)
        {
            Car_İnfo crinf = new Car_İnfo();
            crinf.Show();
            this.Hide();
        }

        private void departmanınfo_button_Click(object sender, EventArgs e)
        {
            Department_Info deprtınf = new Department_Info();
            deprtınf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_Form enter = new Enter_Form();
            enter.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enter_Form enter = new Enter_Form();
            enter.Show();
            this.Close();
        }

        private void Select_Section_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sell_Cars sc = new Sell_Cars();
            sc.Show();
            this.Close();
        }
    }
}
