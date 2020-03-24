using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class WeekRoosterView : UserControl
    {
        public WeekRoosterView()
        {
            InitializeComponent();
            loadDataViews();
        }

        public void loadDataViews()
        {
            Activity_Service actService = new Activity_Service();
            List<Activity> activities = actService.GetActivities();

            Participant_Service prtService = new Participant_Service();
            List<Participant> participants = prtService.GetParticipants();

            DataGridView gridView = new DataGridView();

            foreach (Activity activity in activities)
            {
                switch(activity.ActivityStartDate.DayOfWeek)
                {
                    case (DayOfWeek.Monday):
                        gridView = gridViewMon;
                        break;
                    case (DayOfWeek.Tuesday):
                        gridView = gridViewTue;
                        break;
                    case (DayOfWeek.Wednesday):
                        gridView = gridViewWed;
                        break;
                    case (DayOfWeek.Thursday):
                        gridView = gridViewThu;
                        break;
                    case (DayOfWeek.Friday):
                        gridView = gridViewFri;
                        break;
                }

                int rowId = gridView.Rows.Add();

                DataGridViewRow row = gridView.Rows[rowId];

                row.Cells[0].Value = activity.ActivityName;

                string counsellorList = "";

                foreach (Participant participant in participants)
                {
                    if(participant.ActivityId == activity.ActivityId && participant.ParticipancyType == "CNS")
                    {
                        counsellorList += participant.UserId.ToString();
                        counsellorList += ", ";

                    }
                    
                }

                if (counsellorList == "")
                {
                    counsellorList = "Onbegeleid";
                } else {
                    counsellorList = counsellorList.Remove(counsellorList.Length - 2);
                }
                

                row.Cells[1].Value = counsellorList;

            }


        }
    }
}
