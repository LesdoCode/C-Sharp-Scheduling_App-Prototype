using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schedule_app_prototype.GUI;
using schedule_app_prototype.DBAccess;
using static schedule_app_prototype.GUI.FrmAuthorise;
using static schedule_app_prototype.BusinessLogic.Security;

namespace schedule_app_prototype.GUI

{
    public partial class FrmAddAdmin : Form
    {
        public FrmAddAdmin()
        {
            InitializeComponent();
        }

        private void FrmAddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddOrUpdateAdmin(TxtUserId.Text, TxtUserPass.Text, TxtAdminId.Text, TxtAdminPass.Text);
            }
            catch(InvalidOperationException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
