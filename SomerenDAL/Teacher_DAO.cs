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
        public List<Teacher> getAllTeachers() {
            string query = "SELECT UserId, Name FROM Users WHERE UserType = 'PRF'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public Teacher getTeacherById(int id) {
            string query = $"SELECT UserId, Name FROM Users WHERE UserType = 'PRF' AND UserId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Teacher> readTable(DataTable dataTable) {
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
