namespace OtoGaleriWinFormApp
{
    partial class Customer_İnfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_İnfo));
            this.customer_datagridview = new System.Windows.Forms.DataGridView();
            this.customer_list = new System.Windows.Forms.Button();
            this.add_customer = new System.Windows.Forms.Button();
            this.delete_customer = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.customer_ınfo = new System.Windows.Forms.GroupBox();
            this.customer_ıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customer_phonenumber = new System.Windows.Forms.MaskedTextBox();
            this.customerıdentıfıcatıon_number = new System.Windows.Forms.MaskedTextBox();
            this.customer_adress = new System.Windows.Forms.TextBox();
            this.customer_mail = new System.Windows.Forms.TextBox();
            this.customer_surname = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagridview)).BeginInit();
            this.customer_ınfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_datagridview
            // 
            this.customer_datagridview.BackgroundColor = System.Drawing.Color.White;
            this.customer_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_datagridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.customer_datagridview.Location = new System.Drawing.Point(-2, 274);
            this.customer_datagridview.Name = "customer_datagridview";
            this.customer_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_datagridview.Size = new System.Drawing.Size(754, 179);
            this.customer_datagridview.TabIndex = 0;
            this.customer_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_datagridview_CellContentClick);
            // 
            // customer_list
            // 
            this.customer_list.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customer_list.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_list.Location = new System.Drawing.Point(12, 12);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(131, 43);
            this.customer_list.TabIndex = 1;
            this.customer_list.Text = "List Customers";
            this.customer_list.UseVisualStyleBackColor = false;
            this.customer_list.Click += new System.EventHandler(this.customer_list_Click);
            // 
            // add_customer
            // 
            this.add_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_customer.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_customer.Location = new System.Drawing.Point(12, 76);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(131, 43);
            this.add_customer.TabIndex = 2;
            this.add_customer.Text = "Add Customer";
            this.add_customer.UseVisualStyleBackColor = false;
            this.add_customer.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // delete_customer
            // 
            this.delete_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_customer.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_customer.Location = new System.Drawing.Point(12, 140);
            this.delete_customer.Name = "delete_customer";
            this.delete_customer.Size = new System.Drawing.Size(131, 43);
            this.delete_customer.TabIndex = 3;
            this.delete_customer.Text = "Delete Customer";
            this.delete_customer.UseVisualStyleBackColor = false;
            this.delete_customer.Click += new System.EventHandler(this.delete_customer_Click);
            // 
            // update_customer
            // 
            this.update_customer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_customer.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_customer.Location = new System.Drawing.Point(12, 204);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(131, 43);
            this.update_customer.TabIndex = 4;
            this.update_customer.Text = "Update Customer";
            this.update_customer.UseVisualStyleBackColor = false;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // customer_ınfo
            // 
            this.customer_ınfo.Controls.Add(this.customer_ıd);
            this.customer_ınfo.Controls.Add(this.label7);
            this.customer_ınfo.Controls.Add(this.customer_phonenumber);
            this.customer_ınfo.Controls.Add(this.customerıdentıfıcatıon_number);
            this.customer_ınfo.Controls.Add(this.customer_adress);
            this.customer_ınfo.Controls.Add(this.customer_mail);
            this.customer_ınfo.Controls.Add(this.customer_surname);
            this.customer_ınfo.Controls.Add(this.customer_name);
            this.customer_ınfo.Controls.Add(this.label6);
            this.customer_ınfo.Controls.Add(this.label5);
            this.customer_ınfo.Controls.Add(this.label4);
            this.customer_ınfo.Controls.Add(this.label3);
            this.customer_ınfo.Controls.Add(this.label2);
            this.customer_ınfo.Controls.Add(this.label1);
            this.customer_ınfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_ınfo.Location = new System.Drawing.Point(181, 12);
            this.customer_ınfo.Name = "customer_ınfo";
            this.customer_ınfo.Size = new System.Drawing.Size(302, 256);
            this.customer_ınfo.TabIndex = 6;
            this.customer_ınfo.TabStop = false;
            this.customer_ınfo.Text = "Customer İnformation";
            // 
            // customer_ıd
            // 
            this.customer_ıd.Location = new System.Drawing.Point(64, 21);
            this.customer_ıd.Name = "customer_ıd";
            this.customer_ıd.Size = new System.Drawing.Size(232, 22);
            this.customer_ıd.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Id:";
            // 
            // customer_phonenumber
            // 
            this.customer_phonenumber.Location = new System.Drawing.Point(125, 184);
            this.customer_phonenumber.Mask = "(999) 000-0000";
            this.customer_phonenumber.Name = "customer_phonenumber";
            this.customer_phonenumber.Size = new System.Drawing.Size(171, 22);
            this.customer_phonenumber.TabIndex = 19;
            // 
            // customerıdentıfıcatıon_number
            // 
            this.customerıdentıfıcatıon_number.Location = new System.Drawing.Point(160, 119);
            this.customerıdentıfıcatıon_number.Mask = "00000000000";
            this.customerıdentıfıcatıon_number.Name = "customerıdentıfıcatıon_number";
            this.customerıdentıfıcatıon_number.Size = new System.Drawing.Size(136, 22);
            this.customerıdentıfıcatıon_number.TabIndex = 16;
            // 
            // customer_adress
            // 
            this.customer_adress.Location = new System.Drawing.Point(64, 218);
            this.customer_adress.Name = "customer_adress";
            this.customer_adress.Size = new System.Drawing.Size(232, 22);
            this.customer_adress.TabIndex = 18;
            this.customer_adress.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // customer_mail
            // 
            this.customer_mail.Location = new System.Drawing.Point(52, 152);
            this.customer_mail.Name = "customer_mail";
            this.customer_mail.Size = new System.Drawing.Size(244, 22);
            this.customer_mail.TabIndex = 16;
            // 
            // customer_surname
            // 
            this.customer_surname.Location = new System.Drawing.Point(84, 82);
            this.customer_surname.Name = "customer_surname";
            this.customer_surname.Size = new System.Drawing.Size(212, 22);
            this.customer_surname.TabIndex = 14;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(64, 51);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(232, 22);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Identification Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 111);
            this.button1.TabIndex = 12;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(576, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 111);
            this.button2.TabIndex = 13;
            this.button2.Text = "EXİT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Customer_İnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_ınfo);
            this.Controls.Add(this.update_customer);
            this.Controls.Add(this.delete_customer);
            this.Controls.Add(this.add_customer);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.customer_datagridview);
            this.Name = "Customer_İnfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer İnfo";
            this.Load += new System.EventHandler(this.Customer_İnfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_datagridview)).EndInit();
            this.customer_ınfo.ResumeLayout(false);
            this.customer_ınfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customer_datagridview;
        private System.Windows.Forms.Button customer_list;
        private System.Windows.Forms.Button add_customer;
        private System.Windows.Forms.Button delete_customer;
        private System.Windows.Forms.Button update_customer;
        private System.Windows.Forms.GroupBox customer_ınfo;
        private System.Windows.Forms.TextBox customer_adress;
        private System.Windows.Forms.TextBox customer_mail;
        private System.Windows.Forms.TextBox customer_surname;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox customer_phonenumber;
        private System.Windows.Forms.MaskedTextBox customerıdentıfıcatıon_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox customer_ıd;
        private System.Windows.Forms.Label label7;
    }
}