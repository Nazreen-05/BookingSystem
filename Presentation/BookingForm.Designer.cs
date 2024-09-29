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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.BookingPanelWood = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BookingPanelCyan = new System.Windows.Forms.Panel();
            this.pbBookingLogo = new System.Windows.Forms.PictureBox();
            this.lblBookingCopyright = new System.Windows.Forms.Label();
            this.hotelManagementDBDataSet = new BookingSystem.HotelManagementDBDataSet();
            this.hotelManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.cmbBookingStatus = new System.Windows.Forms.ComboBox();
            this.cmbDepositPaid = new System.Windows.Forms.ComboBox();
            this.dpkCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dpkCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dpkBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtGuestAcc = new System.Windows.Forms.TextBox();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblDepositPaid = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblGuestAccNo = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.bookingListView = new System.Windows.Forms.ListView();
            this.BookingPanelWood.SuspendLayout();
            this.BookingPanelCyan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookingLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDBDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookingPanelWood
            // 
            this.BookingPanelWood.BackColor = System.Drawing.Color.BurlyWood;
            this.BookingPanelWood.Controls.Add(this.panel3);
            this.BookingPanelWood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookingPanelWood.Location = new System.Drawing.Point(0, 485);
            this.BookingPanelWood.Margin = new System.Windows.Forms.Padding(2);
            this.BookingPanelWood.Name = "BookingPanelWood";
            this.BookingPanelWood.Size = new System.Drawing.Size(1046, 6);
            this.BookingPanelWood.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 6);
            this.panel3.TabIndex = 5;
            // 
            // BookingPanelCyan
            // 
            this.BookingPanelCyan.BackColor = System.Drawing.Color.DarkCyan;
            this.BookingPanelCyan.Controls.Add(this.pbBookingLogo);
            this.BookingPanelCyan.Controls.Add(this.lblBookingCopyright);
            this.BookingPanelCyan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookingPanelCyan.ForeColor = System.Drawing.Color.Black;
            this.BookingPanelCyan.Location = new System.Drawing.Point(0, 491);
            this.BookingPanelCyan.Margin = new System.Windows.Forms.Padding(2);
            this.BookingPanelCyan.Name = "BookingPanelCyan";
            this.BookingPanelCyan.Size = new System.Drawing.Size(1046, 49);
            this.BookingPanelCyan.TabIndex = 5;
            // 
            // pbBookingLogo
            // 
            this.pbBookingLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbBookingLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbBookingLogo.Image")));
            this.pbBookingLogo.Location = new System.Drawing.Point(629, -3);
            this.pbBookingLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbBookingLogo.Name = "pbBookingLogo";
            this.pbBookingLogo.Size = new System.Drawing.Size(99, 51);
            this.pbBookingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookingLogo.TabIndex = 8;
            this.pbBookingLogo.TabStop = false;
            // 
            // lblBookingCopyright
            // 
            this.lblBookingCopyright.AutoSize = true;
            this.lblBookingCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingCopyright.Location = new System.Drawing.Point(8, 32);
            this.lblBookingCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingCopyright.Name = "lblBookingCopyright";
            this.lblBookingCopyright.Size = new System.Drawing.Size(285, 16);
            this.lblBookingCopyright.TabIndex = 0;
            this.lblBookingCopyright.Text = "Copyright © 2024 Hotel Mangement Project";
            // 
            // hotelManagementDBDataSet
            // 
            this.hotelManagementDBDataSet.DataSetName = "HotelManagementDBDataSet";
            this.hotelManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelManagementDBDataSetBindingSource
            // 
            this.hotelManagementDBDataSetBindingSource.DataSource = this.hotelManagementDBDataSet;
            this.hotelManagementDBDataSetBindingSource.Position = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(546, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSeason);
            this.groupBox1.Controls.Add(this.lblBookingStatus);
            this.groupBox1.Controls.Add(this.lblSeason);
            this.groupBox1.Controls.Add(this.cmbBookingStatus);
            this.groupBox1.Controls.Add(this.cmbDepositPaid);
            this.groupBox1.Controls.Add(this.dpkCheckOutDate);
            this.groupBox1.Controls.Add(this.dpkCheckInDate);
            this.groupBox1.Controls.Add(this.dpkBookingDate);
            this.groupBox1.Controls.Add(this.lblTotalCost);
            this.groupBox1.Controls.Add(this.txtTotalCost);
            this.groupBox1.Controls.Add(this.txtBookingID);
            this.groupBox1.Controls.Add(this.txtGuestAcc);
            this.groupBox1.Controls.Add(this.lblCheckOutDate);
            this.groupBox1.Controls.Add(this.lblCheckInDate);
            this.groupBox1.Controls.Add(this.lblDepositPaid);
            this.groupBox1.Controls.Add(this.lblBookingDate);
            this.groupBox1.Controls.Add(this.lblGuestAccNo);
            this.groupBox1.Controls.Add(this.lblBookingID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(27, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 230);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbBooking";
            // 
            // cmbSeason
            // 
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Items.AddRange(new object[] {
            "Low",
            "Mid",
            "High"});
            this.cmbSeason.Location = new System.Drawing.Point(110, 189);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(121, 21);
            this.cmbSeason.TabIndex = 32;
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.AutoSize = true;
            this.lblBookingStatus.Location = new System.Drawing.Point(275, 162);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(76, 13);
            this.lblBookingStatus.TabIndex = 31;
            this.lblBookingStatus.Text = "BookingStatus";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(6, 196);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(43, 13);
            this.lblSeason.TabIndex = 30;
            this.lblSeason.Text = "Season";
            // 
            // cmbBookingStatus
            // 
            this.cmbBookingStatus.FormattingEnabled = true;
            this.cmbBookingStatus.Items.AddRange(new object[] {
            "Checked in",
            "checked out"});
            this.cmbBookingStatus.Location = new System.Drawing.Point(358, 159);
            this.cmbBookingStatus.Name = "cmbBookingStatus";
            this.cmbBookingStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbBookingStatus.TabIndex = 29;
            // 
            // cmbDepositPaid
            // 
            this.cmbDepositPaid.FormattingEnabled = true;
            this.cmbDepositPaid.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbDepositPaid.Location = new System.Drawing.Point(430, 36);
            this.cmbDepositPaid.Name = "cmbDepositPaid";
            this.cmbDepositPaid.Size = new System.Drawing.Size(121, 21);
            this.cmbDepositPaid.TabIndex = 28;
            // 
            // dpkCheckOutDate
            // 
            this.dpkCheckOutDate.Location = new System.Drawing.Point(421, 111);
            this.dpkCheckOutDate.Name = "dpkCheckOutDate";
            this.dpkCheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.dpkCheckOutDate.TabIndex = 27;
            this.dpkCheckOutDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dpkCheckInDate
            // 
            this.dpkCheckInDate.Location = new System.Drawing.Point(421, 79);
            this.dpkCheckInDate.Name = "dpkCheckInDate";
            this.dpkCheckInDate.Size = new System.Drawing.Size(200, 20);
            this.dpkCheckInDate.TabIndex = 26;
            // 
            // dpkBookingDate
            // 
            this.dpkBookingDate.Location = new System.Drawing.Point(110, 118);
            this.dpkBookingDate.Name = "dpkBookingDate";
            this.dpkBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dpkBookingDate.TabIndex = 25;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(6, 162);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 24;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(110, 155);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 21;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(110, 41);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingID.TabIndex = 20;
            // 
            // txtGuestAcc
            // 
            this.txtGuestAcc.Location = new System.Drawing.Point(110, 76);
            this.txtGuestAcc.Name = "txtGuestAcc";
            this.txtGuestAcc.Size = new System.Drawing.Size(100, 20);
            this.txtGuestAcc.TabIndex = 16;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(319, 118);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(78, 13);
            this.lblCheckOutDate.TabIndex = 14;
            this.lblCheckOutDate.Text = "CheckOutDate";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(319, 79);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(70, 13);
            this.lblCheckInDate.TabIndex = 13;
            this.lblCheckInDate.Text = "CheckInDate";
            // 
            // lblDepositPaid
            // 
            this.lblDepositPaid.AutoSize = true;
            this.lblDepositPaid.Location = new System.Drawing.Point(319, 41);
            this.lblDepositPaid.Name = "lblDepositPaid";
            this.lblDepositPaid.Size = new System.Drawing.Size(64, 13);
            this.lblDepositPaid.TabIndex = 12;
            this.lblDepositPaid.Text = "DepositPaid";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(6, 118);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(69, 13);
            this.lblBookingDate.TabIndex = 11;
            this.lblBookingDate.Text = "BookingDate";
            // 
            // lblGuestAccNo
            // 
            this.lblGuestAccNo.AutoSize = true;
            this.lblGuestAccNo.Location = new System.Drawing.Point(6, 79);
            this.lblGuestAccNo.Name = "lblGuestAccNo";
            this.lblGuestAccNo.Size = new System.Drawing.Size(98, 13);
            this.lblGuestAccNo.TabIndex = 10;
            this.lblGuestAccNo.Text = "Guest Account No.";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(6, 44);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 9;
            this.lblBookingID.Text = "Booking ID";
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(27, 12);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(970, 232);
            this.bookingListView.TabIndex = 10;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 540);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookingPanelWood);
            this.Controls.Add(this.BookingPanelCyan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Activated += new System.EventHandler(this.BookingForm_Activated);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.BookingPanelWood.ResumeLayout(false);
            this.BookingPanelCyan.ResumeLayout(false);
            this.BookingPanelCyan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookingLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDBDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BookingPanelWood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel BookingPanelCyan;
        private System.Windows.Forms.Label lblBookingCopyright;
        private System.Windows.Forms.PictureBox pbBookingLogo;
        private System.Windows.Forms.BindingSource hotelManagementDBDataSetBindingSource;
        private HotelManagementDBDataSet hotelManagementDBDataSet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblDepositPaid;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblGuestAccNo;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtGuestAcc;
        private System.Windows.Forms.DateTimePicker dpkCheckInDate;
        private System.Windows.Forms.DateTimePicker dpkBookingDate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.DateTimePicker dpkCheckOutDate;
        private System.Windows.Forms.ComboBox cmbDepositPaid;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.Label lblBookingStatus;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ComboBox cmbBookingStatus;
        private System.Windows.Forms.ListView bookingListView;
    }
}