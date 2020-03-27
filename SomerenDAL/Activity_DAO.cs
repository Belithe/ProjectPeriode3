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
    }
}
