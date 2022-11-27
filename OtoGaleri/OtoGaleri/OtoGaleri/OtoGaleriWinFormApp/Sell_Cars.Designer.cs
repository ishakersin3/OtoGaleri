namespace OtoGaleriWinFormApp
{
    partial class Sell_Cars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell_Cars));
            this.listcars = new System.Windows.Forms.DataGridView();
            this.car_ınfox = new System.Windows.Forms.GroupBox();
            this.car_ıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.car_department_ıd = new System.Windows.Forms.TextBox();
            this.car_packet = new System.Windows.Forms.TextBox();
            this.car_model = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.car_brand = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.car_year = new System.Windows.Forms.TextBox();
            this.car_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.list_customers = new System.Windows.Forms.DataGridView();
            this.customer_ınfo = new System.Windows.Forms.GroupBox();
            this.customer_ıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_phonenumber = new System.Windows.Forms.MaskedTextBox();
            this.customerıdentıfıcatıon_number = new System.Windows.Forms.MaskedTextBox();
            this.customer_adress = new System.Windows.Forms.TextBox();
            this.customer_mail = new System.Windows.Forms.TextBox();
            this.customer_surname = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.personel_ıd = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listcars)).BeginInit();
            this.car_ınfox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_customers)).BeginInit();
            this.customer_ınfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listcars
            // 
            this.listcars.BackgroundColor = System.Drawing.Color.White;
            this.listcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listcars.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.listcars.Location = new System.Drawing.Point(2, 0);
            this.listcars.Name = "listcars";
            this.listcars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.listcars.Size = new System.Drawing.Size(621, 95);
            this.listcars.TabIndex = 18;
            this.listcars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listcars_datagridview_CellContentClick);
            // 
            // car_ınfox
            // 
            this.car_ınfox.Controls.Add(this.car_ıd);
            this.car_ınfox.Controls.Add(this.label7);
            this.car_ınfox.Controls.Add(this.car_department_ıd);
            this.car_ınfox.Controls.Add(this.car_packet);
            this.car_ınfox.Controls.Add(this.car_model);
            this.car_ınfox.Controls.Add(this.label13);
            this.car_ınfox.Controls.Add(this.label11);
            this.car_ınfox.Controls.Add(this.car_brand);
            this.car_ınfox.Controls.Add(this.label10);
            this.car_ınfox.Controls.Add(this.car_year);
            this.car_ınfox.Controls.Add(this.car_price);
            this.car_ınfox.Controls.Add(this.label4);
            this.car_ınfox.Controls.Add(this.label3);
            this.car_ınfox.Controls.Add(this.label1);
            this.car_ınfox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.car_ınfox.Location = new System.Drawing.Point(290, 207);
            this.car_ınfox.Name = "car_ınfox";
            this.car_ınfox.Size = new System.Drawing.Size(300, 247);
            this.car_ınfox.TabIndex = 19;
            this.car_ınfox.TabStop = false;
            this.car_ınfox.Text = "Car İnformation";
            // 
            // car_ıd
            // 
            this.car_ıd.Location = new System.Drawing.Point(64, 21);
            this.car_ıd.Name = "car_ıd";
            this.car_ıd.Size = new System.Drawing.Size(225, 22);
            this.car_ıd.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Id:";
            // 
            // car_department_ıd
            // 
            this.car_department_ıd.Location = new System.Drawing.Point(120, 203);
            this.car_department_ıd.Name = "car_department_ıd";
            this.car_department_ıd.Size = new System.Drawing.Size(169, 22);
            this.car_department_ıd.TabIndex = 31;
            // 
            // car_packet
            // 
            this.car_packet.Location = new System.Drawing.Point(71, 172);
            this.car_packet.Name = "car_packet";
            this.car_packet.Size = new System.Drawing.Size(218, 22);
            this.car_packet.TabIndex = 29;
            // 
            // car_model
            // 
            this.car_model.Location = new System.Drawing.Point(64, 112);
            this.car_model.Name = "car_model";
            this.car_model.Size = new System.Drawing.Size(225, 22);
            this.car_model.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Department Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Packet:";
            // 
            // car_brand
            // 
            this.car_brand.Location = new System.Drawing.Point(64, 79);
            this.car_brand.Name = "car_brand";
            this.car_brand.Size = new System.Drawing.Size(225, 22);
            this.car_brand.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Brand:";
            // 
            // car_year
            // 
            this.car_year.Location = new System.Drawing.Point(64, 142);
            this.car_year.Name = "car_year";
            this.car_year.Size = new System.Drawing.Size(225, 22);
            this.car_year.TabIndex = 16;
            // 
            // car_price
            // 
            this.car_price.Location = new System.Drawing.Point(64, 51);
            this.car_price.Name = "car_price";
            this.car_price.Size = new System.Drawing.Size(225, 22);
            this.car_price.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Price:";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(596, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 104);
            this.button3.TabIndex = 20;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(686, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 111);
            this.button2.TabIndex = 27;
            this.button2.Text = "EXİT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(686, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 111);
            this.button1.TabIndex = 26;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(596, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 104);
            this.button4.TabIndex = 28;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // list_customers
            // 
            this.list_customers.BackgroundColor = System.Drawing.Color.White;
            this.list_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_customers.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.list_customers.Location = new System.Drawing.Point(2, 101);
            this.list_customers.Name = "list_customers";
            this.list_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.list_customers.Size = new System.Drawing.Size(799, 95);
            this.list_customers.TabIndex = 30;
            this.list_customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_customers_CellContentClick);
            // 
            // customer_ınfo
            // 
            this.customer_ınfo.Controls.Add(this.customer_ıd);
            this.customer_ınfo.Controls.Add(this.label2);
            this.customer_ınfo.Controls.Add(this.customer_phonenumber);
            this.customer_ınfo.Controls.Add(this.customerıdentıfıcatıon_number);
            this.customer_ınfo.Controls.Add(this.customer_adress);
            this.customer_ınfo.Controls.Add(this.customer_mail);
            this.customer_ınfo.Controls.Add(this.customer_surname);
            this.customer_ınfo.Controls.Add(this.customer_name);
            this.customer_ınfo.Controls.Add(this.label6);
            this.customer_ınfo.Controls.Add(this.label5);
            this.customer_ınfo.Controls.Add(this.label8);
            this.customer_ınfo.Controls.Add(this.label9);
            this.customer_ınfo.Controls.Add(this.label12);
            this.customer_ınfo.Controls.Add(this.label14);
            this.customer_ınfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_ınfo.Location = new System.Drawing.Point(2, 207);
            this.customer_ınfo.Name = "customer_ınfo";
            this.customer_ınfo.Size = new System.Drawing.Size(282, 247);
            this.customer_ınfo.TabIndex = 31;
            this.customer_ınfo.TabStop = false;
            this.customer_ınfo.Text = "Customer İnformation";
            // 
            // customer_ıd
            // 
            this.customer_ıd.Location = new System.Drawing.Point(64, 21);
            this.customer_ıd.Name = "customer_ıd";
            this.customer_ıd.Size = new System.Drawing.Size(205, 22);
            this.customer_ıd.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id:";
            // 
            // customer_phonenumber
            // 
            this.customer_phonenumber.Location = new System.Drawing.Point(125, 184);
            this.customer_phonenumber.Mask = "(999) 000-0000";
            this.customer_phonenumber.Name = "customer_phonenumber";
            this.customer_phonenumber.Size = new System.Drawing.Size(144, 22);
            this.customer_phonenumber.TabIndex = 19;
            // 
            // customerıdentıfıcatıon_number
            // 
            this.customerıdentıfıcatıon_number.Location = new System.Drawing.Point(160, 119);
            this.customerıdentıfıcatıon_number.Mask = "00000000000";
            this.customerıdentıfıcatıon_number.Name = "customerıdentıfıcatıon_number";
            this.customerıdentıfıcatıon_number.Size = new System.Drawing.Size(109, 22);
            this.customerıdentıfıcatıon_number.TabIndex = 16;
            // 
            // customer_adress
            // 
            this.customer_adress.Location = new System.Drawing.Point(64, 218);
            this.customer_adress.Name = "customer_adress";
            this.customer_adress.Size = new System.Drawing.Size(205, 22);
            this.customer_adress.TabIndex = 18;
            // 
            // customer_mail
            // 
            this.customer_mail.Location = new System.Drawing.Point(52, 152);
            this.customer_mail.Name = "customer_mail";
            this.customer_mail.Size = new System.Drawing.Size(217, 22);
            this.customer_mail.TabIndex = 16;
            // 
            // customer_surname
            // 
            this.customer_surname.Location = new System.Drawing.Point(84, 82);
            this.customer_surname.Name = "customer_surname";
            this.customer_surname.Size = new System.Drawing.Size(185, 22);
            this.customer_surname.TabIndex = 14;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(64, 51);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(205, 22);
            this.customer_name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Identification Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Surname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(629, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Personel İnformation";
            // 
            // personel_ıd
            // 
            this.personel_ıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_ıd.FormattingEnabled = true;
            this.personel_ıd.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "11"});
            this.personel_ıd.Location = new System.Drawing.Point(632, 28);
            this.personel_ıd.Name = "personel_ıd";
            this.personel_ıd.Size = new System.Drawing.Size(146, 37);
            this.personel_ıd.TabIndex = 32;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(86, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 40);
            this.button5.TabIndex = 33;
            this.button5.Text = "Ok";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Sell_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 498);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.personel_ıd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.customer_ınfo);
            this.Controls.Add(this.list_customers);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.car_ınfox);
            this.Controls.Add(this.listcars);
            this.Name = "Sell_Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Cars";
            this.Load += new System.EventHandler(this.Sell_Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listcars)).EndInit();
            this.car_ınfox.ResumeLayout(false);
            this.car_ınfox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_customers)).EndInit();
            this.customer_ınfo.ResumeLayout(false);
            this.customer_ınfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listcars;
        private System.Windows.Forms.GroupBox car_ınfox;
        private System.Windows.Forms.TextBox car_ıd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox car_department_ıd;
        private System.Windows.Forms.TextBox car_packet;
        private System.Windows.Forms.TextBox car_model;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox car_brand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox car_year;
        private System.Windows.Forms.TextBox car_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView list_customers;
        private System.Windows.Forms.GroupBox customer_ınfo;
        private System.Windows.Forms.TextBox customer_ıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox customer_phonenumber;
        private System.Windows.Forms.MaskedTextBox customerıdentıfıcatıon_number;
        private System.Windows.Forms.TextBox customer_adress;
        private System.Windows.Forms.TextBox customer_mail;
        private System.Windows.Forms.TextBox customer_surname;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox personel_ıd;
        private System.Windows.Forms.Button button5;
    }
}