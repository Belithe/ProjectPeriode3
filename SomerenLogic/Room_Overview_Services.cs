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
            Room_DAO roomDao = new Room_DAO();
            User_DAO userDao = new User_DAO();

            List<Room> rooms = roomDao.Db_Get_All_Rooms();

            foreach (Room room in rooms) {
                room.addUsersToRoom(userDao.Db_Get_Users_By_Room_Number(room.Number));
            }

            return rooms;
        }
    }
}
