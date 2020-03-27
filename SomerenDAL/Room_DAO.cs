﻿using System;
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

        public List<Room> Db_Get_All_Rooms_With_Users() {
            string query = "SELECT * " +
                            "FROM Rooms " +
                            "JOIN Users ON Rooms.RoomNumber = Users.RoomNumber;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesJoined(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Room> Db_Get_Room_By_Number(int roomNumber) {
            string query = $"SELECT * FROM Rooms WHERE RoomNumber = @roomNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@roomNumber", roomNumber);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Room> Db_Get_Room_By_Type(string roomType) {
            string query = $"SELECT * FROM Rooms WHERE RoomType = @roomType";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@roomType", roomType);

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

        private List<Room> ReadTablesJoined(DataTable dataTable) {
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
