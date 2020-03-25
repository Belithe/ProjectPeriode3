using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Teacher_Services
    {
        Professors teacher_db = new Professors();

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacher_db.Db_Get_All_Teachers();
            return teachers;
        }
    }
}
