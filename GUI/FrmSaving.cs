using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule_app_prototype.GUI
{
    public partial class FrmSaving : Form
    {
        public FrmSaving()
        {
            InitializeComponent();
        }

        private async void FrmSaving_Load(object sender, EventArgs e)
        {
            await Task.Run(() => SaveAllAsync());
            Close();
        }

        private async Task SaveAllAsync()
        {
            LblProgress.Text = "Saving events...";
            await Task.Run(() => ChurchLogic.SaveEventServices());
            LblProgress.Text = "Saving workers...";
            await Task.Run(() => ChurchLogic.SaveVenueWorkers());
            LblProgress.Text = "Saving venues...";
            await Task.Run(() => ChurchLogic.SaveServiceVenues());
            LblProgress.Text = "Done";
        }
    }
}
