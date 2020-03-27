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
    public class User_DAO: Base {
        public List<User> getUsersByRoomNumber(int roomNumber) {
            string query = $"SELECT UserId, Name FROM Users WHERE RoomNumber = @roomNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@roomNumber", roomNumber);

            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<User> readTable(DataTable dataTable) {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows) {
                Teacher teacher = new Teacher() {
                    Number = (int) dr["UserId"],
                    Name = (string) dr["Name"]
                };
                users.Add(teacher);
            }
            return users;
        }
    }
}
