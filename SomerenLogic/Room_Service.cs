using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic {
    public class Room_Service {
        Room_DAO room_db = new Room_DAO();

        public List<Room> GetRooms() {
            try
            {
                List<Room> room = room_db.Db_Get_All_Rooms();
                return room;
            } catch
            {
                List<Room> room = new List<Room>();
                Room a = new Room();
                a.Number = 1;
                a.Type = "STU";
                a.Capacity = 8;
                room.Add(a);                
                return room;
                throw new Exception("Someren couldn't connect to the database");
            }

        }

    }
}
