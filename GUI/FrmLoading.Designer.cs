namespace schedule_app_prototype.GUI
{
    partial class FrmLoading
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
            this.PnlBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblLoadProgress = new System.Windows.Forms.Label();
            this.PnlReverse = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.PnlBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 24);
            this.panel1.TabIndex = 0;
            // 
            // PnlBar
            // 
            this.PnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PnlBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBar.Location = new System.Drawing.Point(0, 0);
            this.PnlBar.Name = "PnlBar";
            this.PnlBar.Size = new System.Drawing.Size(91, 24);
            this.PnlBar.TabIndex = 0;
            this.PnlBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBar_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel2.BackgroundImage = global::schedule_app_prototype.Properties.Resources.Let_s_mix_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.LblLoadProgress);
            this.panel2.Location = new System.Drawing.Point(3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 430);
            this.panel2.TabIndex = 1;
            // 
            // LblLoadProgress
            // 
            this.LblLoadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblLoadProgress.BackColor = System.Drawing.Color.Transparent;
            this.LblLoadProgress.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoadProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblLoadProgress.Location = new System.Drawing.Point(3, 403);
            this.LblLoadProgress.Name = "LblLoadProgress";
            this.LblLoadProgress.Size = new System.Drawing.Size(781, 23);
            this.LblLoadProgress.TabIndex = 0;
            this.LblLoadProgress.Text = "Loading...";
            this.LblLoadProgress.Click += new System.EventHandler(this.LblLoadProgress_Click);
            // 
            // PnlReverse
            // 
            this.PnlReverse.Location = new System.Drawing.Point(0, -1);
            this.PnlReverse.Name = "PnlReverse";
            this.PnlReverse.Size = new System.Drawing.Size(694, 23);
            this.PnlReverse.TabIndex = 0;
            this.PnlReverse.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(846, 441);
            this.Controls.Add(this.PnlReverse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoading";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlReverse;
        private System.Windows.Forms.Label LblLoadProgress;
    }
}