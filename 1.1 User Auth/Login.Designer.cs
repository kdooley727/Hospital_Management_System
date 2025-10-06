namespace Hospital_Management_System
{
    partial class Login
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.loginbttn = new System.Windows.Forms.Button();
            this.registerbttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.radioButtonNurse = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrativeStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonPatient = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(176, 62);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(176, 128);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // loginbttn
            // 
            this.loginbttn.Location = new System.Drawing.Point(149, 242);
            this.loginbttn.Name = "loginbttn";
            this.loginbttn.Size = new System.Drawing.Size(75, 23);
            this.loginbttn.TabIndex = 2;
            this.loginbttn.Text = "Login";
            this.loginbttn.UseVisualStyleBackColor = true;
            this.loginbttn.Click += new System.EventHandler(this.loginbttn_Click);
            // 
            // registerbttn
            // 
            this.registerbttn.Location = new System.Drawing.Point(320, 242);
            this.registerbttn.Name = "registerbttn";
            this.registerbttn.Size = new System.Drawing.Size(75, 23);
            this.registerbttn.TabIndex = 3;
            this.registerbttn.Text = "Register";
            this.registerbttn.UseVisualStyleBackColor = true;
            this.registerbttn.Click += new System.EventHandler(this.registerbttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Location = new System.Drawing.Point(25, 21);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(68, 20);
            this.radioButtonDoctor.TabIndex = 6;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Doctor";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            // 
            // radioButtonNurse
            // 
            this.radioButtonNurse.AutoSize = true;
            this.radioButtonNurse.Location = new System.Drawing.Point(25, 51);
            this.radioButtonNurse.Name = "radioButtonNurse";
            this.radioButtonNurse.Size = new System.Drawing.Size(64, 20);
            this.radioButtonNurse.TabIndex = 7;
            this.radioButtonNurse.TabStop = true;
            this.radioButtonNurse.Text = "Nurse";
            this.radioButtonNurse.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministrativeStaff
            // 
            this.radioButtonAdministrativeStaff.AutoSize = true;
            this.radioButtonAdministrativeStaff.Location = new System.Drawing.Point(25, 77);
            this.radioButtonAdministrativeStaff.Name = "radioButtonAdministrativeStaff";
            this.radioButtonAdministrativeStaff.Size = new System.Drawing.Size(141, 20);
            this.radioButtonAdministrativeStaff.TabIndex = 8;
            this.radioButtonAdministrativeStaff.TabStop = true;
            this.radioButtonAdministrativeStaff.Text = "Administrative Staff";
            this.radioButtonAdministrativeStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonPatient
            // 
            this.radioButtonPatient.AutoSize = true;
            this.radioButtonPatient.Location = new System.Drawing.Point(25, 103);
            this.radioButtonPatient.Name = "radioButtonPatient";
            this.radioButtonPatient.Size = new System.Drawing.Size(69, 20);
            this.radioButtonPatient.TabIndex = 9;
            this.radioButtonPatient.TabStop = true;
            this.radioButtonPatient.Text = "Patient";
            this.radioButtonPatient.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDoctor);
            this.groupBox1.Controls.Add(this.radioButtonNurse);
            this.groupBox1.Controls.Add(this.radioButtonPatient);
            this.groupBox1.Controls.Add(this.radioButtonAdministrativeStaff);
            this.groupBox1.Location = new System.Drawing.Point(377, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(222, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerbttn);
            this.Controls.Add(this.loginbttn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button loginbttn;
        private System.Windows.Forms.Button registerbttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
        private System.Windows.Forms.RadioButton radioButtonNurse;
        private System.Windows.Forms.RadioButton radioButtonAdministrativeStaff;
        private System.Windows.Forms.RadioButton radioButtonPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}