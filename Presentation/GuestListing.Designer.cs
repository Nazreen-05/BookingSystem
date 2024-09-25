namespace BookingSystem.Presentation
{
    partial class GuestListing
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
            this.GuestListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // GuestListView
            // 
            this.GuestListView.HideSelection = false;
            this.GuestListView.Location = new System.Drawing.Point(134, 63);
            this.GuestListView.Name = "GuestListView";
            this.GuestListView.Size = new System.Drawing.Size(588, 261);
            this.GuestListView.TabIndex = 0;
            this.GuestListView.UseCompatibleStateImageBehavior = false;
            // 
            // GuestListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuestListView);
            this.Name = "GuestListing";
            this.Text = "GuestListing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView GuestListView;
    }
}