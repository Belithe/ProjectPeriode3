using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI {
    public partial class RoomsView:UserControl {
        public RoomsView() {
            InitializeComponent();
            refreshRooms();
        }

        public void refreshRooms() {
            Room_Service roomService = new Room_Service();
            List<Room> roomList = roomService.GetRooms();

            listViewRooms.Items.Clear();

            foreach (Room room in roomList) {
                string[] entry = new string[3];
                entry[0] = room.Number.ToString();
                entry[1] = room.Type;
                entry[2] = room.Capacity.ToString();

                listViewRooms.Items.Add(new ListViewItem(entry));
            }
        }
    }
}
