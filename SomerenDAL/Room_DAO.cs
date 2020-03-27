using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL {
    public class Room_DAO: Base {
        public List<Room> getAllRooms() {
            string query = "SELECT * FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Room> getAllRoomsWithUsers() {
            string query = "SELECT * " +
                            "FROM Rooms " +
                            "JOIN Users ON Rooms.RoomNumber = Users.RoomNumber;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTableJoined(ExecuteSelectQuery(query, sqlParameters));
        }

        public Room getRoomByNumber(int roomNumber) {
            string query = $"SELECT * FROM Rooms WHERE RoomNumber = @roomNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@roomNumber", roomNumber);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Room> getRoomsByType(string roomType) {
            string query = $"SELECT * FROM Rooms WHERE RoomType = @roomType";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@roomType", roomType);

            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> readTable(DataTable dataTable) {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows) {
                Room room = new Room() {
                    Number = (int) dr["RoomNumber"],
                    Capacity = (int) dr["Capacity"],
                    Type = (string) dr["RoomType"]
                };
                rooms.Add(room);
            }

            return rooms;
        }

        private List<Room> readTableJoined(DataTable dataTable) {
            Dictionary<int, Room> roomsMap = new Dictionary<int, Room>();

            foreach (DataRow dataRow in dataTable.Rows) {
                int roomNumber = (int) dataRow["RoomNumber"];

                if (!roomsMap.ContainsKey(roomNumber)) {
                    roomsMap[roomNumber] = new Room() {
                        Number = (int) dataRow["RoomNumber"],
                        Capacity = (int) dataRow["Capacity"],
                        Type = (string) dataRow["RoomType"]
                    };
                }

                roomsMap[roomNumber].addUserToRoom(new User() {
                    Number = (int) dataRow["UserId"],
                    Name = (string) dataRow["Name"]
                });
            }

            return roomsMap.Values.ToList();
        }
    }
}
