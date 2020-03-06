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
            pnl_Rooms.Hide();
            pnl_Students.Hide();
            pnl_RoomsOverview.Hide();
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
            else if (panelName == "Students")
            {
                // show students
                pnl_Students.Show();


                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.Name);
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Rooms")
            {
                pnl_Rooms.Show();

                Room_Service roomService = new Room_Service();
                List<Room> roomList = roomService.GetRooms();

                listViewRooms.Items.Clear();

                foreach(Room room in roomList)
                {
                    string[] entry = new string[3];
                    entry[0] = room.Number.ToString();
                    entry[1] = room.Type;
                    entry[2] = room.Capacity.ToString();
                    ListViewItem item = new ListViewItem(room.Number.ToString());
                    listViewRooms.Items.Add(new ListViewItem(entry));
                }

            }
            else if (panelName == "RoomsOverview")
            {
                // Shows the room overview panel
                pnl_RoomsOverview.Show();

                // Empty the flowlayout
                flowLayoutRoomsOverview.Controls.Clear();

                // Create the service objects
                Room_Overview_Services roomOverviewServices = new Room_Overview_Services();

                // Fetch the rooms from the database
                List<Room> rooms = roomOverviewServices.getRoomsOverview();

                // Foreach room in the database
                foreach (Room room in rooms) {
                    // Create a container for each room
                    GroupBox roomContainer = new GroupBox() {
                        Text = $"Room {room.Number}",
                        MinimumSize = new Size(100, 23),
                        AutoSize = true
                    };
                    roomContainer.Font = new Font(roomContainer.Font, FontStyle.Bold);

                    // Create a listview to hold the users
                    ListView listView = new ListView() {
                        View = View.List,
                        Location = new Point(7, 20),
                        BackColor = SystemColors.Control,
                        BorderStyle = BorderStyle.None,
                        Size = new Size(141, 5)
                    };
                    listView.Font = new Font(listView.Font, FontStyle.Regular);

                    // Adds the users to the list and update the list's height
                    foreach (User user in room.Users) {
                        listView.Items.Add(user.ToString());
                        listView.Size = new Size(listView.Size.Width, listView.Size.Height + 20);
                    }

                    // Add the list to the room container and add the container to the flowLayout
                    roomContainer.Controls.Add(listView);
                    flowLayoutRoomsOverview.Controls.Add(roomContainer);
                }
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
            showPanel("Students");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void listViewRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsOverviewToolStripMenuItem_Click(object sender, EventArgs e) {
            showPanel("RoomsOverview");
        }
    }
}
