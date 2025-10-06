namespace Hospital_Management_System._3._3_Appointment_Scheduling
{
    partial class Appointments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelbox = new System.Windows.Forms.GroupBox();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.cancelbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateAppointment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddAppointment);
            this.groupBox1.Controls.Add(this.dtpAppointmentDateTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Appointment";
            // 
            // cancelbox
            // 
            this.cancelbox.Controls.Add(this.btnDeleteAppointment);
            this.cancelbox.Controls.Add(this.dataGridViewAppointments);
            this.cancelbox.Location = new System.Drawing.Point(12, 316);
            this.cancelbox.Name = "cancelbox";
            this.cancelbox.Size = new System.Drawing.Size(795, 360);
            this.cancelbox.TabIndex = 1;
            this.cancelbox.TabStop = false;
            this.cancelbox.Text = "Cancel Appointment";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowTemplate.Height = 28;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(783, 253);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(139, 51);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(129, 26);
            this.txtPatientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "App ID ";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(139, 91);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(129, 26);
            this.txtAppID.TabIndex = 2;
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpAppointmentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(152, 136);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(299, 26);
            this.dtpAppointmentDateTime.TabIndex = 4;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(152, 210);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(100, 33);
            this.btnAddAppointment.TabIndex = 5;
            this.btnAddAppointment.Text = "Request App";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(324, 300);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(124, 32);
            this.btnDeleteAppointment.TabIndex = 6;
            this.btnDeleteAppointment.Text = "Cancel App";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Date ";
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(292, 210);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(100, 33);
            this.btnUpdateAppointment.TabIndex = 7;
            this.btnUpdateAppointment.Text = "Update App";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 688);
            this.Controls.Add(this.cancelbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cancelbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cancelbox;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
    }
}