using SomerenLogic;
using SomerenModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SomerenUI {
    public partial class RoomsOverviewView:UserControl {
        public RoomsOverviewView() {
            InitializeComponent();
            refreshRoomsOverview();
        }

        public void refreshRoomsOverview() {
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
}
