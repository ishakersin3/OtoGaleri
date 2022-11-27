namespace OtoGaleriWinFormApp
{
    partial class Department_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department_Info));
            this.deparment_ınfo = new System.Windows.Forms.GroupBox();
            this.department_ıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.department_endorsement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.department_name = new System.Windows.Forms.TextBox();
            this.department_personelnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_personel = new System.Windows.Forms.Button();
            this.add_departments = new System.Windows.Forms.Button();
            this.department_list = new System.Windows.Forms.Button();
            this.delete_departments = new System.Windows.Forms.Button();
            this.department_datagridview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deparment_ınfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // deparment_ınfo
            // 
            this.deparment_ınfo.Controls.Add(this.department_ıd);
            this.deparment_ınfo.Controls.Add(this.label3);
            this.deparment_ınfo.Controls.Add(this.department_endorsement);
            this.deparment_ınfo.Controls.Add(this.label10);
            this.deparment_ınfo.Controls.Add(this.department_name);
            this.deparment_ınfo.Controls.Add(this.department_personelnumber);
            this.deparment_ınfo.Controls.Add(this.label2);
            this.deparment_ınfo.Controls.Add(this.label1);
            this.deparment_ınfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deparment_ınfo.Location = new System.Drawing.Point(180, 13);
            this.deparment_ınfo.Name = "deparment_ınfo";
            this.deparment_ınfo.Size = new System.Drawing.Size(257, 159);
            this.deparment_ınfo.TabIndex = 22;
            this.deparment_ınfo.TabStop = false;
            this.deparment_ınfo.Text = "Department İnformation";
            // 
            // department_ıd
            // 
            this.department_ıd.Location = new System.Drawing.Point(36, 27);
            this.department_ıd.Name = "department_ıd";
            this.department_ıd.Size = new System.Drawing.Size(215, 22);
            this.department_ıd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id:";
            // 
            // department_endorsement
            // 
            this.department_endorsement.Location = new System.Drawing.Point(114, 118);
            this.department_endorsement.Name = "department_endorsement";
            this.department_endorsement.Size = new System.Drawing.Size(137, 22);
            this.department_endorsement.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Endorsement:";
            // 
            // department_name
            // 
            this.department_name.Location = new System.Drawing.Point(64, 61);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(187, 22);
            this.department_name.TabIndex = 13;
            // 
            // department_personelnumber
            // 
            this.department_personelnumber.Location = new System.Drawing.Point(143, 89);
            this.department_personelnumber.Name = "department_personelnumber";
            this.department_personelnumber.Size = new System.Drawing.Size(108, 22);
            this.department_personelnumber.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Personel Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // update_personel
            // 
            this.update_personel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_personel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_personel.Location = new System.Drawing.Point(12, 205);
            this.update_personel.Name = "update_personel";
            this.update_personel.Size = new System.Drawing.Size(147, 43);
            this.update_personel.TabIndex = 21;
            this.update_personel.Text = "Update Department";
            this.update_personel.UseVisualStyleBackColor = false;
            this.update_personel.Click += new System.EventHandler(this.update_personel_Click);
            // 
            // add_departments
            // 
            this.add_departments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_departments.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_departments.Location = new System.Drawing.Point(12, 77);
            this.add_departments.Name = "add_departments";
            this.add_departments.Size = new System.Drawing.Size(147, 43);
            this.add_departments.TabIndex = 19;
            this.add_departments.Text = "Add Departments";
            this.add_departments.UseVisualStyleBackColor = false;
            this.add_departments.Click += new System.EventHandler(this.add_departments_Click);
            // 
            // department_list
            // 
            this.department_list.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.department_list.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.department_list.Location = new System.Drawing.Point(12, 13);
            this.department_list.Name = "department_list";
            this.department_list.Size = new System.Drawing.Size(147, 43);
            this.department_list.TabIndex = 18;
            this.department_list.Text = "List Departments";
            this.department_list.UseVisualStyleBackColor = false;
            this.department_list.Click += new System.EventHandler(this.car_list_Click);
            // 
            // delete_departments
            // 
            this.delete_departments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_departments.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_departments.Location = new System.Drawing.Point(12, 141);
            this.delete_departments.Name = "delete_departments";
            this.delete_departments.Size = new System.Drawing.Size(147, 43);
            this.delete_departments.TabIndex = 23;
            this.delete_departments.Text = "Delete Departments";
            this.delete_departments.UseVisualStyleBackColor = false;
            this.delete_departments.Click += new System.EventHandler(this.delete_departments_Click);
            // 
            // department_datagridview
            // 
            this.department_datagridview.BackgroundColor = System.Drawing.Color.White;
            this.department_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_datagridview.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.department_datagridview.Location = new System.Drawing.Point(-2, 254);
            this.department_datagridview.Name = "department_datagridview";
            this.department_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.department_datagridview.Size = new System.Drawing.Size(773, 202);
            this.department_datagridview.TabIndex = 17;
            this.department_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.department_datagridview_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(578, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 111);
            this.button2.TabIndex = 25;
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
            this.button1.Location = new System.Drawing.Point(578, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 111);
            this.button1.TabIndex = 24;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Department_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_departments);
            this.Controls.Add(this.deparment_ınfo);
            this.Controls.Add(this.update_personel);
            this.Controls.Add(this.add_departments);
            this.Controls.Add(this.department_list);
            this.Controls.Add(this.department_datagridview);
            this.Name = "Department_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department_Info";
            this.Load += new System.EventHandler(this.Department_Info_Load);
            this.deparment_ınfo.ResumeLayout(false);
            this.deparment_ınfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deparment_ınfo;
        private System.Windows.Forms.TextBox department_endorsement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox department_name;
        private System.Windows.Forms.TextBox department_personelnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_personel;
        private System.Windows.Forms.Button add_departments;
        private System.Windows.Forms.Button department_list;
        private System.Windows.Forms.Button delete_departments;
        private System.Windows.Forms.DataGridView department_datagridview;
        private System.Windows.Forms.TextBox department_ıd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}