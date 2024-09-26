namespace BookingSystem.Presentation
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.BookingPanelWood = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookingPanelCyan = new System.Windows.Forms.Panel();
            this.lblBookingCopyright = new System.Windows.Forms.Label();
            this.pbBookingLogo = new System.Windows.Forms.PictureBox();
            this.BookingPanelWood.SuspendLayout();
            this.BookingPanelCyan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingPanelWood
            // 
            this.BookingPanelWood.BackColor = System.Drawing.Color.BurlyWood;
            this.BookingPanelWood.Controls.Add(this.panel3);
            this.BookingPanelWood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookingPanelWood.Location = new System.Drawing.Point(0, 489);
            this.BookingPanelWood.Name = "BookingPanelWood";
            this.BookingPanelWood.Size = new System.Drawing.Size(1094, 10);
            this.BookingPanelWood.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 10);
            this.panel3.TabIndex = 5;
            // 
            // BookingPanelCyan
            // 
            this.BookingPanelCyan.BackColor = System.Drawing.Color.DarkCyan;
            this.BookingPanelCyan.Controls.Add(this.pbBookingLogo);
            this.BookingPanelCyan.Controls.Add(this.lblBookingCopyright);
            this.BookingPanelCyan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookingPanelCyan.ForeColor = System.Drawing.Color.Black;
            this.BookingPanelCyan.Location = new System.Drawing.Point(0, 499);
            this.BookingPanelCyan.Name = "BookingPanelCyan";
            this.BookingPanelCyan.Size = new System.Drawing.Size(1094, 75);
            this.BookingPanelCyan.TabIndex = 5;
            // 
            // lblBookingCopyright
            // 
            this.lblBookingCopyright.AutoSize = true;
            this.lblBookingCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingCopyright.Location = new System.Drawing.Point(12, 49);
            this.lblBookingCopyright.Name = "lblBookingCopyright";
            this.lblBookingCopyright.Size = new System.Drawing.Size(432, 23);
            this.lblBookingCopyright.TabIndex = 0;
            this.lblBookingCopyright.Text = "Copyright © 2024 Hotel Mangement Project";
            // 
            // pbBookingLogo
            // 
            this.pbBookingLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbBookingLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbBookingLogo.Image")));
            this.pbBookingLogo.Location = new System.Drawing.Point(943, -4);
            this.pbBookingLogo.Name = "pbBookingLogo";
            this.pbBookingLogo.Size = new System.Drawing.Size(148, 79);
            this.pbBookingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookingLogo.TabIndex = 8;
            this.pbBookingLogo.TabStop = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 574);
            this.Controls.Add(this.BookingPanelWood);
            this.Controls.Add(this.BookingPanelCyan);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.BookingPanelWood.ResumeLayout(false);
            this.BookingPanelCyan.ResumeLayout(false);
            this.BookingPanelCyan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookingLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BookingPanelWood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel BookingPanelCyan;
        private System.Windows.Forms.Label lblBookingCopyright;
        private System.Windows.Forms.PictureBox pbBookingLogo;
    }
}