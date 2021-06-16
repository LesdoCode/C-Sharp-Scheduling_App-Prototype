using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schedule_app_prototype.BusinessLogic;
using schedule_app_prototype.GUI;
using schedule_app_prototype.Models;
using schedule_app_prototype.Repositories;
using schedule_app_prototype.ManageForms;
using schedule_app_prototype.DBAccess;
using static schedule_app_prototype.BusinessLogic.Security;
using System.Threading;

namespace schedule_app_prototype
{
    public partial class DashBoard : Form
    {
        public static bool IsLoggedIn = false;
        internal static WorkerPasswordModel LoggedInUser = null;
       // Worker SelectedWorker;
        Service SelectedService;
        Venue SelectedVenue;
        private static Event SelectedEvent;

        List<Venue> PopulatedVenues = new List<Venue>();
        List<Worker> workers = new List<Worker>();
        List<Service> services = new List<Service>();
        public DashBoard()
        {            
            InitializeComponent();
        }
        
        private void PopulateDudVenues()
        {
            DudVenueIds.Items.Clear();
            DudVenueIds.Items.AddRange(VenueRepository.GetAllById());
        }
        public void RefreshList()
        {
            lstbxSchedule.Items.Clear();
            lstbxSchedule.Items.AddRange(WorkerRepository.GetAllWorkers());
        }
                
        
        private void BtnTest_Click(object sender, EventArgs e)
        {
            lstbxSchedule.Items.Clear();
            lstbxSchedule.Items.AddRange(WorkerRepository.GetAllWorkers().Select(i => i.StillAvailable().ToString()).ToArray());
        }

        private void PopulateAllVenueLstbx()
        {
            LstbxAllVenues.Items.Clear();
            LstbxAllVenues.Items.AddRange(VenueRepository.GetAllVenues().Where(i => i.HasWorkers()).ToArray());
        }
        private void PopulateDudServiceId()
        {
            DudServiceId.Items.Clear();
            DudServiceId.Items.AddRange(ServiceRepository.GetAllById());
        }
        private void PopulateLstbxSchedule()
        {
            lstbxSchedule.Items.Clear();
            lstbxSchedule.Items.AddRange(WorkerRepository.GetAllWorkers());
        }
        private void PopulateLstbxServices()
        {
            LstbxServices.Items.Clear();
            LstbxServices.Items.AddRange(ServiceRepository.GetAllServices());
        }
        public void PopulateUI()
        {
            // used to get data from repositories and populate lists, NUDs, as well as Other data display controls on the UI
            PopulateLstbxSchedule();
            PopulateDudServiceId();
            PopulateDudVenues();                              
            PopulateAvailableWorkers();
            PopulateAllVenueLstbx();
            PopulateLstbxServices();


        }

        public void UpdateLoggegInAdmin()
        {
            string username = LoggedInUser.WorkerId;
            MessageBox.Show("Successfully logged in as " + username + '.');
            LblLoggedInAdmin.Text = "Current admin:\n" + username;
            BtnLogin.Text = "Log out";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ChurchLogic.StartUp();
            PopulateUI();            
        }
        


        private void BtnAutoSchedule_Click(object sender, EventArgs e)
        {

            //lstbxSchedule.Items.AddRange( Schedule.EnumerateSchedule().ToArray() );
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSendAllVenues_Click(object sender, EventArgs e)
        {
            foreach (var item in LstbxAllVenues.Items)
            {
                if (LstbxSelectedVenues.Items.Contains(item))
                    LstbxSelectedVenues.Items.Remove(item);
            }
            LstbxSelectedVenues.Items.AddRange(LstbxAllVenues.Items);
            LstbxAllVenues.Items.Clear();
            
        }

        private void AssignWorkersTab_Click(object sender, EventArgs e)
        {

        }

        private bool HasSelectedIndex(ListBox _Lstbx)
        {
            return _Lstbx.SelectedIndex >= 0;
        }
        private void LstbxAvailableWorkers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (HasSelectedIndex(LstbxAvailableWorkers))
            {
                var worker = (Worker)LstbxAvailableWorkers.SelectedItem;
                if (! LstbxSelectedWorkers.Items.Contains(worker))
                    LstbxSelectedWorkers.Items.Add(worker);
                LstbxAvailableWorkers.Items.Remove(worker);
            }            
        }

