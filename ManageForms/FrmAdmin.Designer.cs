namespace schedule_app_prototype.BusinessLogic
{
    partial class FrmAdmin
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
            this.Workers = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteWorker = new System.Windows.Forms.Button();
            this.BtnDeleteAllWorkers = new System.Windows.Forms.Button();
            this.BtnUpdateWorker = new System.Windows.Forms.Button();
            this.BtnAddMember = new System.Windows.Forms.Button();
            this.BtnRefreshWorkers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.LstbxWorkers = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtWorkerSurname = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVenueRating = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCellNumber = new System.Windows.Forms.MaskedTextBox();
            this.NudWorkerVenueRating = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtWorkerId = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtWorkerName = new System.Windows.Forms.MaskedTextBox();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchWorkers = new System.Windows.Forms.TextBox();
            this.TabctrlManager = new System.Windows.Forms.TabControl();
            this.Venues = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVenue = new System.Windows.Forms.Button();
            this.DeleteAllVenues = new System.Windows.Forms.Button();
            this.btnUpdateVenue = new System.Windows.Forms.Button();
            this.BtnAddVenue = new System.Windows.Forms.Button();
            this.BtnRefreshVenues = new System.Windows.Forms.Button();
            this.btnClearVenue = new System.Windows.Forms.Button();
            this.LstbxVenues = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TxtVenueAddress = new System.Windows.Forms.RichTextBox();
            this.TxtVenueName = new System.Windows.Forms.MaskedTextBox();
            this.TxtVenueId = new System.Windows.Forms.MaskedTextBox();
            this.NudMaxWorkers = new System.Windows.Forms.NumericUpDown();
            this.NudVenueRating = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtSearchVenue = new System.Windows.Forms.TextBox();
            this.Services = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteAllServices = new System.Windows.Forms.Button();
            this.BtnDeleteService = new System.Windows.Forms.Button();
            this.BtnRefreshService = new System.Windows.Forms.Button();
            this.BtnUpdateService = new System.Windows.Forms.Button();
            this.BtnAddService = new System.Windows.Forms.Button();
            this.BtnClearService = new System.Windows.Forms.Button();
            this.LstbxServices = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtServiceName = new System.Windows.Forms.TextBox();
            this.TxtServiceDuration = new System.Windows.Forms.MaskedTextBox();
            this.TxtServiceStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtServiceId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSearchServices = new System.Windows.Forms.TextBox();
            this.Workers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkerVenueRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.TabctrlManager.SuspendLayout();
            this.Venues.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVenueRating)).BeginInit();
            this.Services.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Workers
            // 
            this.Workers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Workers.Controls.Add(this.groupBox1);
            this.Workers.Controls.Add(this.LstbxWorkers);
            this.Workers.Controls.Add(this.groupBox4);
            this.Workers.Controls.Add(this.label4);
            this.Workers.Controls.Add(this.txtSearchWorkers);
            this.Workers.Location = new System.Drawing.Point(4, 22);
            this.Workers.Name = "Workers";
            this.Workers.Padding = new System.Windows.Forms.Padding(3);
            this.Workers.Size = new System.Drawing.Size(970, 500);
            this.Workers.TabIndex = 1;
            this.Workers.Text = "Workers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeleteWorker);
            this.groupBox1.Controls.Add(this.BtnDeleteAllWorkers);
            this.groupBox1.Controls.Add(this.BtnUpdateWorker);
            this.groupBox1.Controls.Add(this.BtnAddMember);
            this.groupBox1.Controls.Add(this.BtnRefreshWorkers);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // BtnDeleteWorker
            // 
            this.BtnDeleteWorker.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteWorker.FlatAppearance.BorderSize = 0;
            this.BtnDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteWorker.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnDeleteWorker.Location = new System.Drawing.Point(227, 16);
            this.BtnDeleteWorker.Name = "BtnDeleteWorker";
            this.BtnDeleteWorker.Size = new System.Drawing.Size(112, 62);
            this.BtnDeleteWorker.TabIndex = 2;
            this.BtnDeleteWorker.TabStop = false;
            this.BtnDeleteWorker.Text = "Delete";
            this.BtnDeleteWorker.UseVisualStyleBackColor = true;
            this.BtnDeleteWorker.Click += new System.EventHandler(this.BtnDeleteWorker_Click);
            // 
            // BtnDeleteAllWorkers
            // 
            this.BtnDeleteAllWorkers.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDeleteAllWorkers.FlatAppearance.BorderSize = 0;
            this.BtnDeleteAllWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteAllWorkers.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnDeleteAllWorkers.Location = new System.Drawing.Point(630, 16);
            this.BtnDeleteAllWorkers.Name = "BtnDeleteAllWorkers";
            this.BtnDeleteAllWorkers.Size = new System.Drawing.Size(113, 62);
            this.BtnDeleteAllWorkers.TabIndex = 5;
            this.BtnDeleteAllWorkers.TabStop = false;
            this.BtnDeleteAllWorkers.Text = "Delete all";
            this.BtnDeleteAllWorkers.UseVisualStyleBackColor = true;
            this.BtnDeleteAllWorkers.Click += new System.EventHandler(this.BtnDeleteAllWorkers_Click);
            // 
            // BtnUpdateWorker
            // 
            this.BtnUpdateWorker.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnUpdateWorker.FlatAppearance.BorderSize = 0;
            this.BtnUpdateWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateWorker.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnUpdateWorker.Location = new System.Drawing.Point(115, 16);
            this.BtnUpdateWorker.Name = "BtnUpdateWorker";
            this.BtnUpdateWorker.Size = new System.Drawing.Size(112, 62);
            this.BtnUpdateWorker.TabIndex = 1;
            this.BtnUpdateWorker.TabStop = false;
            this.BtnUpdateWorker.Text = "Update";
            this.BtnUpdateWorker.UseVisualStyleBackColor = true;
            this.BtnUpdateWorker.Click += new System.EventHandler(this.BtnUpdateWorker_Click);
            // 
            // BtnAddMember
            // 
            this.BtnAddMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddMember.FlatAppearance.BorderSize = 0;
            this.BtnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMember.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnAddMember.Location = new System.Drawing.Point(3, 16);
            this.BtnAddMember.Name = "BtnAddMember";
            this.BtnAddMember.Size = new System.Drawing.Size(112, 62);
            this.BtnAddMember.TabIndex = 0;
            this.BtnAddMember.TabStop = false;
            this.BtnAddMember.Text = "Add";
            this.BtnAddMember.UseVisualStyleBackColor = true;
            this.BtnAddMember.Click += new System.EventHandler(this.BtnAddMember_Click);
            // 
            // BtnRefreshWorkers
            // 
            this.BtnRefreshWorkers.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRefreshWorkers.FlatAppearance.BorderSize = 0;
            this.BtnRefreshWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshWorkers.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnRefreshWorkers.Location = new System.Drawing.Point(743, 16);
            this.BtnRefreshWorkers.Name = "BtnRefreshWorkers";
            this.BtnRefreshWorkers.Size = new System.Drawing.Size(106, 62);
            this.BtnRefreshWorkers.TabIndex = 4;
            this.BtnRefreshWorkers.TabStop = false;
            this.BtnRefreshWorkers.Text = "Refresh";
            this.BtnRefreshWorkers.UseVisualStyleBackColor = true;
            this.BtnRefreshWorkers.Click += new System.EventHandler(this.BtnRefreshWorkers_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnClear.Location = new System.Drawing.Point(849, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 62);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LstbxWorkers
            // 
            this.LstbxWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstbxWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxWorkers.DisplayMember = "Name";
            this.LstbxWorkers.Font = new System.Drawing.Font("Lucida Fax", 11F);
            this.LstbxWorkers.ForeColor = System.Drawing.Color.Silver;
            this.LstbxWorkers.FormattingEnabled = true;
            this.LstbxWorkers.ItemHeight = 17;
            this.LstbxWorkers.Location = new System.Drawing.Point(3, 5);
            this.LstbxWorkers.Name = "LstbxWorkers";
            this.LstbxWorkers.Size = new System.Drawing.Size(551, 408);
            this.LstbxWorkers.TabIndex = 16;
            this.LstbxWorkers.SelectedValueChanged += new System.EventHandler(this.LstbxWorkers_SelectedValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(569, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 397);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtWorkerSurname);
            this.panel1.Controls.Add(this.TxtAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblVenueRating);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtCellNumber);
            this.panel1.Controls.Add(this.NudWorkerVenueRating);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtWorkerId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtWorkerName);
            this.panel1.Controls.Add(this.NudAge);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 378);
            this.panel1.TabIndex = 20;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Gray;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.ForeColor = System.Drawing.Color.Silver;
            this.TxtEmail.Location = new System.Drawing.Point(16, 186);
            this.TxtEmail.MaxLength = 200;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(203, 20);
            this.TxtEmail.TabIndex = 24;
            // 
            // TxtWorkerSurname
            // 
            this.TxtWorkerSurname.BackColor = System.Drawing.Color.Gray;
            this.TxtWorkerSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWorkerSurname.ForeColor = System.Drawing.Color.Silver;
            this.TxtWorkerSurname.Location = new System.Drawing.Point(16, 131);
            this.TxtWorkerSurname.Mask = "LL????????????????????????????";
            this.TxtWorkerSurname.Name = "TxtWorkerSurname";
            this.TxtWorkerSurname.PromptChar = ' ';
            this.TxtWorkerSurname.Size = new System.Drawing.Size(242, 20);
            this.TxtWorkerSurname.TabIndex = 22;
            // 
            // TxtAddress
            // 
            this.TxtAddress.BackColor = System.Drawing.Color.Gray;
            this.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAddress.ForeColor = System.Drawing.Color.Silver;
            this.TxtAddress.Location = new System.Drawing.Point(16, 411);
            this.TxtAddress.MaxLength = 8000;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(330, 168);
            this.TxtAddress.TabIndex = 21;
            this.TxtAddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 395);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Residential Address";
            // 
            // lblVenueRating
            // 
            this.lblVenueRating.AutoSize = true;
            this.lblVenueRating.Location = new System.Drawing.Point(13, 337);
            this.lblVenueRating.Name = "lblVenueRating";
            this.lblVenueRating.Size = new System.Drawing.Size(67, 13);
            this.lblVenueRating.TabIndex = 8;
            this.lblVenueRating.Text = "Venue rating";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // TxtCellNumber
            // 
            this.TxtCellNumber.BackColor = System.Drawing.Color.Gray;
            this.TxtCellNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCellNumber.ForeColor = System.Drawing.Color.Silver;
            this.TxtCellNumber.Location = new System.Drawing.Point(16, 248);
            this.TxtCellNumber.Mask = "9999999999";
            this.TxtCellNumber.Name = "TxtCellNumber";
            this.TxtCellNumber.PromptChar = ' ';
            this.TxtCellNumber.Size = new System.Drawing.Size(145, 20);
            this.TxtCellNumber.TabIndex = 18;
            // 
            // NudWorkerVenueRating
            // 
            this.NudWorkerVenueRating.BackColor = System.Drawing.Color.Gray;
            this.NudWorkerVenueRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudWorkerVenueRating.ForeColor = System.Drawing.Color.White;
            this.NudWorkerVenueRating.Location = new System.Drawing.Point(16, 353);
            this.NudWorkerVenueRating.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudWorkerVenueRating.Name = "NudWorkerVenueRating";
            this.NudWorkerVenueRating.Size = new System.Drawing.Size(76, 20);
            this.NudWorkerVenueRating.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cell number";
            // 
            // TxtWorkerId
            // 
            this.TxtWorkerId.AllowPromptAsInput = false;
            this.TxtWorkerId.BackColor = System.Drawing.Color.Gray;
            this.TxtWorkerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWorkerId.CausesValidation = false;
            this.TxtWorkerId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.TxtWorkerId.ForeColor = System.Drawing.Color.Silver;
            this.TxtWorkerId.Location = new System.Drawing.Point(16, 28);
            this.TxtWorkerId.Mask = "0000000000000";
            this.TxtWorkerId.Name = "TxtWorkerId";
            this.TxtWorkerId.PromptChar = ' ';
            this.TxtWorkerId.Size = new System.Drawing.Size(112, 20);
            this.TxtWorkerId.TabIndex = 9;
            this.TxtWorkerId.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtWorkerId_MaskInputRejected);
            this.TxtWorkerId.TextChanged += new System.EventHandler(this.TxtWorkerId_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 15;
            // 
            // TxtWorkerName
            // 
            this.TxtWorkerName.BackColor = System.Drawing.Color.Gray;
            this.TxtWorkerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWorkerName.ForeColor = System.Drawing.Color.Silver;
            this.TxtWorkerName.Location = new System.Drawing.Point(16, 77);
            this.TxtWorkerName.Mask = "LL????????????????????????????";
            this.TxtWorkerName.Name = "TxtWorkerName";
            this.TxtWorkerName.PromptChar = ' ';
            this.TxtWorkerName.Size = new System.Drawing.Size(242, 20);
            this.TxtWorkerName.TabIndex = 10;
            // 
            // NudAge
            // 
            this.NudAge.BackColor = System.Drawing.Color.Gray;
            this.NudAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudAge.ForeColor = System.Drawing.Color.White;
            this.NudAge.Location = new System.Drawing.Point(16, 297);
            this.NudAge.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(76, 20);
            this.NudAge.TabIndex = 13;
            this.NudAge.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Age";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search by Id";
            // 
            // txtSearchWorkers
            // 
            this.txtSearchWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchWorkers.BackColor = System.Drawing.Color.Silver;
            this.txtSearchWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchWorkers.Location = new System.Drawing.Point(706, 3);
            this.txtSearchWorkers.MaxLength = 13;
            this.txtSearchWorkers.Name = "txtSearchWorkers";
            this.txtSearchWorkers.Size = new System.Drawing.Size(242, 20);
            this.txtSearchWorkers.TabIndex = 17;
            this.txtSearchWorkers.TabStop = false;
            this.txtSearchWorkers.TextChanged += new System.EventHandler(this.TxtSearchWorkers_TextChanged);
            // 
            // TabctrlManager
            // 
            this.TabctrlManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabctrlManager.Controls.Add(this.Workers);
            this.TabctrlManager.Controls.Add(this.Venues);
            this.TabctrlManager.Controls.Add(this.Services);
            this.TabctrlManager.HotTrack = true;
            this.TabctrlManager.ItemSize = new System.Drawing.Size(200, 18);
            this.TabctrlManager.Location = new System.Drawing.Point(-5, -2);
            this.TabctrlManager.Multiline = true;
            this.TabctrlManager.Name = "TabctrlManager";
            this.TabctrlManager.SelectedIndex = 0;
            this.TabctrlManager.Size = new System.Drawing.Size(978, 526);
            this.TabctrlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabctrlManager.TabIndex = 5;
            this.TabctrlManager.TabStop = false;
            // 
            // Venues
            // 
            this.Venues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Venues.Controls.Add(this.groupBox7);
            this.Venues.Controls.Add(this.LstbxVenues);
            this.Venues.Controls.Add(this.groupBox8);
            this.Venues.Controls.Add(this.label15);
            this.Venues.Controls.Add(this.TxtSearchVenue);
            this.Venues.Location = new System.Drawing.Point(4, 22);
            this.Venues.Name = "Venues";
            this.Venues.Padding = new System.Windows.Forms.Padding(3);
            this.Venues.Size = new System.Drawing.Size(970, 500);
            this.Venues.TabIndex = 5;
            this.Venues.Text = "Venues";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDeleteVenue);
            this.groupBox7.Controls.Add(this.DeleteAllVenues);
            this.groupBox7.Controls.Add(this.btnUpdateVenue);
            this.groupBox7.Controls.Add(this.BtnAddVenue);
            this.groupBox7.Controls.Add(this.BtnRefreshVenues);
            this.groupBox7.Controls.Add(this.btnClearVenue);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox7.Location = new System.Drawing.Point(3, 416);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(964, 81);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            // 
            // btnDeleteVenue
            // 
            this.btnDeleteVenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteVenue.FlatAppearance.BorderSize = 0;
            this.btnDeleteVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVenue.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnDeleteVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteVenue.Location = new System.Drawing.Point(227, 16);
            this.btnDeleteVenue.Name = "btnDeleteVenue";
            this.btnDeleteVenue.Size = new System.Drawing.Size(112, 62);
            this.btnDeleteVenue.TabIndex = 2;
            this.btnDeleteVenue.Text = "Delete";
            this.btnDeleteVenue.UseVisualStyleBackColor = true;
            this.btnDeleteVenue.Click += new System.EventHandler(this.BtnDeleteVenue_Click);
            // 
            // DeleteAllVenues
            // 
            this.DeleteAllVenues.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteAllVenues.FlatAppearance.BorderSize = 0;
            this.DeleteAllVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllVenues.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.DeleteAllVenues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteAllVenues.Location = new System.Drawing.Point(630, 16);
            this.DeleteAllVenues.Name = "DeleteAllVenues";
            this.DeleteAllVenues.Size = new System.Drawing.Size(113, 62);
            this.DeleteAllVenues.TabIndex = 5;
            this.DeleteAllVenues.Text = "Delete All";
            this.DeleteAllVenues.UseVisualStyleBackColor = true;
            this.DeleteAllVenues.Click += new System.EventHandler(this.DeleteAllVenues_Click);
            // 
            // btnUpdateVenue
            // 
            this.btnUpdateVenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdateVenue.FlatAppearance.BorderSize = 0;
            this.btnUpdateVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVenue.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnUpdateVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateVenue.Location = new System.Drawing.Point(115, 16);
            this.btnUpdateVenue.Name = "btnUpdateVenue";
            this.btnUpdateVenue.Size = new System.Drawing.Size(112, 62);
            this.btnUpdateVenue.TabIndex = 1;
            this.btnUpdateVenue.Text = "Update";
            this.btnUpdateVenue.UseVisualStyleBackColor = true;
            this.btnUpdateVenue.Click += new System.EventHandler(this.btnUpdateVenue_Click);
            // 
            // BtnAddVenue
            // 
            this.BtnAddVenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddVenue.FlatAppearance.BorderSize = 0;
            this.BtnAddVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddVenue.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnAddVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddVenue.Location = new System.Drawing.Point(3, 16);
            this.BtnAddVenue.Name = "BtnAddVenue";
            this.BtnAddVenue.Size = new System.Drawing.Size(112, 62);
            this.BtnAddVenue.TabIndex = 0;
            this.BtnAddVenue.Text = "Add";
            this.BtnAddVenue.UseVisualStyleBackColor = true;
            this.BtnAddVenue.Click += new System.EventHandler(this.BtnAddVenue_Click);
            // 
            // BtnRefreshVenues
            // 
            this.BtnRefreshVenues.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRefreshVenues.FlatAppearance.BorderSize = 0;
            this.BtnRefreshVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshVenues.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnRefreshVenues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRefreshVenues.Location = new System.Drawing.Point(743, 16);
            this.BtnRefreshVenues.Name = "BtnRefreshVenues";
            this.BtnRefreshVenues.Size = new System.Drawing.Size(106, 62);
            this.BtnRefreshVenues.TabIndex = 4;
            this.BtnRefreshVenues.Text = "Refresh";
            this.BtnRefreshVenues.UseVisualStyleBackColor = true;
            this.BtnRefreshVenues.Click += new System.EventHandler(this.BtnRefreshVenues_Click);
            // 
            // btnClearVenue
            // 
            this.btnClearVenue.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearVenue.FlatAppearance.BorderSize = 0;
            this.btnClearVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearVenue.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnClearVenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearVenue.Location = new System.Drawing.Point(849, 16);
            this.btnClearVenue.Name = "btnClearVenue";
            this.btnClearVenue.Size = new System.Drawing.Size(112, 62);
            this.btnClearVenue.TabIndex = 3;
            this.btnClearVenue.Text = "Clear";
            this.btnClearVenue.UseVisualStyleBackColor = true;
            this.btnClearVenue.Click += new System.EventHandler(this.BtnClearVenue_Click);
            // 
            // LstbxVenues
            // 
            this.LstbxVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstbxVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxVenues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxVenues.DisplayMember = "VenueId";
            this.LstbxVenues.Font = new System.Drawing.Font("Lucida Fax", 11F);
            this.LstbxVenues.ForeColor = System.Drawing.Color.Silver;
            this.LstbxVenues.FormattingEnabled = true;
            this.LstbxVenues.ItemHeight = 17;
            this.LstbxVenues.Location = new System.Drawing.Point(3, 5);
            this.LstbxVenues.Name = "LstbxVenues";
            this.LstbxVenues.Size = new System.Drawing.Size(548, 408);
            this.LstbxVenues.TabIndex = 21;
            this.LstbxVenues.SelectedValueChanged += new System.EventHandler(this.LstbxVenues_SelectedValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox8.Controls.Add(this.TxtVenueAddress);
            this.groupBox8.Controls.Add(this.TxtVenueName);
            this.groupBox8.Controls.Add(this.TxtVenueId);
            this.groupBox8.Controls.Add(this.NudMaxWorkers);
            this.groupBox8.Controls.Add(this.NudVenueRating);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(569, 29);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(396, 397);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            // 
            // TxtVenueAddress
            // 
            this.TxtVenueAddress.BackColor = System.Drawing.Color.Gray;
            this.TxtVenueAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVenueAddress.ForeColor = System.Drawing.Color.Silver;
            this.TxtVenueAddress.Location = new System.Drawing.Point(19, 150);
            this.TxtVenueAddress.MaxLength = 1000;
            this.TxtVenueAddress.Name = "TxtVenueAddress";
            this.TxtVenueAddress.Size = new System.Drawing.Size(242, 126);
            this.TxtVenueAddress.TabIndex = 12;
            this.TxtVenueAddress.Text = "";
            // 
            // TxtVenueName
            // 
            this.TxtVenueName.BackColor = System.Drawing.Color.Gray;
            this.TxtVenueName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVenueName.ForeColor = System.Drawing.Color.Silver;
            this.TxtVenueName.Location = new System.Drawing.Point(19, 97);
            this.TxtVenueName.Name = "TxtVenueName";
            this.TxtVenueName.Size = new System.Drawing.Size(242, 20);
            this.TxtVenueName.TabIndex = 11;
            // 
            // TxtVenueId
            // 
            this.TxtVenueId.BackColor = System.Drawing.Color.Gray;
            this.TxtVenueId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVenueId.ForeColor = System.Drawing.Color.Silver;
            this.TxtVenueId.Location = new System.Drawing.Point(19, 47);
            this.TxtVenueId.Name = "TxtVenueId";
            this.TxtVenueId.Size = new System.Drawing.Size(242, 20);
            this.TxtVenueId.TabIndex = 11;
            // 
            // NudMaxWorkers
            // 
            this.NudMaxWorkers.BackColor = System.Drawing.Color.Gray;
            this.NudMaxWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudMaxWorkers.ForeColor = System.Drawing.Color.White;
            this.NudMaxWorkers.Location = new System.Drawing.Point(19, 308);
            this.NudMaxWorkers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMaxWorkers.Name = "NudMaxWorkers";
            this.NudMaxWorkers.Size = new System.Drawing.Size(76, 20);
            this.NudMaxWorkers.TabIndex = 10;
            this.NudMaxWorkers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudVenueRating
            // 
            this.NudVenueRating.BackColor = System.Drawing.Color.Gray;
            this.NudVenueRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudVenueRating.ForeColor = System.Drawing.Color.White;
            this.NudVenueRating.Location = new System.Drawing.Point(19, 358);
            this.NudVenueRating.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudVenueRating.Name = "NudVenueRating";
            this.NudVenueRating.Size = new System.Drawing.Size(76, 20);
            this.NudVenueRating.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(16, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(16, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Venue name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Max number of workers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Venue rating";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(633, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Search by Id";
            // 
            // TxtSearchVenue
            // 
            this.TxtSearchVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchVenue.BackColor = System.Drawing.Color.Silver;
            this.TxtSearchVenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearchVenue.Location = new System.Drawing.Point(706, 3);
            this.TxtSearchVenue.Name = "TxtSearchVenue";
            this.TxtSearchVenue.Size = new System.Drawing.Size(242, 20);
            this.TxtSearchVenue.TabIndex = 22;
            this.TxtSearchVenue.TabStop = false;
            this.TxtSearchVenue.TextChanged += new System.EventHandler(this.TxtSearchVenue_TextChanged);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Services.Controls.Add(this.groupBox2);
            this.Services.Controls.Add(this.LstbxServices);
            this.Services.Controls.Add(this.groupBox5);
            this.Services.Controls.Add(this.label8);
            this.Services.Controls.Add(this.TxtSearchServices);
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(970, 500);
            this.Services.TabIndex = 3;
            this.Services.Text = "Services";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DeleteAllServices);
            this.groupBox2.Controls.Add(this.BtnDeleteService);
            this.groupBox2.Controls.Add(this.BtnRefreshService);
            this.groupBox2.Controls.Add(this.BtnUpdateService);
            this.groupBox2.Controls.Add(this.BtnAddService);
            this.groupBox2.Controls.Add(this.BtnClearService);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // DeleteAllServices
            // 
            this.DeleteAllServices.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteAllServices.FlatAppearance.BorderSize = 0;
            this.DeleteAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllServices.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.DeleteAllServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteAllServices.Location = new System.Drawing.Point(630, 16);
            this.DeleteAllServices.Name = "DeleteAllServices";
            this.DeleteAllServices.Size = new System.Drawing.Size(113, 62);
            this.DeleteAllServices.TabIndex = 5;
            this.DeleteAllServices.Text = "Delete all";
            this.DeleteAllServices.UseVisualStyleBackColor = true;
            this.DeleteAllServices.Click += new System.EventHandler(this.DeleteAllServices_Click);
            // 
            // BtnDeleteService
            // 
            this.BtnDeleteService.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteService.FlatAppearance.BorderSize = 0;
            this.BtnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteService.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnDeleteService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDeleteService.Location = new System.Drawing.Point(227, 16);
            this.BtnDeleteService.Name = "BtnDeleteService";
            this.BtnDeleteService.Size = new System.Drawing.Size(112, 62);
            this.BtnDeleteService.TabIndex = 2;
            this.BtnDeleteService.Text = "Delete";
            this.BtnDeleteService.UseVisualStyleBackColor = true;
            this.BtnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // BtnRefreshService
            // 
            this.BtnRefreshService.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRefreshService.FlatAppearance.BorderSize = 0;
            this.BtnRefreshService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefreshService.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnRefreshService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRefreshService.Location = new System.Drawing.Point(743, 16);
            this.BtnRefreshService.Name = "BtnRefreshService";
            this.BtnRefreshService.Size = new System.Drawing.Size(106, 62);
            this.BtnRefreshService.TabIndex = 4;
            this.BtnRefreshService.Text = "Refresh";
            this.BtnRefreshService.UseVisualStyleBackColor = true;
            this.BtnRefreshService.Click += new System.EventHandler(this.BtnRefreshService_Click);
            // 
            // BtnUpdateService
            // 
            this.BtnUpdateService.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnUpdateService.FlatAppearance.BorderSize = 0;
            this.BtnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateService.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnUpdateService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnUpdateService.Location = new System.Drawing.Point(115, 16);
            this.BtnUpdateService.Name = "BtnUpdateService";
            this.BtnUpdateService.Size = new System.Drawing.Size(112, 62);
            this.BtnUpdateService.TabIndex = 1;
            this.BtnUpdateService.Text = "Update";
            this.BtnUpdateService.UseVisualStyleBackColor = true;
            this.BtnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // BtnAddService
            // 
            this.BtnAddService.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddService.FlatAppearance.BorderSize = 0;
            this.BtnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddService.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddService.Location = new System.Drawing.Point(3, 16);
            this.BtnAddService.Name = "BtnAddService";
            this.BtnAddService.Size = new System.Drawing.Size(112, 62);
            this.BtnAddService.TabIndex = 0;
            this.BtnAddService.Text = "Add";
            this.BtnAddService.UseVisualStyleBackColor = true;
            this.BtnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // BtnClearService
            // 
            this.BtnClearService.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClearService.FlatAppearance.BorderSize = 0;
            this.BtnClearService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearService.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnClearService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClearService.Location = new System.Drawing.Point(849, 16);
            this.BtnClearService.Name = "BtnClearService";
            this.BtnClearService.Size = new System.Drawing.Size(112, 62);
            this.BtnClearService.TabIndex = 3;
            this.BtnClearService.Text = "Clear";
            this.BtnClearService.UseVisualStyleBackColor = true;
            this.BtnClearService.Click += new System.EventHandler(this.BtnClearService_Click);
            // 
            // LstbxServices
            // 
            this.LstbxServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstbxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxServices.DisplayMember = "ServiceId";
            this.LstbxServices.Font = new System.Drawing.Font("Lucida Fax", 11F);
            this.LstbxServices.ForeColor = System.Drawing.Color.Silver;
            this.LstbxServices.FormattingEnabled = true;
            this.LstbxServices.ItemHeight = 17;
            this.LstbxServices.Location = new System.Drawing.Point(3, 5);
            this.LstbxServices.Name = "LstbxServices";
            this.LstbxServices.Size = new System.Drawing.Size(551, 408);
            this.LstbxServices.TabIndex = 11;
            this.LstbxServices.SelectedValueChanged += new System.EventHandler(this.LstbxServices_SelectedValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.TxtServiceName);
            this.groupBox5.Controls.Add(this.TxtServiceDuration);
            this.groupBox5.Controls.Add(this.TxtServiceStartTime);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.TxtServiceId);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(569, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(396, 397);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Service name";
            // 
            // TxtServiceName
            // 
            this.TxtServiceName.BackColor = System.Drawing.Color.Gray;
            this.TxtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtServiceName.ForeColor = System.Drawing.Color.White;
            this.TxtServiceName.Location = new System.Drawing.Point(19, 98);
            this.TxtServiceName.MaxLength = 30;
            this.TxtServiceName.Name = "TxtServiceName";
            this.TxtServiceName.Size = new System.Drawing.Size(242, 20);
            this.TxtServiceName.TabIndex = 9;
            // 
            // TxtServiceDuration
            // 
            this.TxtServiceDuration.BackColor = System.Drawing.Color.Gray;
            this.TxtServiceDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtServiceDuration.ForeColor = System.Drawing.Color.White;
            this.TxtServiceDuration.Location = new System.Drawing.Point(19, 207);
            this.TxtServiceDuration.Mask = "00:00:00";
            this.TxtServiceDuration.Name = "TxtServiceDuration";
            this.TxtServiceDuration.Size = new System.Drawing.Size(87, 20);
            this.TxtServiceDuration.TabIndex = 2;
            // 
            // TxtServiceStartTime
            // 
            this.TxtServiceStartTime.BackColor = System.Drawing.Color.Gray;
            this.TxtServiceStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtServiceStartTime.ForeColor = System.Drawing.Color.White;
            this.TxtServiceStartTime.Location = new System.Drawing.Point(19, 154);
            this.TxtServiceStartTime.Mask = "00:00";
            this.TxtServiceStartTime.Name = "TxtServiceStartTime";
            this.TxtServiceStartTime.Size = new System.Drawing.Size(87, 20);
            this.TxtServiceStartTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service ID";
            // 
            // TxtServiceId
            // 
            this.TxtServiceId.BackColor = System.Drawing.Color.Gray;
            this.TxtServiceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtServiceId.ForeColor = System.Drawing.Color.White;
            this.TxtServiceId.Location = new System.Drawing.Point(19, 47);
            this.TxtServiceId.MaxLength = 30;
            this.TxtServiceId.Name = "TxtServiceId";
            this.TxtServiceId.Size = new System.Drawing.Size(242, 20);
            this.TxtServiceId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Start time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Duration";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Search by Id";
            // 
            // TxtSearchServices
            // 
            this.TxtSearchServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchServices.BackColor = System.Drawing.Color.Silver;
            this.TxtSearchServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearchServices.Location = new System.Drawing.Point(706, 3);
            this.TxtSearchServices.Name = "TxtSearchServices";
            this.TxtSearchServices.Size = new System.Drawing.Size(242, 20);
            this.TxtSearchServices.TabIndex = 12;
            this.TxtSearchServices.TextChanged += new System.EventHandler(this.TxtSearchServices_TextChanged);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(967, 518);
            this.Controls.Add(this.TabctrlManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAdmin";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.Workers.ResumeLayout(false);
            this.Workers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWorkerVenueRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.TabctrlManager.ResumeLayout(false);
            this.Venues.ResumeLayout(false);
            this.Venues.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVenueRating)).EndInit();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Workers;
        private System.Windows.Forms.TabControl TabctrlManager;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDeleteService;
        private System.Windows.Forms.Button BtnUpdateService;
        private System.Windows.Forms.Button BtnAddService;
        private System.Windows.Forms.ListBox LstbxServices;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteAllServices;
        private System.Windows.Forms.TextBox TxtServiceId;
        private System.Windows.Forms.Button BtnRefreshService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClearService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSearchServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDeleteWorker;
        private System.Windows.Forms.Button BtnUpdateWorker;
        private System.Windows.Forms.Button BtnAddMember;
        private System.Windows.Forms.ListBox LstbxWorkers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeleteAllWorkers;
        private System.Windows.Forms.Button BtnRefreshWorkers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblVenueRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchWorkers;
        private System.Windows.Forms.NumericUpDown NudWorkerVenueRating;
        private System.Windows.Forms.TabPage Venues;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDeleteVenue;
        private System.Windows.Forms.Button DeleteAllVenues;
        private System.Windows.Forms.Button btnUpdateVenue;
        private System.Windows.Forms.Button BtnAddVenue;
        private System.Windows.Forms.Button BtnRefreshVenues;
        private System.Windows.Forms.Button btnClearVenue;
        private System.Windows.Forms.ListBox LstbxVenues;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown NudVenueRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtSearchVenue;
        private System.Windows.Forms.NumericUpDown NudMaxWorkers;
        private System.Windows.Forms.MaskedTextBox TxtServiceStartTime;
        private System.Windows.Forms.MaskedTextBox TxtServiceDuration;
        private System.Windows.Forms.MaskedTextBox TxtWorkerId;
        private System.Windows.Forms.MaskedTextBox TxtWorkerName;
        private System.Windows.Forms.MaskedTextBox TxtVenueId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox TxtCellNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TxtAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox TxtWorkerSurname;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.RichTextBox TxtVenueAddress;
        private System.Windows.Forms.MaskedTextBox TxtVenueName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtServiceName;
    }
}