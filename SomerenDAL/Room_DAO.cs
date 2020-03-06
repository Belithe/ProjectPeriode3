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
        public List<Room> Db_Get_All_Rooms() {
            string query = "SELECT * FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Room> Db_Get_Room_By_Number(int number) {
            string query = $"SELECT * FROM Rooms WHERE RoomNumber = {number}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Room> Db_Get_Room_By_Type(string roomType) {
            string query = $"SELECT * FROM Rooms WHERE RoomType = {roomType}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable) {
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
    }
}
