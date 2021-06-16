using schedule_app_prototype.GUI;
using schedule_app_prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule_app_prototype.ManageForms
{
    public partial class FrmAvailableWorkers : Form
    {
        public FrmAvailableWorkers()
        {
            InitializeComponent();
        }

        private void FrmAvailableWorkers_Load(object sender, EventArgs e)
        {
            CmbbxWorkers.Items.AddRange(WorkerRepository.GetAllWorkers());
            CmbbxSelectDate.Items.AddRange(EventRepository.GetAll());
        }

        private void BtnSearchServices_Click(object sender, EventArgs e)
        {
            chklstServices.Items.Clear();
            if (ChkDateFilter.Checked && CmbbxSelectDate.SelectedIndex > -1)
            {
                var @event = (Event)CmbbxSelectDate.SelectedItem;
                chklstServices.Items.AddRange( ((Event)@event).GetAllIds() );
                
            }
            else
            {
                chklstServices.Items.AddRange(ServiceRepository.GetAllById());
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Worker worker = (Worker)CmbbxWorkers.SelectedItem;
            foreach (var ServiceId in chklstServices.CheckedItems)
            {
                if (ServiceRepository.Exists(ServiceId.ToString()))
                    worker.MakeAvailable(ServiceRepository.GetService(ServiceId.ToString()).ServiceId);                    
            }
            MessageBox.Show("Done");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
