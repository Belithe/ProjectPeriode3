﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Participant_Service
    {
        Participant_DAO prt_db = new Participant_DAO();

        public List<Participant> GetParticipants()
        {
            try
            {
                List<Participant> participants = prt_db.Db_Get_All_Participants();
                return participants;
            }
            catch
            {
                List<Participant> prtl = new List<Participant>();
                Participant a = new Participant();
                a.UserId = 1;
                a.ParticipancyType = "PRT";
                a.ActivityId = 1;
                prtl.Add(a);
                return prtl;
                throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
