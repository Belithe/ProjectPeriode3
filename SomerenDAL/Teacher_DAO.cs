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
    public class Professors: Base {
        public List<Teacher> Db_Get_All_Teachers() {
            string query = "SELECT UserId, Name FROM Users WHERE UserType = 'PRF'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> Db_Get_Teacher_By_Id(int id) {
            string query = $"SELECT UserId, Name FROM Users WHERE UserType = 'PRF' AND UserId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable) {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows) {
                Teacher teacher = new Teacher() {
                    Number = (int) dr["UserId"],
                    Name = (string) dr["Name"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
