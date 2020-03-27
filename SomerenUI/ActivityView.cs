using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenDAL;
using SomerenModel;
using SomerenLogic;


namespace SomerenUI
{
    public partial class ActivityView : UserControl
    {
        public ActivityView()
        {
            InitializeComponent();
            Load_Activities();

        }

        public void Load_Activities()
        {
            Activity_DAO activity_dao = new Activity_DAO();
            List<Activity> activity_list = activity_dao.getAllActivities();

            activityListView.Items.Clear();

            foreach (Activity item in activity_list)
            {
                ListViewItem entry = new ListViewItem(item.ActivityId.ToString());

                entry.Tag = item;

                entry.SubItems.Add(item.ActivityName);
                entry.SubItems.Add(item.ActivityStartDate.ToString());
                entry.SubItems.Add(item.ActivityEndDate.ToString());

                activityListView.Items.Add(entry);


            }
        }

        private void ActivityListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < activityListView.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    activityListView.Items[i].Checked = false;
                    btndel.Enabled = false;
                    btnEdit.Enabled = false;

                }
            }

            btndel.Enabled = e.Index >= 0;
            btnEdit.Enabled = e.Index >= 0;
            tboxName.Text = activityListView.Items[e.Index].SubItems[1].Text;
            dateTimePickerStart.Text = activityListView.Items[e.Index].SubItems[2].Text;
            dateTimePickerEnd.Text = activityListView.Items[e.Index].SubItems[3].Text;
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            Activity_DAO activity_dao = new Activity_DAO();
            int activityDelId = 0;
            for (int i = 0; i < activityListView.Items.Count; i++)
            {
                if (activityListView.Items[i].Checked)
                {
                    activityDelId = int.Parse(activityListView.Items[i].Text);
                }
            }

            activity_dao.delActivityById(activityDelId);
            Load_Activities();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Activity_DAO activity_dao = new Activity_DAO();

            
            activity_dao.addNewActivity(tboxName.Text,dateTimePickerStart.Value, dateTimePickerEnd.Value);
            Load_Activities();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Activity_DAO activity_dao = new Activity_DAO();
            int activityUpId = 0;

            for (int i = 0; i < activityListView.Items.Count; i++)
            {
                if (activityListView.Items[i].Checked)
                {
                    activityUpId = int.Parse(activityListView.Items[i].Text);
                }
            }

            activity_dao.updateActivityById(activityUpId, tboxName.Text, dateTimePickerStart.Value, dateTimePickerEnd.Value);
            Load_Activities();
        }
    }
}
