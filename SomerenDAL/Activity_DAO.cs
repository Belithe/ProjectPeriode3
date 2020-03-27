using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SomerenDAL;
using SomerenModel;


namespace SomerenDAL
{
    public class Activity_DAO : Base
    {
        public List<Activity> getAllActivities()
        {
            string query = "SELECT * FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Activity> getAllActivitiesWithParticipants()
        {
            string query = "SELECT * " +
                            "FROM Activities " +
                            "JOIN Participants ON Activities.ActivityId = Participants.ActivityId " +
                            "JOIN Users ON Participants.UserId = Users.UserId";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return readTableJoined(ExecuteSelectQuery(query, sqlParameters));
        }

        public Activity getActiviyById(int id)
        {
            string query = $"SELECT * FROM Activities WHERE ActivityId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }


        private List<Activity> readTable(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["ActivityId"],
                    ActivityName = (string)dr["ActivityName"],
                    ActivityStartDate = (DateTime)dr["StartDateTime"],
                    ActivityEndDate = (DateTime)dr["EndDateTime"]
                };
                activities.Add(activity);
            }

            return activities;
        }

        private List<Activity> readTableJoined(DataTable dataTable)
        {
            Dictionary<int, Activity> activityMap = new Dictionary<int, Activity>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                int activityId = (int)dataRow["ActivityId"];

                if (!activityMap.ContainsKey(activityId))
                {
                    activityMap[activityId] = new Activity()
                    {
                        ActivityId = (int)dataRow["ActivityId"],
                        ActivityName = (string)dataRow["ActivityName"],
                        ActivityStartDate = (DateTime)dataRow["StartDateTime"],
                        ActivityEndDate = (DateTime)dataRow["EndDateTime"]
                    };
                }

                activityMap[activityId].addParticipant(new Participant()
                {
                    UserId = (int)dataRow["UserId"],
                    ParticipancyType = (string)dataRow["ParticipancyType"],
                    Number = (int)dataRow["UserId"],
                    Name = (string)dataRow["Name"],
                    ParticipatingActivity = activityMap[activityId]
                });
            }

            return activityMap.Values.ToList();
        }
    }
}