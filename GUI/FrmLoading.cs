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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }


        private async Task RunAsync()
        {
            LblLoadProgress.Text = "";
            //await Task.Run(() => LoadData());

            foreach (var AR in PrepAppLoad())
            {
                try
                {
                    await Task.Run(() => AR.DBAction());
                    AR.ReportAction();
                }
                catch { }
            }
        }

        private class ActionReportModel
        {
            public Action DBAction { get; set; }
            public Action ReportAction { get; set; }
        }

        
        private List<ActionReportModel> PrepAppLoad()
        {
            //Maps actions to load data from db with reports produced by the ChangeMessage() method in the form of an action to 
            //a private class "ActionReportModel" and puts those into an actionreportmodel list. this is so the foreach loop in the run
            // async can work properly.
            List<ActionReportModel> ActionReportModels = new List<ActionReportModel>();
            List<Action> Reports = new List<Action>();
            List<Action> DBActions = new List<Action>();
            Reports.Add(() => ChangeMessage("Loading workers..."));
            Reports.Add(() => ChangeMessage("Loading Venues..."));
            Reports.Add(() => ChangeMessage("Loading Services..."));
            Reports.Add(() => ChangeMessage("Loading Events..."));
            Reports.Add(() => ChangeMessage("Loading additional DB conext 01..."));
            Reports.Add(() => ChangeMessage("Loading additional DB conext 02..."));
            Reports.Add(() => ChangeMessage("Finalising..."));

            DBActions = ChurchLogic.PrepStartupActions();

            for (int i = 0; i < DBActions.Count; i++)
            {
                ActionReportModels.Add(new ActionReportModel() { DBAction = DBActions[i], ReportAction = Reports[i] });
            }

            return ActionReportModels;

        }

        private void ChangeMessage(string Message)
        {
            //updates the ui according to the Loading progress 
            LblLoadProgress.Text = Message;
            PnlBar.Width += 112;
            PnlReverse.Width -= 30;
        }


        private async void FrmLoading_Load(object sender, EventArgs e)
        {
            //updates the ui according to the Loading progress 
            await RunAsync(); //Loads DB data into the app and updates GUI accordingly.
            ChangeMessage("Opening..."); //updates UI label
            new DashBoard().Show();//opens the dashboard
            Visible = false; // makes loading window dissapeear. Cant close it because its the apps main thread. Closing it closes the entire app
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            //PnlBar.Width += 15;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void PnlBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblLoadProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
