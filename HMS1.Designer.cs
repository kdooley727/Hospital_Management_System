namespace Hospital_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginbttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.main_label_uname = new System.Windows.Forms.Label();
            this.main_label_utype = new System.Windows.Forms.Label();
            this.main_label_title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HMS_Bttn_PatientManage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Chat = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_MedInv = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbttn
            // 
            this.loginbttn.Location = new System.Drawing.Point(9, 35);
            this.loginbttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginbttn.Name = "loginbttn";
            this.loginbttn.Size = new System.Drawing.Size(273, 35);
            this.loginbttn.TabIndex = 0;
            this.loginbttn.Text = "Login";
            this.loginbttn.UseVisualStyleBackColor = true;
            this.loginbttn.Click += new System.EventHandler(this.loginbttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginbttn);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // main_label_uname
            // 
            this.main_label_uname.AutoSize = true;
            this.main_label_uname.Location = new System.Drawing.Point(156, 63);
            this.main_label_uname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_label_uname.Name = "main_label_uname";
            this.main_label_uname.Size = new System.Drawing.Size(173, 20);
            this.main_label_uname.TabIndex = 2;
            this.main_label_uname.Text = "Placeholder for UName";
            // 
            // main_label_utype
            // 
            this.main_label_utype.AutoSize = true;
            this.main_label_utype.Location = new System.Drawing.Point(156, 83);
            this.main_label_utype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_label_utype.Name = "main_label_utype";
            this.main_label_utype.Size = new System.Drawing.Size(161, 20);
            this.main_label_utype.TabIndex = 3;
            this.main_label_utype.Text = "Placeholder for Utype";
            // 
            // main_label_title
            // 
            this.main_label_title.AutoSize = true;
            this.main_label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label_title.Location = new System.Drawing.Point(702, 19);
            this.main_label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_label_title.Name = "main_label_title";
            this.main_label_title.Size = new System.Drawing.Size(485, 31);
            this.main_label_title.TabIndex = 4;
            this.main_label_title.Text = "Hospital Management System Demo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HMS_Bttn_PatientManage);
            this.groupBox2.Location = new System.Drawing.Point(874, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Access";
            // 
            // HMS_Bttn_PatientManage
            // 
            this.HMS_Bttn_PatientManage.Location = new System.Drawing.Point(9, 35);
            this.HMS_Bttn_PatientManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HMS_Bttn_PatientManage.Name = "HMS_Bttn_PatientManage";
            this.HMS_Bttn_PatientManage.Size = new System.Drawing.Size(273, 35);
            this.HMS_Bttn_PatientManage.TabIndex = 0;
            this.HMS_Bttn_PatientManage.Text = "Patient Management";
            this.HMS_Bttn_PatientManage.UseVisualStyleBackColor = true;
            this.HMS_Bttn_PatientManage.Click += new System.EventHandler(this.HMS_Bttn_PatientManage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAnalytics);
            this.groupBox3.Location = new System.Drawing.Point(27, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(300, 102);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Analytics";
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Location = new System.Drawing.Point(9, 35);
            this.buttonAnalytics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(273, 35);
            this.buttonAnalytics.TabIndex = 0;
            this.buttonAnalytics.Text = "Data Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Chat);
            this.groupBox4.Location = new System.Drawing.Point(27, 187);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(300, 102);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chat";
            // 
            // btn_Chat
            // 
            this.btn_Chat.Location = new System.Drawing.Point(9, 35);
            this.btn_Chat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Chat.Name = "btn_Chat";
            this.btn_Chat.Size = new System.Drawing.Size(273, 35);
            this.btn_Chat.TabIndex = 0;
            this.btn_Chat.Text = "Chat Message";
            this.btn_Chat.UseVisualStyleBackColor = true;
            this.btn_Chat.Click += new System.EventHandler(this.btn_Chat_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_MedInv);
            this.groupBox5.Location = new System.Drawing.Point(27, 433);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(300, 102);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Medical Inventory";
            // 
            // btn_MedInv
            // 
            this.btn_MedInv.Location = new System.Drawing.Point(9, 35);
            this.btn_MedInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MedInv.Name = "btn_MedInv";
            this.btn_MedInv.Size = new System.Drawing.Size(273, 35);
            this.btn_MedInv.TabIndex = 0;
            this.btn_MedInv.Text = "Medical Inventory";
            this.btn_MedInv.UseVisualStyleBackColor = true;
            this.btn_MedInv.Click += new System.EventHandler(this.btn_MedInv_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(874, 73);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(300, 102);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Patient Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Appointment Scheduling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Placeholder for UID";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.main_label_uname);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.main_label_utype);
            this.groupBox7.Location = new System.Drawing.Point(384, 73);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(465, 462);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Welcome to Seattle Grey";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.main_label_title);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "HMS1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label main_label_uname;
        private System.Windows.Forms.Label main_label_utype;
        private System.Windows.Forms.Label main_label_title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button HMS_Bttn_PatientManage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Chat;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_MedInv;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

