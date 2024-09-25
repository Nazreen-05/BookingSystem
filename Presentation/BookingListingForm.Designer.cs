namespace BookingSystem.Presentation
{
    partial class BookingListingForm
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
            this.BookingListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BookingListView
            // 
            this.BookingListView.HideSelection = false;
            this.BookingListView.Location = new System.Drawing.Point(154, 80);
            this.BookingListView.Name = "BookingListView";
            this.BookingListView.Size = new System.Drawing.Size(578, 243);
            this.BookingListView.TabIndex = 0;
            this.BookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // BookingListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookingListView);
            this.Name = "BookingListingForm";
            this.Text = "BookingListingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BookingListView;
    }
}