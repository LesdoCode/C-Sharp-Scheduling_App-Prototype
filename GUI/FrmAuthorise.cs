using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using schedule_app_prototype.DBAccess;
using static schedule_app_prototype.BusinessLogic.Security;

namespace schedule_app_prototype.GUI
{
    public partial class FrmAuthorise : Form
    {
        DashBoard dsh;
        public FrmAuthorise(DashBoard frm)
        {
            InitializeComponent();
            dsh = frm;
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (VerifyLogin(TxtUserName.Text, TxtPassword.Text))
            {
                DashBoard.IsLoggedIn = true;
                DashBoard.LoggedInUser = new WorkerPasswordModel()
                {
                    WorkerId = TxtUserName.Text
                };
                dsh.UpdateLoggegInAdmin();
                Close();
            }
            else
                MessageBox.Show("The username or password provided is incorrect");

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAuthorise_Load(object sender, EventArgs e)
        {

        }
    }
}