        private void LstbxSelectedWorkers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (HasSelectedIndex(LstbxSelectedWorkers))
            {
                var worker = (Worker)LstbxSelectedWorkers.SelectedItem;
                if (!LstbxAvailableWorkers.Items.Contains(worker))
                    LstbxAvailableWorkers.Items.Add(worker);
                LstbxSelectedWorkers.Items.Remove(worker);
            }
        }
        private void BtnSendMaxWorkers_Click(object sender, EventArgs e)
        {
            if (DudVenueIds.SelectedIndex > -1)
            {
                var venue = VenueRepository.GetVenue(DudVenueIds.SelectedItem.ToString());
                if (!venue.IsFull())
                    for (int i = 0; i < venue.GetSpacesLeft(); i++)
                    {
                        if (LstbxAvailableWorkers.Items.Count > i && LstbxSelectedWorkers.Items.Count < venue.GetSpacesLeft())
                        {
                            LstbxSelectedWorkers.Items.Add(LstbxAvailableWorkers.Items[i]);
                            LstbxAvailableWorkers.Items.RemoveAt(i);
                        }
                        else return;
                    }
            }
        }

        private void BtnComitServiceWorkers_Click(object sender, EventArgs e)
        {
            if (DudVenueIds.SelectedIndex > -1 && VenueRepository.Exists( DudVenueIds.SelectedItem.ToString() ))
            {
                var SelectedWorkers = LstbxSelectedWorkers.Items.OfType<Worker>().ToList();

                //if (SelectedWorkers.Count == 0) return;
                
                if (YesNoDialogue("You are about to add the selected workers to the selected venue. Proceed?") == DialogResult.Yes)
                {
                    string venueID = DudVenueIds.SelectedItem.ToString();
                    SelectedVenue = VenueRepository.GetVenue(venueID);

                    if (SelectedWorkers.Count <= SelectedVenue.MaxWorkers)
                    {
                        SelectedVenue.EquateAssignedWorkers(SelectedWorkers);
                        //var venue = VenueRepository.GetVenue(DudVenueIds.SelectedItem.ToString());
                        PopulatedVenues.Add(SelectedVenue);
                        LstbxAllVenues.Items.Add(SelectedVenue);

                        //Then clear listboxes and Domain up down
                        LstbxAvailableWorkers.Items.Clear();
                        LstbxSelectedWorkers.Items.Clear();
                        DudVenueIds.SelectedIndex = -1;

                        MessageBox.Show("Done");
                    }
                    else
                    {
                        int NumberOfExtraPeople = SelectedWorkers.Count - SelectedVenue.GetSpacesLeft();
                        MessageBox.Show("You're assigning more people to this venue than allowed. Please remove " + NumberOfExtraPeople + " people from the list.", "Venue only accepts " + SelectedVenue.MaxWorkers + " workers.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a venue first.");
            }
           
        }

        private DialogResult YesNoDialogue(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
        }

        private void BtnRevertAllWorkers_Click(object sender, EventArgs e)
        {          
            foreach(var item in LstbxSelectedWorkers.Items)
            {
                if (LstbxAvailableWorkers.Items.Contains(item))
                    LstbxAvailableWorkers.Items.Remove(item);
            }
            LstbxAvailableWorkers.Items.AddRange(LstbxSelectedWorkers.Items);
            LstbxSelectedWorkers.Items.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void LstbxAllVenues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasSelectedIndex(LstbxAllVenues))
            {
                var VenueId = ((Venue)LstbxAllVenues.SelectedItem).VenueId;
                if (VenueRepository.Exists(VenueId))
                {
                    Venue venue = VenueRepository.GetVenue(VenueId);
                    if (!LstbxSelectedVenues.Items.Contains(venue))
                        LstbxSelectedVenues.Items.Add(venue);
                    LstbxAllVenues.Items.Remove(venue);
                }
            }
        }

        private void LstbxSelectedVenues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasSelectedIndex(LstbxSelectedVenues))
            {
                var venue = (Venue)LstbxSelectedVenues.SelectedItem;
                if (!LstbxAllVenues.Items.Contains(venue))
                    LstbxAllVenues.Items.Add(venue);
                LstbxSelectedVenues.Items.Remove(venue);
            }
        }

        private void BtnRevertAllVenues_Click(object sender, EventArgs e)
        {
            foreach (var item in LstbxSelectedVenues.Items)
            {
                if (LstbxAllVenues.Items.Contains(item))
                    LstbxAllVenues.Items.Remove(item);
            }
            LstbxAllVenues.Items.AddRange(LstbxSelectedVenues.Items);
            LstbxSelectedVenues.Items.Clear();
        }

        private void BtnCommitVenues_Click(object sender, EventArgs e)
        {
            
            if (DudServiceId.SelectedIndex > -1 && ServiceRepository.Exists(DudServiceId.SelectedItem.ToString()))
            {
                var SelectedVenues = LstbxSelectedVenues.Items;

                if (SelectedVenues.Count == 0) return;

                if (YesNoDialogue("You are about to add the selected workers to the selected venue. Proceed?") == DialogResult.Yes)
                {
                    string serviceID = DudServiceId.SelectedItem.ToString();
                    SelectedService = ServiceRepository.GetService(serviceID);
                    SelectedService.EquateVenues(SelectedVenues.Cast<Venue>().ToList());
                    //foreach (var venue in SelectedVenues)
                    //    SelectedService.AddVenue((Venue)venue);

                    string ServiceId = DudServiceId.SelectedItem.ToString();
                    if (!LstbxServices.Items.Contains(ServiceRepository.GetService(ServiceId))) 
                        LstbxServices.Items.Add(ServiceRepository.GetService(ServiceId));

                    MessageBox.Show("Done");
                }
            }
            else
            { MessageBox.Show("Please select a service first."); }
        }

        private void Events_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplaySchedule_Click(object sender, EventArgs e)
        {
            if (SelectedEvent != null)
            {
                RadSchedule.Checked = true;
                lstbxSchedule.Items.Clear();
                lstbxSchedule.Items.AddRange(Schedule.EnumerateSchedule(SelectedEvent).ToArray());
                MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Please select an event first");
            }

            if (lstbxSchedule.Items.Count == 0)
                lstbxSchedule.Items.Add("There is no schedule to display");

        }

        private void TabCreateEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRefresh_Click(sender, e);
        }

        private void RadWorkers_CheckedChanged(object sender, EventArgs e)
        {
            lstbxSchedule.Items.Clear();
            switch( ((RadioButton)sender).Name)
            {
                case "RadWorkers":
                    lstbxSchedule.Items.AddRange(WorkerRepository.GetAllWorkers());
                    lstbxSchedule.DisplayMember = "Name";
                    break;

                case "RadVenues":
                    lstbxSchedule.Items.AddRange(VenueRepository.GetAllVenues().ToArray());
                    lstbxSchedule.DisplayMember = "VenueId";
                    break;

                case "RadServices":
                    lstbxSchedule.Items.AddRange(ServiceRepository.GetAllServices());
                    lstbxSchedule.DisplayMember = "ServiceId";
                    break;
                case "RadSchedule":
                    //BtnDisplaySchedule_Click(sender, e);
                    break;
                case "RadEvents":
                    lstbxSchedule.DisplayMember = "EventName";
                    lstbxSchedule.Items.AddRange( EventRepository.GetAll() );                    
                    break;
            }
        }

        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            if (TxtEventId.Text == "")
            {
                MessageBox.Show("Please enter an event ID first.");
                return;
            }
            else if (TxtEventName.Text == "")
            {
                MessageBox.Show("Your event should have a name.");
                return;
            }          

            ChurchLogic.AddEvent(TxtEventId.Text, TxtEventName.Text, DtpDate.Value.ToShortDateString(), LstbxSelectedServices.Items.Cast<Service>().ToList());
            RefreshList();
            RadEvents.Checked = true;
            lstbxSchedule.Items.Clear();
            lstbxSchedule.Items.AddRange(EventRepository.GetAll());

            MessageBox.Show("Done");
        }


        private void LstbxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasSelectedIndex(LstbxServices))
            {
                var service = (Service)LstbxServices.SelectedItem;
                if (ServiceRepository.Exists(service.ServiceId))
                {
                    
                    if (!LstbxSelectedServices.Items.Contains(service))
                        LstbxSelectedServices.Items.Add(service);
                    LstbxServices.Items.Remove(service);
                }       
            }
        }

        private void BtnRevertAllServices_Click(object sender, EventArgs e)
        {
            foreach (var item in LstbxSelectedVenues.Items)
            {
                if (LstbxServices.Items.Contains(item))
                    LstbxServices.Items.Remove(item);
            }
            
            LstbxServices.Items.AddRange(LstbxSelectedServices.Items);
            LstbxSelectedServices.Items.Clear();
        }
        private void DudVenueIds_SelectedItemChanged(object sender, EventArgs e)
        {
            if (DudVenueIds.SelectedIndex > -1)
            {
                var venue = VenueRepository.GetVenue(DudVenueIds.SelectedItem.ToString());
                if (chkShowAllWorkers.Checked)
                {
                    PopulateExcept(WorkerRepository.GetAllWorkers().ToList(), LstbxAvailableWorkers, venue.GetAllAssignedWorkers(), LstbxSelectedWorkers);
                }
                else
                {
                    PopulateExcept(WorkerRepository.GetAvailableWorkers().ToList(), LstbxAvailableWorkers, venue.GetAllAssignedWorkers(), LstbxSelectedWorkers);
                }
            }
        }

        private void PopulateExcept<T>(List<T> AllData, ListBox lstbxAll, List<T> SelectedData, ListBox lstbxSelected)
        {
            lstbxAll.Items.Clear();
            lstbxSelected.Items.Clear();

            foreach (var data in AllData)
                lstbxAll.Items.Add(data);

            foreach (var select in SelectedData)
            {
                if (select != null)
                {
                    lstbxSelected.Items.Add(select);
                    lstbxAll.Items.Remove(select);
                }
            }
        }

        private void BtnAvailWorkers_Click(object sender, EventArgs e)
        {
            new FrmAvailableWorkers().ShowDialog();
            PopulateAvailableWorkers();
            //RefreshList();
        }

        private void BtnAddToExistingEvent_Click(object sender, EventArgs e)
        {
            if (LstbxSelectedServices.Items.Count == 0)
            {
                MessageBox.Show("There are no services to add.");
                return;
            }
            if (lstbxSchedule.SelectedIndex > -1 && RadEvents.Checked)
            {
                var SelectedEvent = (Event)lstbxSchedule.SelectedItem;
                var services = LstbxSelectedServices.Items.Cast<Service>().ToList();
                var serviceIds = services.Select(i => i.ServiceId).ToList();
                SelectedEvent.EquateServices(serviceIds);
                //foreach (var service in LstbxSelectedServices.Items)
                //{
                //    SelectedEvent.AddServiceId(((Service)service).ServiceId);
                //}
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Please select an event first.");
            }
        }

        private void lstbxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadEvents.Checked && lstbxSchedule.SelectedIndex >= 0)
            {
                SelectedEvent = (Event)lstbxSchedule.SelectedItem;
                TxtEventId.Text = SelectedEvent.EventId;
                TxtEventName.Text = SelectedEvent.EventName;
                DtpDate.Value = DateTime.Parse(SelectedEvent.StartDate);

                PopulateExcept(ServiceRepository.GetAllServices().ToList(), LstbxServices, SelectedEvent.GetAllAssignedServices(), LstbxSelectedServices);
            }
            
        }

        private void chkShowAllWorkers_CheckedChanged(object sender, EventArgs e)
        {
            PopulateAvailableWorkers();
        }
        private void PopulateAvailableWorkers()
        {
            LstbxAvailableWorkers.Items.Clear();
            if (chkShowAllWorkers.Checked)
            {
                LstbxAvailableWorkers.Items.AddRange(WorkerRepository.GetAllWorkers());
            }
            else
            {
                LstbxAvailableWorkers.Items.AddRange(WorkerRepository.GetAvailableWorkers());
            }
        }

        private void chkShowAllVenues_CheckedChanged(object sender, EventArgs e)
        {
            LstbxAllVenues.Items.Clear();
            if (chkShowAllVenues.Checked)
            {
                LstbxAllVenues.Items.AddRange(VenueRepository.GetAllVenues());
            }
            else
            {
                LstbxAllVenues.Items.AddRange(PopulatedVenues.ToArray());
            }
        }

        private void btnSaveVenueWorkers_Click(object sender, EventArgs e)
        {
            ChurchLogic.SaveVenueWorkers();
            MessageBox.Show("Done");
        }

        private void btnRollbackVenueWorkers_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Unassign all workers from their venues?" ,"Confirm", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                string sql = @"DELETE FROM DBO.venueworkers";
                SqlDataAccess.Execute(sql);
                foreach (var venue in VenueRepository.GetAllVenues())
                {
                    venue.Clear();
                }
            }
        }
        
        private void DudServiceId_SelectedItemChanged(object sender, EventArgs e)
        {
            if (DudServiceId.SelectedIndex > -1)
            {
                var service = ServiceRepository.GetService(DudServiceId.SelectedItem.ToString());
                if (chkShowAllVenues.Checked)
                    PopulateExcept(VenueRepository.GetAllVenues().ToList(), LstbxAllVenues, service.GetPopulatedVenues(), LstbxSelectedVenues);
                else
                {
                    if (DudServiceId.SelectedIndex > -1)
                    {
                        SelectedService = ServiceRepository.GetService(DudServiceId.SelectedItem.ToString());
                        PopulateExcept(VenueRepository.GetAllVenues().ToList(), LstbxAllVenues, SelectedService.ListVenues(), LstbxSelectedVenues);
                    }
                }
            }
        }

        private void LstbxAvailableWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LstbxSelectedWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRollBackServiceVenues_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Unassign all venues from their assigned services?", "Confirm", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                string sql = @"DELETE FROM DBO.servicevenues";
                SqlDataAccess.Execute(sql);
                foreach (var venue in VenueRepository.GetAllVenues())
                {
                    venue.Clear();
                }
            }
        }

        private void BtnSaveServiceVenues_Click(object sender, EventArgs e)
        {
            ChurchLogic.SaveServiceVenues();
            MessageBox.Show("Done");
        }

        private void BtnSaveEvents_Click(object sender, EventArgs e)
        {
            ChurchLogic.SaveEventServices();
            MessageBox.Show("Done");
        }

        private void BtnSendAllServices_Click(object sender, EventArgs e)
        {
            foreach (var item in LstbxServices.Items)
            {
                if (LstbxSelectedServices.Items.Contains(item))
                    LstbxSelectedServices.Items.Remove(item);
            }
            LstbxSelectedServices.Items.AddRange(LstbxServices.Items);
            LstbxServices.Items.Clear();
        }

        private void LstbxSelectedServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasSelectedIndex(LstbxSelectedServices))
            {
                var service = (Service)LstbxSelectedServices.SelectedItem;
                if (ServiceRepository.Exists(service.ServiceId))
                {

                    if (!LstbxServices.Items.Contains(service))
                        LstbxServices.Items.Add(service);
                    LstbxSelectedServices.Items.Remove(service);
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstbxSchedule_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (YesNoDialogue("You're about to delete the selected item. Proceed?") == DialogResult.Yes)
                if (lstbxSchedule.SelectedIndex > -1 && RadEvents.Checked)
                {
                    var @event = (Event)lstbxSchedule.SelectedItem;
                    EventRepository.Delete(@event.EventId);

                    string sql = "DELETE FROM DBO.EVENTS WHERE eventid = @eventid";
                    SqlDataAccess.DeleteData(sql, @event);

                    lstbxSchedule.Items.Remove(@event);

                    MessageBox.Show("Done");
                }
        }
        private void LblLogo_DoubleClick(object sender, EventArgs e)
        {
            new FrmAddAdmin().ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (IsLoggedIn)
            {
                new FrmAdmin(this).Show();
                RefreshList();
            }
            else
            {
                Authorise();
                if (IsLoggedIn)
                {
                    new FrmAdmin(this).Show();
                    RefreshList();
                }
            }
        }
        private void LogOut()
        {
            IsLoggedIn = false;
            LoggedInUser = null;
            LblLoggedInAdmin.Text = "Admin logged out";
            BtnLogin.Text = "Login";
        }
        private void DashBoard_ChangeUICues(object sender, UICuesEventArgs e)
        {
            MessageBox.Show("");
        }
        private void Authorise()
        {
            new FrmAuthorise(this).ShowDialog();
        }
        private void LblLoggedInAdmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Authorise();
        }

        private void LblLoggedInAdmin_Click(object sender, EventArgs e)
        {
            LoginLogout();
        }
        private void LoginLogout()
        {
            if (IsLoggedIn)
            {
                LogOut();
            }
            else
            {
                Authorise();
            }
        }
        private DialogResult CloseMessage()
        {
            return MessageBox.Show("Would you like to atuomatically save your work before closing?", "Save and close", MessageBoxButtons.YesNoCancel);
        }
        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (CloseMessage())
            {
                case DialogResult.Yes:
                    ChurchLogic.SaveAll();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }            
            //Application.Exit();
        }
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    

        //}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginLogout();
        }

        private void DashBoard_Load_1(object sender, EventArgs e)
        {

        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
