namespace Hospital_Management_System._4._1_Medical_Inventory_Manager
{
    partial class MedInv
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
            this.components = new System.ComponentModel.Container();
            this.lstView_Inventory = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstView_Inventory
            // 
            this.lstView_Inventory.HideSelection = false;
            this.lstView_Inventory.Location = new System.Drawing.Point(13, 13);
            this.lstView_Inventory.Name = "lstView_Inventory";
            this.lstView_Inventory.Size = new System.Drawing.Size(631, 342);
            this.lstView_Inventory.TabIndex = 0;
            this.lstView_Inventory.UseCompatibleStateImageBehavior = false;
            // 
            // MedInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 367);
            this.Controls.Add(this.lstView_Inventory);
            this.Name = "MedInv";
            this.Text = "MedInv";
            this.Load += new System.EventHandler(this.MedInv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstView_Inventory;
        private System.Windows.Forms.Timer timer1;
    }
}