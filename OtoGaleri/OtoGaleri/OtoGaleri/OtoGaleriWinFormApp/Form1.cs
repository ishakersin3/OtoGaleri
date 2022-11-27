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
    public partial class Enter_Form : Form
    {
        public Enter_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            register_groupbox.Visible=false;
            
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            register_groupbox.Visible= true;
            car_photo_picturebox.Size = new System.Drawing.Size(306,170);
            car_photo_picturebox.Location = new System.Drawing.Point(770, 110);
            
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Select_Section frm = new Select_Section();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
