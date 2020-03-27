﻿using System;
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

        public void setNewUserAsParticipant(Participant participant, User newUser) {
            string query = "UPDATE Participants " +
                            "SET UserId = @newUserId " +
                            "WHERE UserId = @oldUserId";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@oldUserId", participant.UserId);
            sqlParameters[1] = new SqlParameter("@newUserId", newUser.Number);

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
    }
}
