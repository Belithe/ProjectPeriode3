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

        public List<Teacher> getTeachers()
        {
            List<Teacher> teachers = teacher_db.getAllTeachers();
            return teachers;
        }

        public bool isAvailableBetween(Teacher teacher, DateTime startDateTime, DateTime endDateTime) { // a2
            Participant_Service participant_Service = new Participant_Service();
            Activity_Service activity_Service = new Activity_Service();

            List<Participant> participants = participant_Service.getParticipansByUser(teacher);

            foreach (Participant participant in participants) {
                Activity activity = activity_Service.getActivityById(participant.ActivityId); // a1

                if (!(endDateTime < activity.ActivityStartDate || startDateTime > activity.ActivityEndDate)) {
                    return false;
                }
            }

            return true;
        }
    }
}
