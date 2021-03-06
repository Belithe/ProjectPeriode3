﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Activity_Service
    {
        Activity_DAO activitydb = new Activity_DAO();

        public List<Activity> getActivities()
        {
            try
            {
                List<Activity> activities = activitydb.getAllActivities();
                return activities;
            }
            catch
            {
                List<Activity> act = new List<Activity>();
                Activity a = new Activity();
                a.ActivityId = 1;
                a.ActivityName = "Coding";
                act.Add(a);
                return act;
                throw new Exception("Someren couldn't connect to the database");
            }

        }

        public Activity getActivityById(int id) => activitydb.getActiviyById(id);
        public List<Activity> getActivitiesWithParticipants() => activitydb.getAllActivitiesWithParticipants();
        public List<Activity> getActivitiesWithParticipantsById(int id) => activitydb.getActivitiesWithParticipantsById(id);
    }
}
