using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();

            hideAllPanels();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void hideAllPanels() {
            // hide all other panels
            pnl_Dashboard.Hide();
            img_Dashboard.Hide();
        }

        private void loadView(UserControl pageView) {
            hideAllPanels();

            pageView.AutoScroll = true;

            mainViewport.Controls.Clear();
            mainViewport.Controls.Add(pageView);

            pageView.Show();
        }

        private void showPanel(string panelName)
        {
            hideAllPanels();

            if (panelName == "Dashboard")
            {
                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new StudentsView());
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new RoomsView());
        }

        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsOverviewToolStripMenuItem_Click(object sender, EventArgs e) {
            loadView(new RoomsOverviewView());
        }

        private void KassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new KassaView());
        }

        private void LecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new TeachersView());
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e) {
            loadView(new SalesView());
        }

        private void bTWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new BTWView());
        }

        private void weekRoosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadView(new WeekRoosterView());
        }

        private void teachersSchedulesToolStripMenuItem_Click(object sender, EventArgs e) {
            loadView(new TeachersScheduleView());
        }
    }
}
