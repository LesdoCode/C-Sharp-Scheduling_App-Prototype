using System.Threading;
using System.Threading.Tasks;

namespace schedule_app_prototype
{
    partial class DashBoard
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lstbxSchedule = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblLogo = new System.Windows.Forms.Label();
            this.BtnDisplaySchedule = new System.Windows.Forms.Button();
            this.BtnAvailWorkers = new System.Windows.Forms.Button();
            this.BtnAutoSchedule = new System.Windows.Forms.Button();
            this.grpTabbedControls = new System.Windows.Forms.GroupBox();
            this.TabCreateEvent = new System.Windows.Forms.TabControl();
            this.DashBoardTab = new System.Windows.Forms.TabPage();
            this.LblLoggedInAdmin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AssignWorkersTab = new System.Windows.Forms.TabPage();
            this.btnSaveVenueWorkers = new System.Windows.Forms.Button();
            this.chkShowAllWorkers = new System.Windows.Forms.CheckBox();
            this.BtnRevertAllWorkers = new System.Windows.Forms.Button();
            this.BtnSendMaxWorkers = new System.Windows.Forms.Button();
            this.BtnComitServiceWorkers = new System.Windows.Forms.Button();
            this.btnRollbackVenueWorkers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LstbxSelectedWorkers = new System.Windows.Forms.ListBox();
            this.LstbxAvailableWorkers = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DudVenueIds = new System.Windows.Forms.DomainUpDown();
            this.MakeServiceTab = new System.Windows.Forms.TabPage();
            this.chkShowAllVenues = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LstbxSelectedVenues = new System.Windows.Forms.ListBox();
            this.LstbxAllVenues = new System.Windows.Forms.ListBox();
            this.BtnRevertAllVenues = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSendAllVenues = new System.Windows.Forms.Button();
            this.DudServiceId = new System.Windows.Forms.DomainUpDown();
            this.BtnSaveServiceVenues = new System.Windows.Forms.Button();
            this.BtnCommitVenues = new System.Windows.Forms.Button();
            this.BtnRollBackServiceVenues = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.TabPage();
            this.BtnSaveEvents = new System.Windows.Forms.Button();
            this.BtnAddToExistingEvent = new System.Windows.Forms.Button();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.TxtEventId = new System.Windows.Forms.MaskedTextBox();
            this.TxtEventName = new System.Windows.Forms.MaskedTextBox();
            this.BtnCreateEvent = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LstbxSelectedServices = new System.Windows.Forms.ListBox();
            this.LstbxServices = new System.Windows.Forms.ListBox();
            this.BtnRevertAllServices = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSendAllServices = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TabPage();
            this.BtnAddNotes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadWorkers = new System.Windows.Forms.RadioButton();
            this.RadSchedule = new System.Windows.Forms.RadioButton();
            this.RadVenues = new System.Windows.Forms.RadioButton();
            this.RadServices = new System.Windows.Forms.RadioButton();
            this.RadEvents = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpTabbedControls.SuspendLayout();
            this.TabCreateEvent.SuspendLayout();
            this.DashBoardTab.SuspendLayout();
            this.AssignWorkersTab.SuspendLayout();
            this.MakeServiceTab.SuspendLayout();
            this.Events.SuspendLayout();
            this.Notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmin.Location = new System.Drawing.Point(3, 16);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(113, 56);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lstbxSchedule
            // 
            this.lstbxSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lstbxSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbxSchedule.DisplayMember = "Name";
            this.lstbxSchedule.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSchedule.ForeColor = System.Drawing.Color.Olive;
            this.lstbxSchedule.FormattingEnabled = true;
            this.lstbxSchedule.ItemHeight = 19;
            this.lstbxSchedule.Location = new System.Drawing.Point(3, 16);
            this.lstbxSchedule.Name = "lstbxSchedule";
            this.lstbxSchedule.Size = new System.Drawing.Size(385, 420);
            this.lstbxSchedule.TabIndex = 1;
            this.lstbxSchedule.TabStop = false;
            this.lstbxSchedule.SelectedIndexChanged += new System.EventHandler(this.lstbxSchedule_SelectedIndexChanged);
            this.lstbxSchedule.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbxSchedule_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.LblLogo);
            this.groupBox1.Controls.Add(this.BtnDisplaySchedule);
            this.groupBox1.Controls.Add(this.BtnAvailWorkers);
            this.groupBox1.Controls.Add(this.BtnAutoSchedule);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLogin.Location = new System.Drawing.Point(459, 16);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(117, 56);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblLogo
            // 
            this.LblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLogo.AutoSize = true;
            this.LblLogo.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogo.ForeColor = System.Drawing.Color.DarkViolet;
            this.LblLogo.Location = new System.Drawing.Point(1039, 29);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(151, 28);
            this.LblLogo.TabIndex = 6;
            this.LblLogo.Text = "A product of LesdoCode\r\n© LesdoCode 2021";
            this.LblLogo.DoubleClick += new System.EventHandler(this.LblLogo_DoubleClick);
            // 
            // BtnDisplaySchedule
            // 
            this.BtnDisplaySchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDisplaySchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnDisplaySchedule.FlatAppearance.BorderSize = 0;
            this.BtnDisplaySchedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnDisplaySchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnDisplaySchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDisplaySchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisplaySchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplaySchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDisplaySchedule.Location = new System.Drawing.Point(342, 16);
            this.BtnDisplaySchedule.Name = "BtnDisplaySchedule";
            this.BtnDisplaySchedule.Size = new System.Drawing.Size(117, 56);
            this.BtnDisplaySchedule.TabIndex = 3;
            this.BtnDisplaySchedule.Text = "Display Schedule";
            this.BtnDisplaySchedule.UseVisualStyleBackColor = true;
            this.BtnDisplaySchedule.Click += new System.EventHandler(this.BtnDisplaySchedule_Click);
            // 
            // BtnAvailWorkers
            // 
            this.BtnAvailWorkers.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAvailWorkers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAvailWorkers.FlatAppearance.BorderSize = 0;
            this.BtnAvailWorkers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAvailWorkers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAvailWorkers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAvailWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvailWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvailWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAvailWorkers.Location = new System.Drawing.Point(229, 16);
            this.BtnAvailWorkers.Name = "BtnAvailWorkers";
            this.BtnAvailWorkers.Size = new System.Drawing.Size(113, 56);
            this.BtnAvailWorkers.TabIndex = 2;
            this.BtnAvailWorkers.Text = "Avail Workers";
            this.BtnAvailWorkers.UseVisualStyleBackColor = true;
            this.BtnAvailWorkers.Click += new System.EventHandler(this.BtnAvailWorkers_Click);
            // 
            // BtnAutoSchedule
            // 
            this.BtnAutoSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAutoSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAutoSchedule.FlatAppearance.BorderSize = 0;
            this.BtnAutoSchedule.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAutoSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAutoSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAutoSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutoSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutoSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAutoSchedule.Location = new System.Drawing.Point(116, 16);
            this.BtnAutoSchedule.Name = "BtnAutoSchedule";
            this.BtnAutoSchedule.Size = new System.Drawing.Size(113, 56);
            this.BtnAutoSchedule.TabIndex = 1;
            this.BtnAutoSchedule.Text = "Auto Schedule";
            this.BtnAutoSchedule.UseVisualStyleBackColor = true;
            this.BtnAutoSchedule.Click += new System.EventHandler(this.BtnAutoSchedule_Click);
            // 
            // grpTabbedControls
            // 
            this.grpTabbedControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpTabbedControls.Controls.Add(this.TabCreateEvent);
            this.grpTabbedControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTabbedControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTabbedControls.Location = new System.Drawing.Point(0, 0);
            this.grpTabbedControls.Margin = new System.Windows.Forms.Padding(0);
            this.grpTabbedControls.Name = "grpTabbedControls";
            this.grpTabbedControls.Padding = new System.Windows.Forms.Padding(0);
            this.grpTabbedControls.Size = new System.Drawing.Size(807, 483);
            this.grpTabbedControls.TabIndex = 5;
            this.grpTabbedControls.TabStop = false;
            // 
            // TabCreateEvent
            // 
            this.TabCreateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCreateEvent.Controls.Add(this.DashBoardTab);
            this.TabCreateEvent.Controls.Add(this.AssignWorkersTab);
            this.TabCreateEvent.Controls.Add(this.MakeServiceTab);
            this.TabCreateEvent.Controls.Add(this.Events);
            this.TabCreateEvent.Controls.Add(this.Notes);
            this.TabCreateEvent.Font = new System.Drawing.Font("Lucida Fax", 8.25F);
            this.TabCreateEvent.HotTrack = true;
            this.TabCreateEvent.ItemSize = new System.Drawing.Size(150, 19);
            this.TabCreateEvent.Location = new System.Drawing.Point(-4, 9);
            this.TabCreateEvent.Margin = new System.Windows.Forms.Padding(0);
            this.TabCreateEvent.Multiline = true;
            this.TabCreateEvent.Name = "TabCreateEvent";
            this.TabCreateEvent.Padding = new System.Drawing.Point(0, 0);
            this.TabCreateEvent.SelectedIndex = 0;
            this.TabCreateEvent.Size = new System.Drawing.Size(862, 469);
            this.TabCreateEvent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCreateEvent.TabIndex = 0;
            this.TabCreateEvent.TabStop = false;
            this.TabCreateEvent.SelectedIndexChanged += new System.EventHandler(this.TabCreateEvent_SelectedIndexChanged);
            // 
            // DashBoardTab
            // 
            this.DashBoardTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashBoardTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashBoardTab.Controls.Add(this.LblLoggedInAdmin);
            this.DashBoardTab.Controls.Add(this.label8);
            this.DashBoardTab.Location = new System.Drawing.Point(4, 23);
            this.DashBoardTab.Margin = new System.Windows.Forms.Padding(0);
            this.DashBoardTab.Name = "DashBoardTab";
            this.DashBoardTab.Padding = new System.Windows.Forms.Padding(3);
            this.DashBoardTab.Size = new System.Drawing.Size(854, 442);
            this.DashBoardTab.TabIndex = 0;
            this.DashBoardTab.Text = "Dashboard";
            // 
            // LblLoggedInAdmin
            // 
            this.LblLoggedInAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLoggedInAdmin.Font = new System.Drawing.Font("HP Simplified Jpan Light", 10F);
            this.LblLoggedInAdmin.ForeColor = System.Drawing.Color.Cyan;
            this.LblLoggedInAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLoggedInAdmin.Location = new System.Drawing.Point(685, 381);
            this.LblLoggedInAdmin.Name = "LblLoggedInAdmin";
            this.LblLoggedInAdmin.Size = new System.Drawing.Size(110, 48);
            this.LblLoggedInAdmin.TabIndex = 1;
            this.LblLoggedInAdmin.Text = "Admin logged out";
            this.LblLoggedInAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLoggedInAdmin.Click += new System.EventHandler(this.LblLoggedInAdmin_Click);
            this.LblLoggedInAdmin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LblLoggedInAdmin_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(162, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(461, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Follow the tabs above to create an event >>>";
            // 
            // AssignWorkersTab
            // 
            this.AssignWorkersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.AssignWorkersTab.Controls.Add(this.btnSaveVenueWorkers);
            this.AssignWorkersTab.Controls.Add(this.chkShowAllWorkers);
            this.AssignWorkersTab.Controls.Add(this.BtnRevertAllWorkers);
            this.AssignWorkersTab.Controls.Add(this.BtnSendMaxWorkers);
            this.AssignWorkersTab.Controls.Add(this.BtnComitServiceWorkers);
            this.AssignWorkersTab.Controls.Add(this.btnRollbackVenueWorkers);
            this.AssignWorkersTab.Controls.Add(this.label5);
            this.AssignWorkersTab.Controls.Add(this.label6);
            this.AssignWorkersTab.Controls.Add(this.LstbxSelectedWorkers);
            this.AssignWorkersTab.Controls.Add(this.LstbxAvailableWorkers);
            this.AssignWorkersTab.Controls.Add(this.label7);
            this.AssignWorkersTab.Controls.Add(this.DudVenueIds);
            this.AssignWorkersTab.Location = new System.Drawing.Point(4, 23);
            this.AssignWorkersTab.Name = "AssignWorkersTab";
            this.AssignWorkersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssignWorkersTab.Size = new System.Drawing.Size(854, 442);
            this.AssignWorkersTab.TabIndex = 2;
            this.AssignWorkersTab.Text = "Assign Workers";
            this.AssignWorkersTab.Click += new System.EventHandler(this.AssignWorkersTab_Click);
            // 
            // btnSaveVenueWorkers
            // 
            this.btnSaveVenueWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveVenueWorkers.FlatAppearance.BorderSize = 0;
            this.btnSaveVenueWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveVenueWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVenueWorkers.ForeColor = System.Drawing.Color.White;
            this.btnSaveVenueWorkers.Location = new System.Drawing.Point(691, 396);
            this.btnSaveVenueWorkers.Name = "btnSaveVenueWorkers";
            this.btnSaveVenueWorkers.Size = new System.Drawing.Size(113, 44);
            this.btnSaveVenueWorkers.TabIndex = 25;
            this.btnSaveVenueWorkers.Text = "Save >>";
            this.btnSaveVenueWorkers.UseVisualStyleBackColor = true;
            this.btnSaveVenueWorkers.Click += new System.EventHandler(this.btnSaveVenueWorkers_Click);
            // 
            // chkShowAllWorkers
            // 
            this.chkShowAllWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowAllWorkers.AutoSize = true;
            this.chkShowAllWorkers.ForeColor = System.Drawing.Color.Olive;
            this.chkShowAllWorkers.Location = new System.Drawing.Point(50, 370);
            this.chkShowAllWorkers.Name = "chkShowAllWorkers";
            this.chkShowAllWorkers.Size = new System.Drawing.Size(72, 18);
            this.chkShowAllWorkers.TabIndex = 41;
            this.chkShowAllWorkers.Text = "Show all";
            this.chkShowAllWorkers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowAllWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkShowAllWorkers.ThreeState = true;
            this.chkShowAllWorkers.UseVisualStyleBackColor = true;
            this.chkShowAllWorkers.CheckedChanged += new System.EventHandler(this.chkShowAllWorkers_CheckedChanged);
            // 
            // BtnRevertAllWorkers
            // 
            this.BtnRevertAllWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRevertAllWorkers.FlatAppearance.BorderSize = 0;
            this.BtnRevertAllWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRevertAllWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevertAllWorkers.ForeColor = System.Drawing.Color.Yellow;
            this.BtnRevertAllWorkers.Location = new System.Drawing.Point(362, 254);
            this.BtnRevertAllWorkers.Name = "BtnRevertAllWorkers";
            this.BtnRevertAllWorkers.Size = new System.Drawing.Size(60, 44);
            this.BtnRevertAllWorkers.TabIndex = 20;
            this.BtnRevertAllWorkers.Text = "<<";
            this.BtnRevertAllWorkers.UseVisualStyleBackColor = true;
            this.BtnRevertAllWorkers.Click += new System.EventHandler(this.BtnRevertAllWorkers_Click);
            // 
            // BtnSendMaxWorkers
            // 
            this.BtnSendMaxWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSendMaxWorkers.FlatAppearance.BorderSize = 0;
            this.BtnSendMaxWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendMaxWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendMaxWorkers.ForeColor = System.Drawing.Color.Yellow;
            this.BtnSendMaxWorkers.Location = new System.Drawing.Point(362, 204);
            this.BtnSendMaxWorkers.Name = "BtnSendMaxWorkers";
            this.BtnSendMaxWorkers.Size = new System.Drawing.Size(60, 44);
            this.BtnSendMaxWorkers.TabIndex = 19;
            this.BtnSendMaxWorkers.Text = ">>";
            this.BtnSendMaxWorkers.UseVisualStyleBackColor = true;
            this.BtnSendMaxWorkers.Click += new System.EventHandler(this.BtnSendMaxWorkers_Click);
            // 
            // BtnComitServiceWorkers
            // 
            this.BtnComitServiceWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnComitServiceWorkers.FlatAppearance.BorderSize = 0;
            this.BtnComitServiceWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComitServiceWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComitServiceWorkers.ForeColor = System.Drawing.Color.White;
            this.BtnComitServiceWorkers.Location = new System.Drawing.Point(568, 396);
            this.BtnComitServiceWorkers.Name = "BtnComitServiceWorkers";
            this.BtnComitServiceWorkers.Size = new System.Drawing.Size(117, 44);
            this.BtnComitServiceWorkers.TabIndex = 26;
            this.BtnComitServiceWorkers.Text = "Commit >>";
            this.BtnComitServiceWorkers.UseVisualStyleBackColor = true;
            this.BtnComitServiceWorkers.Click += new System.EventHandler(this.BtnComitServiceWorkers_Click);
            // 
            // btnRollbackVenueWorkers
            // 
            this.btnRollbackVenueWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRollbackVenueWorkers.FlatAppearance.BorderSize = 0;
            this.btnRollbackVenueWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollbackVenueWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollbackVenueWorkers.ForeColor = System.Drawing.Color.White;
            this.btnRollbackVenueWorkers.Location = new System.Drawing.Point(6, 396);
            this.btnRollbackVenueWorkers.Name = "btnRollbackVenueWorkers";
            this.btnRollbackVenueWorkers.Size = new System.Drawing.Size(113, 44);
            this.btnRollbackVenueWorkers.TabIndex = 25;
            this.btnRollbackVenueWorkers.Text = "<< Roll back";
            this.btnRollbackVenueWorkers.UseVisualStyleBackColor = true;
            this.btnRollbackVenueWorkers.Click += new System.EventHandler(this.btnRollbackVenueWorkers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(425, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Assigned to this venue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(47, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "All available workers";
            // 
            // LstbxSelectedWorkers
            // 
            this.LstbxSelectedWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxSelectedWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxSelectedWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxSelectedWorkers.DisplayMember = "Name";
            this.LstbxSelectedWorkers.ForeColor = System.Drawing.Color.Black;
            this.LstbxSelectedWorkers.FormattingEnabled = true;
            this.LstbxSelectedWorkers.ItemHeight = 14;
            this.LstbxSelectedWorkers.Location = new System.Drawing.Point(428, 126);
            this.LstbxSelectedWorkers.Name = "LstbxSelectedWorkers";
            this.LstbxSelectedWorkers.Size = new System.Drawing.Size(306, 238);
            this.LstbxSelectedWorkers.TabIndex = 22;
            this.LstbxSelectedWorkers.SelectedIndexChanged += new System.EventHandler(this.LstbxSelectedWorkers_SelectedIndexChanged);
            this.LstbxSelectedWorkers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstbxSelectedWorkers_MouseDoubleClick);
            // 
            // LstbxAvailableWorkers
            // 
            this.LstbxAvailableWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxAvailableWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxAvailableWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxAvailableWorkers.DisplayMember = "Name";
            this.LstbxAvailableWorkers.ForeColor = System.Drawing.Color.Black;
            this.LstbxAvailableWorkers.FormattingEnabled = true;
            this.LstbxAvailableWorkers.ItemHeight = 14;
            this.LstbxAvailableWorkers.Location = new System.Drawing.Point(50, 126);
            this.LstbxAvailableWorkers.Name = "LstbxAvailableWorkers";
            this.LstbxAvailableWorkers.Size = new System.Drawing.Size(306, 238);
            this.LstbxAvailableWorkers.TabIndex = 21;
            this.LstbxAvailableWorkers.SelectedIndexChanged += new System.EventHandler(this.LstbxAvailableWorkers_SelectedIndexChanged);
            this.LstbxAvailableWorkers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstbxAvailableWorkers_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Venues";
            // 
            // DudVenueIds
            // 
            this.DudVenueIds.BackColor = System.Drawing.Color.Gray;
            this.DudVenueIds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DudVenueIds.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.DudVenueIds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DudVenueIds.Location = new System.Drawing.Point(50, 65);
            this.DudVenueIds.Name = "DudVenueIds";
            this.DudVenueIds.Size = new System.Drawing.Size(233, 19);
            this.DudVenueIds.TabIndex = 16;
            this.DudVenueIds.Text = "choose a venue";
            this.DudVenueIds.SelectedItemChanged += new System.EventHandler(this.DudVenueIds_SelectedItemChanged);
            // 
            // MakeServiceTab
            // 
            this.MakeServiceTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.MakeServiceTab.Controls.Add(this.chkShowAllVenues);
            this.MakeServiceTab.Controls.Add(this.label4);
            this.MakeServiceTab.Controls.Add(this.label3);
            this.MakeServiceTab.Controls.Add(this.LstbxSelectedVenues);
            this.MakeServiceTab.Controls.Add(this.LstbxAllVenues);
            this.MakeServiceTab.Controls.Add(this.BtnRevertAllVenues);
            this.MakeServiceTab.Controls.Add(this.label2);
            this.MakeServiceTab.Controls.Add(this.BtnSendAllVenues);
            this.MakeServiceTab.Controls.Add(this.DudServiceId);
            this.MakeServiceTab.Controls.Add(this.BtnSaveServiceVenues);
            this.MakeServiceTab.Controls.Add(this.BtnCommitVenues);
            this.MakeServiceTab.Controls.Add(this.BtnRollBackServiceVenues);
            this.MakeServiceTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MakeServiceTab.Location = new System.Drawing.Point(4, 23);
            this.MakeServiceTab.Name = "MakeServiceTab";
            this.MakeServiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.MakeServiceTab.Size = new System.Drawing.Size(854, 442);
            this.MakeServiceTab.TabIndex = 1;
            this.MakeServiceTab.Text = "Make Service";
            this.MakeServiceTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // chkShowAllVenues
            // 
            this.chkShowAllVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowAllVenues.AutoSize = true;
            this.chkShowAllVenues.ForeColor = System.Drawing.Color.Olive;
            this.chkShowAllVenues.Location = new System.Drawing.Point(50, 370);
            this.chkShowAllVenues.Name = "chkShowAllVenues";
            this.chkShowAllVenues.Size = new System.Drawing.Size(72, 18);
            this.chkShowAllVenues.TabIndex = 41;
            this.chkShowAllVenues.Text = "Show all";
            this.chkShowAllVenues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowAllVenues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkShowAllVenues.ThreeState = true;
            this.chkShowAllVenues.UseVisualStyleBackColor = true;
            this.chkShowAllVenues.CheckedChanged += new System.EventHandler(this.chkShowAllVenues_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(422, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Part of this service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(47, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "All venues";
            // 
            // LstbxSelectedVenues
            // 
            this.LstbxSelectedVenues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxSelectedVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxSelectedVenues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxSelectedVenues.DisplayMember = "VenueId";
            this.LstbxSelectedVenues.FormattingEnabled = true;
            this.LstbxSelectedVenues.ItemHeight = 14;
            this.LstbxSelectedVenues.Location = new System.Drawing.Point(428, 126);
            this.LstbxSelectedVenues.Name = "LstbxSelectedVenues";
            this.LstbxSelectedVenues.Size = new System.Drawing.Size(306, 238);
            this.LstbxSelectedVenues.TabIndex = 12;
            this.LstbxSelectedVenues.SelectedIndexChanged += new System.EventHandler(this.LstbxSelectedVenues_SelectedIndexChanged);
            // 
            // LstbxAllVenues
            // 
            this.LstbxAllVenues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxAllVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxAllVenues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxAllVenues.DisplayMember = "VenueId";
            this.LstbxAllVenues.FormattingEnabled = true;
            this.LstbxAllVenues.ItemHeight = 14;
            this.LstbxAllVenues.Location = new System.Drawing.Point(50, 126);
            this.LstbxAllVenues.Name = "LstbxAllVenues";
            this.LstbxAllVenues.Size = new System.Drawing.Size(306, 238);
            this.LstbxAllVenues.TabIndex = 11;
            this.LstbxAllVenues.SelectedIndexChanged += new System.EventHandler(this.LstbxAllVenues_SelectedIndexChanged);
            // 
            // BtnRevertAllVenues
            // 
            this.BtnRevertAllVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRevertAllVenues.FlatAppearance.BorderSize = 0;
            this.BtnRevertAllVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRevertAllVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevertAllVenues.ForeColor = System.Drawing.Color.Yellow;
            this.BtnRevertAllVenues.Location = new System.Drawing.Point(362, 254);
            this.BtnRevertAllVenues.Name = "BtnRevertAllVenues";
            this.BtnRevertAllVenues.Size = new System.Drawing.Size(60, 44);
            this.BtnRevertAllVenues.TabIndex = 10;
            this.BtnRevertAllVenues.Text = "<<";
            this.BtnRevertAllVenues.UseVisualStyleBackColor = true;
            this.BtnRevertAllVenues.Click += new System.EventHandler(this.BtnRevertAllVenues_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service";
            // 
            // BtnSendAllVenues
            // 
            this.BtnSendAllVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSendAllVenues.FlatAppearance.BorderSize = 0;
            this.BtnSendAllVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendAllVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendAllVenues.ForeColor = System.Drawing.Color.Yellow;
            this.BtnSendAllVenues.Location = new System.Drawing.Point(362, 204);
            this.BtnSendAllVenues.Name = "BtnSendAllVenues";
            this.BtnSendAllVenues.Size = new System.Drawing.Size(60, 44);
            this.BtnSendAllVenues.TabIndex = 9;
            this.BtnSendAllVenues.Text = ">>";
            this.BtnSendAllVenues.UseVisualStyleBackColor = true;
            this.BtnSendAllVenues.Click += new System.EventHandler(this.BtnSendAllVenues_Click);
            // 
            // DudServiceId
            // 
            this.DudServiceId.BackColor = System.Drawing.Color.Gray;
            this.DudServiceId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DudServiceId.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.DudServiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DudServiceId.Location = new System.Drawing.Point(50, 65);
            this.DudServiceId.Name = "DudServiceId";
            this.DudServiceId.Size = new System.Drawing.Size(233, 19);
            this.DudServiceId.TabIndex = 0;
            this.DudServiceId.Text = "choose a service";
            this.DudServiceId.SelectedItemChanged += new System.EventHandler(this.DudServiceId_SelectedItemChanged);
            // 
            // BtnSaveServiceVenues
            // 
            this.BtnSaveServiceVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveServiceVenues.FlatAppearance.BorderSize = 0;
            this.BtnSaveServiceVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveServiceVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveServiceVenues.ForeColor = System.Drawing.Color.White;
            this.BtnSaveServiceVenues.Location = new System.Drawing.Point(689, 396);
            this.BtnSaveServiceVenues.Name = "BtnSaveServiceVenues";
            this.BtnSaveServiceVenues.Size = new System.Drawing.Size(117, 44);
            this.BtnSaveServiceVenues.TabIndex = 8;
            this.BtnSaveServiceVenues.Text = "Save >>";
            this.BtnSaveServiceVenues.UseVisualStyleBackColor = true;
            this.BtnSaveServiceVenues.Click += new System.EventHandler(this.BtnSaveServiceVenues_Click);
            // 
            // BtnCommitVenues
            // 
            this.BtnCommitVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCommitVenues.FlatAppearance.BorderSize = 0;
            this.BtnCommitVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCommitVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommitVenues.ForeColor = System.Drawing.Color.White;
            this.BtnCommitVenues.Location = new System.Drawing.Point(568, 396);
            this.BtnCommitVenues.Name = "BtnCommitVenues";
            this.BtnCommitVenues.Size = new System.Drawing.Size(117, 44);
            this.BtnCommitVenues.TabIndex = 8;
            this.BtnCommitVenues.Text = "Commit >>";
            this.BtnCommitVenues.UseVisualStyleBackColor = true;
            this.BtnCommitVenues.Click += new System.EventHandler(this.BtnCommitVenues_Click);
            // 
            // BtnRollBackServiceVenues
            // 
            this.BtnRollBackServiceVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRollBackServiceVenues.FlatAppearance.BorderSize = 0;
            this.BtnRollBackServiceVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRollBackServiceVenues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRollBackServiceVenues.ForeColor = System.Drawing.Color.White;
            this.BtnRollBackServiceVenues.Location = new System.Drawing.Point(6, 396);
            this.BtnRollBackServiceVenues.Name = "BtnRollBackServiceVenues";
            this.BtnRollBackServiceVenues.Size = new System.Drawing.Size(113, 44);
            this.BtnRollBackServiceVenues.TabIndex = 7;
            this.BtnRollBackServiceVenues.Text = "<< Roll back";
            this.BtnRollBackServiceVenues.UseVisualStyleBackColor = true;
            this.BtnRollBackServiceVenues.Click += new System.EventHandler(this.BtnRollBackServiceVenues_Click);
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.Events.Controls.Add(this.BtnSaveEvents);
            this.Events.Controls.Add(this.BtnAddToExistingEvent);
            this.Events.Controls.Add(this.DtpDate);
            this.Events.Controls.Add(this.TxtEventId);
            this.Events.Controls.Add(this.TxtEventName);
            this.Events.Controls.Add(this.BtnCreateEvent);
            this.Events.Controls.Add(this.button6);
            this.Events.Controls.Add(this.label9);
            this.Events.Controls.Add(this.label10);
            this.Events.Controls.Add(this.LstbxSelectedServices);
            this.Events.Controls.Add(this.LstbxServices);
            this.Events.Controls.Add(this.BtnRevertAllServices);
            this.Events.Controls.Add(this.label13);
            this.Events.Controls.Add(this.label12);
            this.Events.Controls.Add(this.label11);
            this.Events.Controls.Add(this.BtnSendAllServices);
            this.Events.Location = new System.Drawing.Point(4, 23);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(854, 442);
            this.Events.TabIndex = 3;
            this.Events.Text = "Events";
            this.Events.Click += new System.EventHandler(this.Events_Click);
            // 
            // BtnSaveEvents
            // 
            this.BtnSaveEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveEvents.FlatAppearance.BorderSize = 0;
            this.BtnSaveEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEvents.ForeColor = System.Drawing.Color.White;
            this.BtnSaveEvents.Location = new System.Drawing.Point(689, 396);
            this.BtnSaveEvents.Name = "BtnSaveEvents";
            this.BtnSaveEvents.Size = new System.Drawing.Size(117, 44);
            this.BtnSaveEvents.TabIndex = 41;
            this.BtnSaveEvents.TabStop = false;
            this.BtnSaveEvents.Text = "Save >>";
            this.BtnSaveEvents.UseVisualStyleBackColor = true;
            this.BtnSaveEvents.Click += new System.EventHandler(this.BtnSaveEvents_Click);
            // 
            // BtnAddToExistingEvent
            // 
            this.BtnAddToExistingEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddToExistingEvent.FlatAppearance.BorderSize = 0;
            this.BtnAddToExistingEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddToExistingEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToExistingEvent.ForeColor = System.Drawing.Color.White;
            this.BtnAddToExistingEvent.Location = new System.Drawing.Point(441, 397);
            this.BtnAddToExistingEvent.Name = "BtnAddToExistingEvent";
            this.BtnAddToExistingEvent.Size = new System.Drawing.Size(117, 44);
            this.BtnAddToExistingEvent.TabIndex = 39;
            this.BtnAddToExistingEvent.TabStop = false;
            this.BtnAddToExistingEvent.Text = "Add to Existing >>";
            this.BtnAddToExistingEvent.UseVisualStyleBackColor = true;
            this.BtnAddToExistingEvent.Click += new System.EventHandler(this.BtnAddToExistingEvent_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.DtpDate.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.DtpDate.Location = new System.Drawing.Point(428, 64);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(199, 20);
            this.DtpDate.TabIndex = 3;
            // 
            // TxtEventId
            // 
            this.TxtEventId.BackColor = System.Drawing.Color.Gray;
            this.TxtEventId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEventId.Location = new System.Drawing.Point(50, 64);
            this.TxtEventId.Name = "TxtEventId";
            this.TxtEventId.Size = new System.Drawing.Size(133, 20);
            this.TxtEventId.TabIndex = 0;
            // 
            // TxtEventName
            // 
            this.TxtEventName.BackColor = System.Drawing.Color.Gray;
            this.TxtEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEventName.Location = new System.Drawing.Point(204, 64);
            this.TxtEventName.Name = "TxtEventName";
            this.TxtEventName.PromptChar = ' ';
            this.TxtEventName.Size = new System.Drawing.Size(199, 20);
            this.TxtEventName.TabIndex = 1;
            // 
            // BtnCreateEvent
            // 
            this.BtnCreateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateEvent.FlatAppearance.BorderSize = 0;
            this.BtnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.BtnCreateEvent.Location = new System.Drawing.Point(566, 396);
            this.BtnCreateEvent.Name = "BtnCreateEvent";
            this.BtnCreateEvent.Size = new System.Drawing.Size(117, 44);
            this.BtnCreateEvent.TabIndex = 36;
            this.BtnCreateEvent.TabStop = false;
            this.BtnCreateEvent.Text = "Create event >>";
            this.BtnCreateEvent.UseVisualStyleBackColor = true;
            this.BtnCreateEvent.Click += new System.EventHandler(this.BtnCreateEvent_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(6, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 44);
            this.button6.TabIndex = 35;
            this.button6.TabStop = false;
            this.button6.Text = "<< Roll back";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(425, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 14);
            this.label9.TabIndex = 34;
            this.label9.Text = "Part of this event";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(47, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 14);
            this.label10.TabIndex = 33;
            this.label10.Text = "Selected services";
            // 
            // LstbxSelectedServices
            // 
            this.LstbxSelectedServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxSelectedServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxSelectedServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxSelectedServices.DisplayMember = "ServiceId";
            this.LstbxSelectedServices.ForeColor = System.Drawing.Color.Black;
            this.LstbxSelectedServices.FormattingEnabled = true;
            this.LstbxSelectedServices.ItemHeight = 14;
            this.LstbxSelectedServices.Location = new System.Drawing.Point(428, 126);
            this.LstbxSelectedServices.Name = "LstbxSelectedServices";
            this.LstbxSelectedServices.Size = new System.Drawing.Size(306, 238);
            this.LstbxSelectedServices.TabIndex = 32;
            this.LstbxSelectedServices.TabStop = false;
            this.LstbxSelectedServices.SelectedIndexChanged += new System.EventHandler(this.LstbxSelectedServices_SelectedIndexChanged);
            // 
            // LstbxServices
            // 
            this.LstbxServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LstbxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstbxServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstbxServices.DisplayMember = "ServiceId";
            this.LstbxServices.ForeColor = System.Drawing.Color.Black;
            this.LstbxServices.FormattingEnabled = true;
            this.LstbxServices.ItemHeight = 14;
            this.LstbxServices.Location = new System.Drawing.Point(50, 126);
            this.LstbxServices.Name = "LstbxServices";
            this.LstbxServices.Size = new System.Drawing.Size(306, 238);
            this.LstbxServices.TabIndex = 31;
            this.LstbxServices.TabStop = false;
            this.LstbxServices.SelectedIndexChanged += new System.EventHandler(this.LstbxServices_SelectedIndexChanged);
            // 
            // BtnRevertAllServices
            // 
            this.BtnRevertAllServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRevertAllServices.FlatAppearance.BorderSize = 0;
            this.BtnRevertAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRevertAllServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevertAllServices.ForeColor = System.Drawing.Color.Yellow;
            this.BtnRevertAllServices.Location = new System.Drawing.Point(362, 254);
            this.BtnRevertAllServices.Name = "BtnRevertAllServices";
            this.BtnRevertAllServices.Size = new System.Drawing.Size(60, 44);
            this.BtnRevertAllServices.TabIndex = 30;
            this.BtnRevertAllServices.TabStop = false;
            this.BtnRevertAllServices.Text = "<<";
            this.BtnRevertAllServices.UseVisualStyleBackColor = true;
            this.BtnRevertAllServices.Click += new System.EventHandler(this.BtnRevertAllServices_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(47, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Event ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(425, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Start date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(201, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Event name";
            // 
            // BtnSendAllServices
            // 
            this.BtnSendAllServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSendAllServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnSendAllServices.FlatAppearance.BorderSize = 0;
            this.BtnSendAllServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSendAllServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendAllServices.ForeColor = System.Drawing.Color.Yellow;
            this.BtnSendAllServices.Location = new System.Drawing.Point(362, 204);
            this.BtnSendAllServices.Name = "BtnSendAllServices";
            this.BtnSendAllServices.Size = new System.Drawing.Size(60, 44);
            this.BtnSendAllServices.TabIndex = 29;
            this.BtnSendAllServices.TabStop = false;
            this.BtnSendAllServices.Text = ">>";
            this.BtnSendAllServices.UseVisualStyleBackColor = true;
            this.BtnSendAllServices.Click += new System.EventHandler(this.BtnSendAllServices_Click);
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Notes.Controls.Add(this.BtnAddNotes);
            this.Notes.Controls.Add(this.panel1);
            this.Notes.Location = new System.Drawing.Point(4, 23);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(854, 442);
            this.Notes.TabIndex = 4;
            this.Notes.Text = "Notes";
            // 
            // BtnAddNotes
            // 
            this.BtnAddNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddNotes.FlatAppearance.BorderSize = 0;
            this.BtnAddNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNotes.ForeColor = System.Drawing.Color.White;
            this.BtnAddNotes.Location = new System.Drawing.Point(744, 392);
            this.BtnAddNotes.Name = "BtnAddNotes";
            this.BtnAddNotes.Size = new System.Drawing.Size(51, 44);
            this.BtnAddNotes.TabIndex = 15;
            this.BtnAddNotes.Text = "+";
            this.BtnAddNotes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 376);
            this.panel1.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, -10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpTabbedControls);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 483);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lstbxSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 483);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.RadWorkers);
            this.panel3.Controls.Add(this.RadSchedule);
            this.panel3.Controls.Add(this.RadVenues);
            this.panel3.Controls.Add(this.RadServices);
            this.panel3.Controls.Add(this.RadEvents);
            this.panel3.Location = new System.Drawing.Point(0, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 46);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // RadWorkers
            // 
            this.RadWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadWorkers.AutoSize = true;
            this.RadWorkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadWorkers.Checked = true;
            this.RadWorkers.Location = new System.Drawing.Point(9, 11);
            this.RadWorkers.Name = "RadWorkers";
            this.RadWorkers.Size = new System.Drawing.Size(65, 17);
            this.RadWorkers.TabIndex = 2;
            this.RadWorkers.TabStop = true;
            this.RadWorkers.Text = "Workers";
            this.RadWorkers.UseVisualStyleBackColor = true;
            this.RadWorkers.CheckedChanged += new System.EventHandler(this.RadWorkers_CheckedChanged);
            // 
            // RadSchedule
            // 
            this.RadSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadSchedule.AutoSize = true;
            this.RadSchedule.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.RadSchedule.Location = new System.Drawing.Point(293, 11);
            this.RadSchedule.Name = "RadSchedule";
            this.RadSchedule.Size = new System.Drawing.Size(70, 17);
            this.RadSchedule.TabIndex = 6;
            this.RadSchedule.Text = "Schedule";
            this.RadSchedule.UseVisualStyleBackColor = true;
            this.RadSchedule.CheckedChanged += new System.EventHandler(this.RadWorkers_CheckedChanged);
            // 
            // RadVenues
            // 
            this.RadVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadVenues.AutoSize = true;
            this.RadVenues.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.RadVenues.Location = new System.Drawing.Point(151, 11);
            this.RadVenues.Name = "RadVenues";
            this.RadVenues.Size = new System.Drawing.Size(61, 17);
            this.RadVenues.TabIndex = 4;
            this.RadVenues.Text = "Venues";
            this.RadVenues.UseVisualStyleBackColor = true;
            this.RadVenues.CheckedChanged += new System.EventHandler(this.RadWorkers_CheckedChanged);
            // 
            // RadServices
            // 
            this.RadServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadServices.AutoSize = true;
            this.RadServices.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.RadServices.Location = new System.Drawing.Point(80, 11);
            this.RadServices.Name = "RadServices";
            this.RadServices.Size = new System.Drawing.Size(66, 17);
            this.RadServices.TabIndex = 3;
            this.RadServices.Text = "Services";
            this.RadServices.UseVisualStyleBackColor = true;
            this.RadServices.CheckedChanged += new System.EventHandler(this.RadWorkers_CheckedChanged);
            // 
            // RadEvents
            // 
            this.RadEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadEvents.AutoSize = true;
            this.RadEvents.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.RadEvents.Location = new System.Drawing.Point(222, 11);
            this.RadEvents.Name = "RadEvents";
            this.RadEvents.Size = new System.Drawing.Size(58, 17);
            this.RadEvents.TabIndex = 5;
            this.RadEvents.Text = "Events";
            this.RadEvents.UseVisualStyleBackColor = true;
            this.RadEvents.CheckedChanged += new System.EventHandler(this.RadWorkers_CheckedChanged);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1202, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DashBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoard_FormClosed);
            this.Load += new System.EventHandler(this.DashBoard_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTabbedControls.ResumeLayout(false);
            this.TabCreateEvent.ResumeLayout(false);
            this.DashBoardTab.ResumeLayout(false);
            this.DashBoardTab.PerformLayout();
            this.AssignWorkersTab.ResumeLayout(false);
            this.AssignWorkersTab.PerformLayout();
            this.MakeServiceTab.ResumeLayout(false);
            this.MakeServiceTab.PerformLayout();
            this.Events.ResumeLayout(false);
            this.Events.PerformLayout();
            this.Notes.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ListBox lstbxSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDisplaySchedule;
        private System.Windows.Forms.Button BtnAvailWorkers;
        private System.Windows.Forms.Button BtnAutoSchedule;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.GroupBox grpTabbedControls;
        private System.Windows.Forms.TabControl TabCreateEvent;
        private System.Windows.Forms.TabPage DashBoardTab;
        private System.Windows.Forms.TabPage MakeServiceTab;
        private System.Windows.Forms.TabPage AssignWorkersTab;
        new private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown DudServiceId;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.Button BtnRevertAllVenues;
        private System.Windows.Forms.Button BtnSendAllVenues;
        private System.Windows.Forms.Button BtnCommitVenues;
        private System.Windows.Forms.Button BtnRollBackServiceVenues;
        private System.Windows.Forms.ListBox LstbxSelectedVenues;
        private System.Windows.Forms.ListBox LstbxAllVenues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LstbxSelectedWorkers;
        private System.Windows.Forms.ListBox LstbxAvailableWorkers;
        private System.Windows.Forms.Button BtnRevertAllWorkers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSendMaxWorkers;
        private System.Windows.Forms.DomainUpDown DudVenueIds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAddNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LstbxSelectedServices;
        private System.Windows.Forms.ListBox LstbxServices;
        private System.Windows.Forms.Button BtnRevertAllServices;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSendAllServices;
        private System.Windows.Forms.Button BtnComitServiceWorkers;
        private System.Windows.Forms.Button btnSaveVenueWorkers;
        private System.Windows.Forms.Button BtnCreateEvent;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.MaskedTextBox TxtEventName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox TxtEventId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnAddToExistingEvent;
        private System.Windows.Forms.CheckBox chkShowAllWorkers;
        private System.Windows.Forms.CheckBox chkShowAllVenues;
        private System.Windows.Forms.Button btnRollbackVenueWorkers;
        private System.Windows.Forms.Button BtnSaveServiceVenues;
        private System.Windows.Forms.Button BtnSaveEvents;
        private System.Windows.Forms.Label LblLoggedInAdmin;
        public System.Windows.Forms.Button BtnLogin;
        public System.Windows.Forms.RadioButton RadSchedule;
        public System.Windows.Forms.RadioButton RadEvents;
        public System.Windows.Forms.RadioButton RadVenues;
        public System.Windows.Forms.RadioButton RadServices;
        public System.Windows.Forms.RadioButton RadWorkers;
    }
}

