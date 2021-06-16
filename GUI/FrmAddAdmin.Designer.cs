namespace schedule_app_prototype.GUI
{
    partial class FrmAddAdmin
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
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.TxtUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdminPass = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdminId = new System.Windows.Forms.MaskedTextBox();
            this.PnlContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlContainer.Controls.Add(this.TxtAdminId);
            this.PnlContainer.Controls.Add(this.label6);
            this.PnlContainer.Controls.Add(this.label5);
            this.PnlContainer.Controls.Add(this.TxtUserId);
            this.PnlContainer.Controls.Add(this.label3);
            this.PnlContainer.Controls.Add(this.label4);
            this.PnlContainer.Controls.Add(this.TxtAdminPass);
            this.PnlContainer.Controls.Add(this.label2);
            this.PnlContainer.Controls.Add(this.label1);
            this.PnlContainer.Controls.Add(this.TxtUserPass);
            this.PnlContainer.Controls.Add(this.groupBox1);
            this.PnlContainer.Location = new System.Drawing.Point(5, 12);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(633, 363);
            this.PnlContainer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRemove);
            this.groupBox1.Controls.Add(this.BtnAddNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAddNew.FlatAppearance.BorderSize = 0;
            this.BtnAddNew.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddNew.Location = new System.Drawing.Point(3, 16);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(117, 46);
            this.BtnAddNew.TabIndex = 4;
            this.BtnAddNew.Text = "Add/Update";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRemove.Location = new System.Drawing.Point(120, 16);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(117, 46);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Remove as admin";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // TxtUserPass
            // 
            this.TxtUserPass.BackColor = System.Drawing.Color.Gray;
            this.TxtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserPass.Location = new System.Drawing.Point(106, 106);
            this.TxtUserPass.MaxLength = 100;
            this.TxtUserPass.Name = "TxtUserPass";
            this.TxtUserPass.Size = new System.Drawing.Size(177, 20);
            this.TxtUserPass.TabIndex = 4;
            this.TxtUserPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Number";
            // 
            // TxtAdminPass
            // 
            this.TxtAdminPass.BackColor = System.Drawing.Color.Gray;
            this.TxtAdminPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdminPass.Location = new System.Drawing.Point(106, 239);
            this.TxtAdminPass.MaxLength = 100;
            this.TxtAdminPass.Name = "TxtAdminPass";
            this.TxtAdminPass.Size = new System.Drawing.Size(177, 20);
            this.TxtAdminPass.TabIndex = 8;
            this.TxtAdminPass.UseSystemPasswordChar = true;
            // 
            // TxtUserId
            // 
            this.TxtUserId.BackColor = System.Drawing.Color.Gray;
            this.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUserId.Location = new System.Drawing.Point(106, 67);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(224, 20);
            this.TxtUserId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Admin";
            // 
            // TxtAdminId
            // 
            this.TxtAdminId.BackColor = System.Drawing.Color.Gray;
            this.TxtAdminId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAdminId.Location = new System.Drawing.Point(106, 201);
            this.TxtAdminId.Name = "TxtAdminId";
            this.TxtAdminId.Size = new System.Drawing.Size(224, 20);
            this.TxtAdminId.TabIndex = 14;
            // 
            // FrmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(636, 373);
            this.Controls.Add(this.PnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddAdmin";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmAddAdmin_Load);
            this.PnlContainer.ResumeLayout(false);
            this.PnlContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserPass;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.MaskedTextBox TxtAdminId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdminPass;
    }
}