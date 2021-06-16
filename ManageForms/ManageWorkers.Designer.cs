namespace schedule_app_prototype.ManageForms
{
    partial class ManageWorkers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAddWorker = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeleteWorker = new System.Windows.Forms.Button();
            this.BtnUpdateWorker = new System.Windows.Forms.Button();
            this.TabctrlManager = new System.Windows.Forms.TabControl();
            this.Workers = new System.Windows.Forms.TabPage();
            this.Services = new System.Windows.Forms.TabPage();
            this.Checklists = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lstWorkers = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.TabctrlManager.SuspendLayout();
            this.Workers.SuspendLayout();
            this.Services.SuspendLayout();
            this.Checklists.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddWorker
            // 
            this.BtnAddWorker.FlatAppearance.BorderSize = 0;
            this.BtnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddWorker.Location = new System.Drawing.Point(6, 11);
            this.BtnAddWorker.Name = "BtnAddWorker";
            this.BtnAddWorker.Size = new System.Drawing.Size(79, 34);
            this.BtnAddWorker.TabIndex = 0;
            this.BtnAddWorker.Text = "Add";
            this.BtnAddWorker.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeleteWorker);
            this.groupBox1.Controls.Add(this.BtnUpdateWorker);
            this.groupBox1.Controls.Add(this.BtnAddWorker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnDeleteWorker
            // 
            this.BtnDeleteWorker.FlatAppearance.BorderSize = 0;
            this.BtnDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteWorker.Location = new System.Drawing.Point(176, 11);
            this.BtnDeleteWorker.Name = "BtnDeleteWorker";
            this.BtnDeleteWorker.Size = new System.Drawing.Size(79, 34);
            this.BtnDeleteWorker.TabIndex = 2;
            this.BtnDeleteWorker.Text = "Delete";
            this.BtnDeleteWorker.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateWorker
            // 
            this.BtnUpdateWorker.FlatAppearance.BorderSize = 0;
            this.BtnUpdateWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateWorker.Location = new System.Drawing.Point(91, 11);
            this.BtnUpdateWorker.Name = "BtnUpdateWorker";
            this.BtnUpdateWorker.Size = new System.Drawing.Size(79, 34);
            this.BtnUpdateWorker.TabIndex = 1;
            this.BtnUpdateWorker.Text = "Update";
            this.BtnUpdateWorker.UseVisualStyleBackColor = true;
            // 
            // TabctrlManager
            // 
            this.TabctrlManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabctrlManager.Controls.Add(this.Workers);
            this.TabctrlManager.Controls.Add(this.Services);
            this.TabctrlManager.Controls.Add(this.Checklists);
            this.TabctrlManager.HotTrack = true;
            this.TabctrlManager.Location = new System.Drawing.Point(2, 35);
            this.TabctrlManager.Multiline = true;
            this.TabctrlManager.Name = "TabctrlManager";
            this.TabctrlManager.SelectedIndex = 0;
            this.TabctrlManager.Size = new System.Drawing.Size(931, 527);
            this.TabctrlManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabctrlManager.TabIndex = 3;
            // 
            // Workers
            // 
            this.Workers.BackColor = System.Drawing.Color.DimGray;
            this.Workers.Controls.Add(this.groupBox1);
            this.Workers.Controls.Add(this.lstWorkers);
            this.Workers.Controls.Add(this.groupBox4);
            this.Workers.Controls.Add(this.label4);
            this.Workers.Controls.Add(this.textBox4);
            this.Workers.Location = new System.Drawing.Point(4, 22);
            this.Workers.Name = "Workers";
            this.Workers.Padding = new System.Windows.Forms.Padding(3);
            this.Workers.Size = new System.Drawing.Size(923, 501);
            this.Workers.TabIndex = 1;
            this.Workers.Text = "Workers";
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.DimGray;
            this.Services.Controls.Add(this.groupBox2);
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(703, 507);
            this.Services.TabIndex = 3;
            this.Services.Text = "Services";
            // 
            // Checklists
            // 
            this.Checklists.BackColor = System.Drawing.Color.Gray;
            this.Checklists.Controls.Add(this.groupBox3);
            this.Checklists.Location = new System.Drawing.Point(4, 22);
            this.Checklists.Name = "Checklists";
            this.Checklists.Size = new System.Drawing.Size(703, 507);
            this.Checklists.TabIndex = 4;
            this.Checklists.Text = "CheckList";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(896, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 29);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(176, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(176, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(91, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 34);
            this.button5.TabIndex = 1;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 34);
            this.button6.TabIndex = 0;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lstWorkers
            // 
            this.lstWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWorkers.BackColor = System.Drawing.Color.DimGray;
            this.lstWorkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstWorkers.FormattingEnabled = true;
            this.lstWorkers.Location = new System.Drawing.Point(3, 7);
            this.lstWorkers.Name = "lstWorkers";
            this.lstWorkers.Size = new System.Drawing.Size(564, 444);
            this.lstWorkers.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(19, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Kolooi koloi ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Worker Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(19, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Kolooi koloi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Worker Id";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(19, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Kolooi koloi ";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(665, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search by Id";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(244, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 36);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(132, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 36);
            this.button8.TabIndex = 4;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(14, 373);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 36);
            this.button9.TabIndex = 3;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(559, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 423);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // ManageWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TabctrlManager);
            this.MinimumSize = new System.Drawing.Size(594, 405);
            this.Name = "ManageWorkers";
            this.Size = new System.Drawing.Size(932, 560);
            this.groupBox1.ResumeLayout(false);
            this.TabctrlManager.ResumeLayout(false);
            this.Workers.ResumeLayout(false);
            this.Workers.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Checklists.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDeleteWorker;
        private System.Windows.Forms.Button BtnUpdateWorker;
        private System.Windows.Forms.TabControl TabctrlManager;
        private System.Windows.Forms.TabPage Workers;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage Checklists;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lstWorkers;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
