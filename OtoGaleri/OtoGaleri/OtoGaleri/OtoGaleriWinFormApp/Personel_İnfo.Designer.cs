namespace OtoGaleriWinFormApp
{
    partial class Personel_İnfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_İnfo));
            this.update_personel = new System.Windows.Forms.Button();
            this.delete_personel = new System.Windows.Forms.Button();
            this.add_personel = new System.Windows.Forms.Button();
            this.personel_list = new System.Windows.Forms.Button();
            this.personel_datagridview = new System.Windows.Forms.DataGridView();
            this.personel_ınfo = new System.Windows.Forms.GroupBox();
            this.personel_depertmentıd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.personel_age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.personel_phonenumber = new System.Windows.Forms.MaskedTextBox();
            this.personel_ıdentıfıcatıon_number = new System.Windows.Forms.MaskedTextBox();
            this.personel_adress = new System.Windows.Forms.TextBox();
            this.personel_mail = new System.Windows.Forms.TextBox();
            this.personel_name = new System.Windows.Forms.TextBox();
            this.personel_surname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.personel_ıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personel_datagridview)).BeginInit();
            this.personel_ınfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_personel
            // 
            this.update_personel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_personel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_personel.Location = new System.Drawing.Point(12, 219);
            this.update_personel.Name = "update_personel";
            this.update_personel.Size = new System.Drawing.Size(131, 43);
            this.update_personel.TabIndex = 8;
            this.update_personel.Text = "Update Personel";
            this.update_personel.UseVisualStyleBackColor = false;
            this.update_personel.Click += new System.EventHandler(this.update_personel_Click);
            // 
            // delete_personel
            // 
            this.delete_personel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_personel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_personel.Location = new System.Drawing.Point(12, 155);
            this.delete_personel.Name = "delete_personel";
            this.delete_personel.Size = new System.Drawing.Size(131, 43);
            this.delete_personel.TabIndex = 7;
            this.delete_personel.Text = "Delete Personel";
            this.delete_personel.UseVisualStyleBackColor = false;
            this.delete_personel.Click += new System.EventHandler(this.delete_personel_Click);
            // 
            // add_personel
            // 
            this.add_personel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_personel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_personel.Location = new System.Drawing.Point(12, 91);
            this.add_personel.Name = "add_personel";
            this.add_personel.Size = new System.Drawing.Size(131, 43);
            this.add_personel.TabIndex = 6;
            this.add_personel.Text = "Add Personel";
            this.add_personel.UseVisualStyleBackColor = false;
            this.add_personel.Click += new System.EventHandler(this.add_personel_Click);
            // 
            // personel_list
            // 
            this.personel_list.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.personel_list.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_list.Location = new System.Drawing.Point(12, 27);
            this.personel_list.Name = "personel_list";
            this.personel_list.Size = new System.Drawing.Size(131, 43);
            this.personel_list.TabIndex = 5;
            this.personel_list.Text = "List Personels";
            this.personel_list.UseVisualStyleBackColor = false;
            this.personel_list.Click += new System.EventHandler(this.personel_list_Click);
            // 
            // personel_datagridview
            // 
            this.personel_datagridview.BackgroundColor = System.Drawing.Color.White;
            this.personel_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personel_datagridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.personel_datagridview.Location = new System.Drawing.Point(-2, 307);
            this.personel_datagridview.Name = "personel_datagridview";
            this.personel_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personel_datagridview.Size = new System.Drawing.Size(803, 153);
            this.personel_datagridview.TabIndex = 9;
            this.personel_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personel_datagridview_CellContentClick);
            // 
            // personel_ınfo
            // 
            this.personel_ınfo.Controls.Add(this.label7);
            this.personel_ınfo.Controls.Add(this.personel_ıd);
            this.personel_ınfo.Controls.Add(this.personel_depertmentıd);
            this.personel_ınfo.Controls.Add(this.label11);
            this.personel_ınfo.Controls.Add(this.personel_age);
            this.personel_ınfo.Controls.Add(this.label10);
            this.personel_ınfo.Controls.Add(this.personel_phonenumber);
            this.personel_ınfo.Controls.Add(this.personel_ıdentıfıcatıon_number);
            this.personel_ınfo.Controls.Add(this.personel_adress);
            this.personel_ınfo.Controls.Add(this.personel_mail);
            this.personel_ınfo.Controls.Add(this.personel_name);
            this.personel_ınfo.Controls.Add(this.personel_surname);
            this.personel_ınfo.Controls.Add(this.label6);
            this.personel_ınfo.Controls.Add(this.label5);
            this.personel_ınfo.Controls.Add(this.label4);
            this.personel_ınfo.Controls.Add(this.label2);
            this.personel_ınfo.Controls.Add(this.label3);
            this.personel_ınfo.Controls.Add(this.label1);
            this.personel_ınfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_ınfo.Location = new System.Drawing.Point(162, 11);
            this.personel_ınfo.Name = "personel_ınfo";
            this.personel_ınfo.Size = new System.Drawing.Size(302, 290);
            this.personel_ınfo.TabIndex = 10;
            this.personel_ınfo.TabStop = false;
            this.personel_ınfo.Text = "Personel İnformation";
            // 
            // personel_depertmentıd
            // 
            this.personel_depertmentıd.FormattingEnabled = true;
            this.personel_depertmentıd.Location = new System.Drawing.Point(116, 259);
            this.personel_depertmentıd.Name = "personel_depertmentıd";
            this.personel_depertmentıd.Size = new System.Drawing.Size(180, 24);
            this.personel_depertmentıd.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Department Id:";
            // 
            // personel_age
            // 
            this.personel_age.Location = new System.Drawing.Point(51, 110);
            this.personel_age.Name = "personel_age";
            this.personel_age.Size = new System.Drawing.Size(245, 22);
            this.personel_age.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Age:";
            // 
            // personel_phonenumber
            // 
            this.personel_phonenumber.Location = new System.Drawing.Point(125, 197);
            this.personel_phonenumber.Mask = "(999) 000-0000";
            this.personel_phonenumber.Name = "personel_phonenumber";
            this.personel_phonenumber.Size = new System.Drawing.Size(171, 22);
            this.personel_phonenumber.TabIndex = 19;
            // 
            // personel_ıdentıfıcatıon_number
            // 
            this.personel_ıdentıfıcatıon_number.Location = new System.Drawing.Point(169, 140);
            this.personel_ıdentıfıcatıon_number.Mask = "00000000000";
            this.personel_ıdentıfıcatıon_number.Name = "personel_ıdentıfıcatıon_number";
            this.personel_ıdentıfıcatıon_number.Size = new System.Drawing.Size(127, 22);
            this.personel_ıdentıfıcatıon_number.TabIndex = 16;
            // 
            // personel_adress
            // 
            this.personel_adress.Location = new System.Drawing.Point(64, 230);
            this.personel_adress.Name = "personel_adress";
            this.personel_adress.Size = new System.Drawing.Size(232, 22);
            this.personel_adress.TabIndex = 18;
            // 
            // personel_mail
            // 
            this.personel_mail.Location = new System.Drawing.Point(52, 170);
            this.personel_mail.Name = "personel_mail";
            this.personel_mail.Size = new System.Drawing.Size(244, 22);
            this.personel_mail.TabIndex = 16;
            // 
            // personel_name
            // 
            this.personel_name.Location = new System.Drawing.Point(64, 53);
            this.personel_name.Name = "personel_name";
            this.personel_name.Size = new System.Drawing.Size(232, 22);
            this.personel_name.TabIndex = 13;
            // 
            // personel_surname
            // 
            this.personel_surname.Location = new System.Drawing.Point(84, 81);
            this.personel_surname.Name = "personel_surname";
            this.personel_surname.Size = new System.Drawing.Size(212, 22);
            this.personel_surname.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Identification Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 111);
            this.button2.TabIndex = 15;
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
            this.button1.Location = new System.Drawing.Point(593, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 111);
            this.button1.TabIndex = 14;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personel_ıd
            // 
            this.personel_ıd.Location = new System.Drawing.Point(36, 25);
            this.personel_ıd.Name = "personel_ıd";
            this.personel_ıd.Size = new System.Drawing.Size(260, 22);
            this.personel_ıd.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Id:";
            // 
            // Personel_İnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personel_ınfo);
            this.Controls.Add(this.personel_datagridview);
            this.Controls.Add(this.update_personel);
            this.Controls.Add(this.delete_personel);
            this.Controls.Add(this.add_personel);
            this.Controls.Add(this.personel_list);
            this.Name = "Personel_İnfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İnfo";
            this.Load += new System.EventHandler(this.Personel_İnfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personel_datagridview)).EndInit();
            this.personel_ınfo.ResumeLayout(false);
            this.personel_ınfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_personel;
        private System.Windows.Forms.Button delete_personel;
        private System.Windows.Forms.Button add_personel;
        private System.Windows.Forms.Button personel_list;
        private System.Windows.Forms.DataGridView personel_datagridview;
        private System.Windows.Forms.GroupBox personel_ınfo;
        private System.Windows.Forms.MaskedTextBox personel_phonenumber;
        private System.Windows.Forms.MaskedTextBox personel_ıdentıfıcatıon_number;
        private System.Windows.Forms.TextBox personel_adress;
        private System.Windows.Forms.TextBox personel_mail;
        private System.Windows.Forms.TextBox personel_surname;
        private System.Windows.Forms.TextBox personel_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox personel_depertmentıd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox personel_age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personel_ıd;
    }
}