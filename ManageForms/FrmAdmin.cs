using schedule_app_prototype.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule_app_prototype.BusinessLogic
{
    public partial class FrmAdmin : Form
    {
        MaskedTextBox[] VenueTxt;
        MaskedTextBox[]WorkerTxt;
        DashBoard dsh;
        public FrmAdmin(DashBoard dashBoard)
        {
            InitializeComponent();
            dsh = dashBoard;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        #region Worker stuffs
        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            foreach (var txt in WorkerTxt)
            {
                if (RemoveAllSpaces( txt.Text ) == "")
                {
                    MessageBox.Show("Sorry, all fields should have values. Please enter the required particulars and try again");
                    return;
                }
            }
            if (!WorkerRepository.Exsists(TxtWorkerId.Text))
            {
                ChurchLogic.AddWorker(TxtWorkerId.Text, TxtWorkerName.Text, (int)NudWorkerVenueRating.Value
                                        , TxtWorkerSurname.Text, TxtAddress.Text, TxtCellNumber.Text, (int)NudAge.Value, TxtEmail.Text); 
                RefreshListBoxes();
                ClearWorkerInputs();
                CompletionMessage();
            }
            else
            {
                CompletionMessage("Sorry, a person with the same ID already exists, please use another ID");
                TxtWorkerId.Clear();
            }

            RefreshListBoxes();
            dsh.RadWorkers.Checked = true;
            dsh.RefreshList();
            
        }


        private void BtnUpdateWorker_Click(object sender, EventArgs e)
        {
            if (GetWorkerId() == "")
            {
                MessageBox.Show("Please select a worker first");
                return;
            } 
            DialogResult dlg = MessageBox.Show("You are about to update the selected worker's details. Are you sure you want to proceed?", "Update info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.UpdateWorker(GetWorkerId(), TxtWorkerId.Text, TxtWorkerName.Text, 
                    (int)NudWorkerVenueRating.Value, TxtWorkerSurname.Text, TxtAddress.Text, 
                    TxtCellNumber.Text, TxtEmail.Text, (int)NudAge.Value);

                CompletionMessage();
            }
            RefreshListBoxes();
            ClearWorkerInputs();
            dsh.RadWorkers.Checked = true;
            dsh.RefreshList();
        }

        private void BtnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (GetWorkerId() == "")
            {
                MessageBox.Show("Please select a worker first");
                return;
            }
            DialogResult dlg = MessageBox.Show("You are about to delete the selected worker's details. Are you sure you want to proceed?", "Delete info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.DeleteWorker(GetWorkerId());
                CompletionMessage();
            }
            ClearWorkerInputs();
            RefreshListBoxes();
        }

        private void BtnRefreshWorkers_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }


        private void LstbxWorkers_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (((ListBox)sender).Items.Count > 0 && ((ListBox)sender).SelectedIndex > -1)
                {
                    var worker = ((Worker)LstbxWorkers.SelectedItem);
                    TxtWorkerId.Text = worker.WorkerId;
                    TxtWorkerName.Text = worker.Name;
                    NudWorkerVenueRating.Value = worker.VenueRating;
                    TxtWorkerSurname.Text = worker.Surname;
                    TxtAddress.Text = worker.Address;
                    TxtCellNumber.Text = worker.CellNumber;
                    TxtEmail.Text = worker.Email;
                    NudAge.Value = worker.Age;
                }                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region general stuffs
        private void CompletionMessage(string message = "Done!")
        {
            MessageBox.Show(message, "Complete");
        }
        private void RefreshListBoxes()
        {
            LstbxWorkers.Items.Clear();
            LstbxWorkers.Items.AddRange(WorkerRepository.GetAllWorkers());

            LstbxVenues.Items.Clear();
            LstbxVenues.Items.AddRange(VenueRepository.GetAllVenues());

            LstbxServices.Items.Clear();
            LstbxServices.Items.AddRange(ServiceRepository.GetAllServices());
        }
        private string GetWorkerId()
        {
            try
            {
                return ((Worker)LstbxWorkers.SelectedItem).WorkerId;
            }
            catch { return ""; }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearWorkerInputs();
        }
        private void ClearWorkerInputs()
        {
            foreach (var txt in WorkerTxt)
            {
                txt.Clear();
            }
            NudWorkerVenueRating.Value = 0;
        }

        private void TxtSearchWorkers_TextChanged(object sender, EventArgs e)
        {
            LstbxWorkers.Items.Clear();
            var FilteredWorkers = WorkerRepository.GetAllWorkers().Where(i => i.WorkerId.StartsWith( txtSearchWorkers.Text));
            LstbxWorkers.Items.AddRange(FilteredWorkers.ToArray());
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            RefreshListBoxes();
            WorkerTxt = new MaskedTextBox[] { TxtWorkerId, TxtWorkerName };
            VenueTxt = new MaskedTextBox[] { TxtVenueId };
        }

        #endregion

        public string GetVenueId()
        {
            try
            {
                return ((Venue)LstbxVenues.SelectedItem).VenueId;
            }
            catch { return ""; }
        }

        private void BtnAddVenue_Click(object sender, EventArgs e)
        {
            if (TxtVenueId.Text == "")
            {
                CompletionMessage("Please Give your venue a unique ID.");
                return;
            }
            else if(TxtVenueName.Text == "" || TxtVenueAddress.Text == "")
            {
                CompletionMessage("All fields must have a value");
            }
            try
            {
                ChurchLogic.AddVenue(TxtVenueId.Text, TxtVenueName.Text, TxtVenueAddress.Text, (int)NudVenueRating.Value, (int)NudMaxWorkers.Value);
                ClearVenueInputs();
                RefreshListBoxes();
            }
            catch(ArgumentException ArgEx)
            {
                CompletionMessage(ArgEx.Message);
            }
            
        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            
            DialogResult dlg = MessageBox.Show("You are about to update the selected venue's details. Are you sure you want to proceed?", "Update info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    ChurchLogic.UpdateVenue(GetVenueId(), TxtVenueId.Text, TxtVenueName.Text, TxtVenueAddress.Text, (int)NudMaxWorkers.Value, (int)NudVenueRating.Value);
                    CompletionMessage();
                }
                catch (ArgumentException ArgEx)
                {
                    CompletionMessage(ArgEx.Message);
                }
                
            }
            RefreshListBoxes();
            ClearVenueInputs();
        }

        private void BtnRefreshVenues_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void TxtSearchVenue_TextChanged(object sender, EventArgs e)
        {
            LstbxVenues.Items.Clear();
            var FilteredVenues = VenueRepository.GetAllVenues().Where(i => i.VenueId.StartsWith(TxtSearchVenue.Text));
            LstbxVenues.Items.AddRange(FilteredVenues.ToArray());
        }

        private void BtnDeleteVenue_Click(object sender, EventArgs e)
        {
            if (GetVenueId() == "")
            {
                MessageBox.Show("Please select a venue first");
                return;
            }
            DialogResult dlg = MessageBox.Show("You are about to delete the selected venue's details. Are you sure you want to proceed?", "Delete info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.DeleteVenue(GetVenueId());
                CompletionMessage();
                ClearVenueInputs();
                RefreshListBoxes();
            }
            
        }

        private void BtnClearVenue_Click(object sender, EventArgs e)
        {
            foreach(var txt in VenueTxt)
            {
                txt.Clear();
            }
            NudVenueRating.Value = 0;
            NudMaxWorkers.Value = 1;
        }

        
        private void LstbxVenues_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var venue = ((Venue)LstbxVenues.SelectedItem);
                TxtVenueId.Text = venue.VenueId;
                NudMaxWorkers.Value = venue.MaxWorkers;
                NudVenueRating.Value = venue.VenueRating;
                TxtVenueName.Text = venue.VenueName;
                TxtVenueAddress.Text = venue.VenueAddress;
            }
            catch { }
        }

        private void ClearVenueInputs()
        {
            foreach (var txt in VenueTxt)
            {
                txt.Clear();
            }
        }

        private void LstbxServices_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var service = ((Service)LstbxServices.SelectedItem);
                TxtServiceId.Text = service.ServiceId;
                TxtServiceStartTime.Text = service.StartTime;
                TxtServiceDuration.Text = service.Duration;
                TxtServiceName.Text = service.ServiceName;
                
            }
            catch { }
        }
        private void ClearServiceInputs()
        {
            TxtServiceId.Clear();
            TxtServiceStartTime.Clear();
            TxtServiceDuration.Clear();
            TxtServiceName.Clear();
        }
        private void BtnAddService_Click(object sender, EventArgs e)
        {
            if (TxtServiceId.Text == "")
            {
                CompletionMessage("Sorry, Your Service must have an ID. Please Give your Service an ID.");
                return;
            }
            try
            {
                ChurchLogic.AddService(TxtServiceId.Text, TxtServiceName.Text, TxtServiceStartTime.Text,TxtServiceDuration.Text);
                ClearServiceInputs();
                RefreshListBoxes();
            }
            catch (ArgumentException ArgEx)
            {
                CompletionMessage(ArgEx.Message);
            }
        }
        private string GetServiceId()
        {
            try
            {
                return ((Service)LstbxServices.SelectedItem).ServiceId;
            }
            catch { return ""; }
        }
        private void BtnUpdateService_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("You are about to update the selected service's details. Are you sure you want to proceed?", "Update info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    ChurchLogic.UpdateService(GetServiceId(), TxtServiceId.Text, TxtServiceName.Text, TxtServiceStartTime.Text, TxtServiceDuration.Text);
                    CompletionMessage();
                }
                catch (ArgumentException ArgEx)
                {
                    CompletionMessage(ArgEx.Message);
                }
            }
            RefreshListBoxes();
            ClearServiceInputs();
        }

        private void BtnDeleteService_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("You are about to delete the selected services details. Are you sure you want to proceed?", "Delete info", MessageBoxButtons.YesNoCancel);
            if (dlg == DialogResult.Yes)
            {
                var ServiceId = GetServiceId();
                if (ServiceId == "")
                {
                    MessageBox.Show("Nothing was selected");
                    return;
                }
                    
                ChurchLogic.DeleteService(ServiceId);
                CompletionMessage();
            }
            ClearServiceInputs();
            RefreshListBoxes();
        }

        private void BtnClearService_Click(object sender, EventArgs e)
        {
            ClearServiceInputs();
        }

        private void BtnRefreshService_Click(object sender, EventArgs e)
        {
            RefreshListBoxes();
        }

        private void TxtSearchServices_TextChanged(object sender, EventArgs e)
        {
            LstbxServices.Items.Clear();
            var FilteredServices = ServiceRepository.GetAllServices().Where(i => i.ServiceId.StartsWith(TxtSearchServices.Text));
            LstbxServices.Items.AddRange(FilteredServices.ToArray());
        }

        private void TxtEmailAddress_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private DialogResult WarningMessage(string item)
        {
            return MessageBox.Show("Are you sure you want to delete all " + item + "s? This action cannot be reversed.", "Delete all " + item + "s", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        private void BtnDeleteAllWorkers_Click(object sender, EventArgs e)
        {
            var dlg = WarningMessage("worker");
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.DeleteAllWorkers();
                RefreshListBoxes();
            }
                
        }

        private void DeleteAllVenues_Click(object sender, EventArgs e)
        {
            var dlg = WarningMessage("venue");
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.DeleteAllVenues();
                RefreshListBoxes();
            }
        }

        private void DeleteAllServices_Click(object sender, EventArgs e)
        {
            var dlg = WarningMessage("serviec");
            if (dlg == DialogResult.Yes)
            {
                ChurchLogic.DeleteAllServices();
                RefreshListBoxes();
            }
        }

        private void TxtWorkerId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private string RemoveAllSpaces(string text)
        {
            string NewString = "";
            foreach(char c in text)
            {
                if (c != ' ')
                    NewString += c;
            }
            return NewString;
        }
        private void TxtWorkerId_TextChanged(object sender, EventArgs e)
        {
            string Text = RemoveAllSpaces(((MaskedTextBox)sender).Text);
            
            if (Text.Length == 13)
            {
                dynamic year = Text.Substring(0, 2);
                int day = int.Parse(Text.Substring(4, 2));
                int month = int.Parse(Text.Substring(2, 2));


                if (int.Parse(year) < 50)
                    year = "20" + year;
                else
                    year = "19" + year;

                year = int.Parse(year);

                if (day > 31 || day < 1)
                    day = 01;
                if (month > 12 || month < 0)
                    month = 1;

                DateTime DOB = default, 
                Today = DateTime.Today;
                
                try
                {
                    DOB = new DateTime(year, month, day);
                }
                catch
                {
                    MessageBox.Show("Invalid ID number, please check the date of birth");
                    DOB = new DateTime(2000, 1 ,1);
                }
                finally
                {
                    dynamic age = (Today - DOB).TotalDays.ToString();
                    age = double.Parse(age);
                    age /= 365;
                    age = Math.Round(age, 0);
                    NudAge.Value = (decimal)age;
                }
                

                
            }
        }


    }
}
