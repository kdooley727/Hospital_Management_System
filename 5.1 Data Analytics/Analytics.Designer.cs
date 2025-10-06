namespace Hospital_Management_System
{
    partial class Analytics
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
            this.dataGridViewAnalytics = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalytics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnalytics
            // 
            this.dataGridViewAnalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalytics.Location = new System.Drawing.Point(62, 219);
            this.dataGridViewAnalytics.Name = "dataGridViewAnalytics";
            this.dataGridViewAnalytics.RowHeadersWidth = 51;
            this.dataGridViewAnalytics.RowTemplate.Height = 24;
            this.dataGridViewAnalytics.Size = new System.Drawing.Size(652, 198);
            this.dataGridViewAnalytics.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Location = new System.Drawing.Point(381, 163);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(103, 24);
            this.buttonAnalytics.TabIndex = 2;
            this.buttonAnalytics.Text = "Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reports";
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnalytics);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewAnalytics);
            this.Name = "Analytics";
            this.Text = "Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalytics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnalytics;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Label label1;
    }
}