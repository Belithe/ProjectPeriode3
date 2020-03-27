using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        public List<Student> getAllStudents()
        {
            string query = "SELECT UserId, Name FROM Users WHERE UserType = 'STU'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public Student getStudentById(int id) {
            string query = $"SELECT UserId, Name FROM Users WHERE UserType = 'STU' AND UserId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Student> readTable(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {

                    Number = (int)dr["UserId"],
                    Name = (string) dr["Name"]
                };
                students.Add(student);
            }
            return students;
        }

    }
}
