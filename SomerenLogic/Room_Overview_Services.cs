using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic {
    public class Room_Overview_Services {
        public List<Room> getRoomsOverview() {
            Room_DAO room_DAO = new Room_DAO();

            return room_DAO.Db_Get_All_Rooms_With_Users();
        }
    }
}
