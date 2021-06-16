namespace schedule_app_prototype.ManageForms
{
    partial class FrmAvailableWorkers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnSearchServices = new System.Windows.Forms.Button();
            this.ChkDateFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbbxSelectDate = new System.Windows.Forms.ComboBox();
            this.chklstServices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbbxWorkers = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 512);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.BtnSubmit);
            this.panel2.Controls.Add(this.BtnSearchServices);
            this.panel2.Controls.Add(this.ChkDateFilter);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CmbbxSelectDate);
            this.panel2.Controls.Add(this.chklstServices);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CmbbxWorkers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 512);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSubmit.Location = new System.Drawing.Point(6, 466);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(445, 32);
            this.BtnSubmit.TabIndex = 21;
            this.BtnSubmit.TabStop = false;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnSearchServices
            // 
            this.BtnSearchServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchServices.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.BtnSearchServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSearchServices.Location = new System.Drawing.Point(14, 133);
            this.BtnSearchServices.Name = "BtnSearchServices";
            this.BtnSearchServices.Size = new System.Drawing.Size(106, 32);
            this.BtnSearchServices.TabIndex = 5;
            this.BtnSearchServices.TabStop = false;
            this.BtnSearchServices.Text = "Search";
            this.BtnSearchServices.UseVisualStyleBackColor = true;
            this.BtnSearchServices.Click += new System.EventHandler(this.BtnSearchServices_Click);
            // 
            // ChkDateFilter
            // 
            this.ChkDateFilter.AutoSize = true;
            this.ChkDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkDateFilter.Location = new System.Drawing.Point(228, 94);
            this.ChkDateFilter.Name = "ChkDateFilter";
            this.ChkDateFilter.Size = new System.Drawing.Size(95, 17);
            this.ChkDateFilter.TabIndex = 20;
            this.ChkDateFilter.Text = "Apply date filter";
            this.ChkDateFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select date";
            // 
            // CmbbxSelectDate
            // 
            this.CmbbxSelectDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CmbbxSelectDate.DisplayMember = "StartDate";
            this.CmbbxSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbbxSelectDate.FormattingEnabled = true;
            this.CmbbxSelectDate.Location = new System.Drawing.Point(14, 92);
            this.CmbbxSelectDate.Name = "CmbbxSelectDate";
            this.CmbbxSelectDate.Size = new System.Drawing.Size(199, 21);
            this.CmbbxSelectDate.TabIndex = 18;
            // 
            // chklstServices
            // 
            this.chklstServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.chklstServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklstServices.FormattingEnabled = true;
            this.chklstServices.Location = new System.Drawing.Point(3, 183);
            this.chklstServices.Name = "chklstServices";
            this.chklstServices.Size = new System.Drawing.Size(462, 272);
            this.chklstServices.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select worker";
            // 
            // CmbbxWorkers
            // 
            this.CmbbxWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CmbbxWorkers.DisplayMember = "Name";
            this.CmbbxWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbbxWorkers.FormattingEnabled = true;
            this.CmbbxWorkers.Location = new System.Drawing.Point(14, 39);
            this.CmbbxWorkers.Name = "CmbbxWorkers";
            this.CmbbxWorkers.Size = new System.Drawing.Size(199, 21);
            this.CmbbxWorkers.TabIndex = 0;
            // 
            // FrmAvailableWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(469, 514);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAvailableWorkers";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avail Workers";
            this.Load += new System.EventHandler(this.FrmAvailableWorkers_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chklstServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbbxWorkers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbbxSelectDate;
        private System.Windows.Forms.CheckBox ChkDateFilter;
        private System.Windows.Forms.Button BtnSearchServices;
        private System.Windows.Forms.Button BtnSubmit;
    }
}