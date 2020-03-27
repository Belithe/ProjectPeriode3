using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;


namespace SomerenDAL
{
    public class Participant_DAO : Base
    {

        public List<Participant> getAllParticipants()
        {
            string query = "SELECT * FROM Participants";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Participant> getParticipantByUserId(int id)
        {
            string query = $"SELECT * FROM Participants WHERE UserId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Participant> getParticipantsWithActivity() {
            string query = "SELECT * " +
                            "FROM Participants " +
                            "JOIN Activities ON Participants.ActivityId = Activities.ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return readTableJoined(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Participant> getParticipantsWithActivityByUser(int id) {
            string query = "SELECT * " +
                            "FROM Participants " +
                            "JOIN Activities ON Participants.ActivityId = Activities.ActivityId " +
                            "WHERE UserId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTableJoined(ExecuteSelectQuery(query, sqlParameters));
        }

        public void setNewUserAsParticipant(Participant participant, User newUser) {
            string query = "UPDATE Participants " +
                            "SET UserId = @newUserId " +
                            "WHERE ActivityId = @activityId AND UserId = @oldUserId";
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@activityId", participant.ActivityId);
            sqlParameters[1] = new SqlParameter("@oldUserId", participant.UserId);
            sqlParameters[2] = new SqlParameter("@newUserId", newUser.Number);

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Participant> readTable(DataTable dataTable)
        {
            List<Participant> participants = new List<Participant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participant participant = new Participant()
                {
                    ActivityId = (int)dr["ActivityId"],
                    UserId = (int)dr["UserId"],
                    ParticipancyType = (string)dr["ParticipancyType"]
                };
                participants.Add(participant);
            }

            return participants;
        }

        private List<Participant> readTableJoined(DataTable dataTable) {
            List<Participant> participants = new List<Participant>();

            foreach (DataRow dataRow in dataTable.Rows) {
                participants.Add(new Participant() {
                    ActivityId = (int) dataRow["ActivityId"],
                    UserId = (int) dataRow["UserId"],
                    ParticipancyType = (string) dataRow["ParticipancyType"],
                    ParticipatingActivity = new Activity() {
                        ActivityId = (int) dataRow["ActivityId"],
                        ActivityName = (string) dataRow["ActivityName"],
                        ActivityStartDate = (DateTime) dataRow["StartDateTime"],
                        ActivityEndDate = (DateTime) dataRow["EndDateTime"]
                    }
                });
            }

            return participants;
        }
    }
}
