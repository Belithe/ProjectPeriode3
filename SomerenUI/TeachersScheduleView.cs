using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI {
    public partial class TeachersScheduleView:UserControl {
        Participant selectedParticipant;

        public TeachersScheduleView() {
            InitializeComponent();
            refreshTeachers();
        }

        public void refreshTeachers() {
            Teacher_Services teacherServices = new Teacher_Services();

            List<Teacher> teachers = teacherServices.getTeachers();

            teachersComboBox.Items.Clear();

            foreach (Teacher teacher in teachers) {
                teachersComboBox.Items.Add(teacher);
            }

            if (teachersComboBox.Items.Count > 0) {
                teachersComboBox.SelectedIndex = 0;
            }
        }

        private void teachersComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (teachersComboBox.SelectedIndex == -1) return;

            Teacher teacher = (Teacher) teachersComboBox.SelectedItem;
            Participant_Service participant_Service = new Participant_Service();

            selectedParticipant = null;
            activitiesListView.Items.Clear();

            List<Participant> participantcies = participant_Service.getParticipantsWithActivityByUser(teacher);

            foreach (Participant participantcy in participantcies) {
                ListViewItem item = new ListViewItem(participantcy.ParticipatingActivity.ActivityName);
                item.SubItems.Add(participantcy.ParticipancyType == "CNS" ? "Counsellor" : "Participant");
                item.SubItems.Add(participantcy.ParticipatingActivity.ActivityStartDate.ToString("HH:mm dd-MM-yyyy"));

                item.Tag = participantcy;

                activitiesListView.Items.Add(item);
            }
        }

        private void activitiesListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (activitiesListView.SelectedItems.Count <= 0) {
                btnChangeCounsellor.Enabled = false;
                return;
            }

            ListViewItem item = activitiesListView.SelectedItems[0];
            Participant participant = (Participant) item.Tag;

            btnChangeCounsellor.Enabled = participant.ParticipancyType == "CNS";

            selectedParticipant = participant;
        }

        private void btnChangeCounsellor_Click(object sender, EventArgs e) {
            if (selectedParticipant == null) throw new Exception("Selected participant was null");

            Dictionary<string, object> dataTransferObject = new Dictionary<string, object>();

            // Show popup
            Form popup = new TeacherSelectPopup(dataTransferObject);
            popup.ShowDialog();

            // Checks whether or not the dialog has been force closed or by selecting a teacher
            if (dataTransferObject.ContainsKey("selectedTeacher")) {
                Teacher replacementTeacher = (Teacher) dataTransferObject["selectedTeacher"];

                Teacher_Services teacher_Services = new Teacher_Services();

                bool isAvailable = teacher_Services.isAvailableBetween(replacementTeacher, selectedParticipant.ParticipatingActivity.ActivityStartDate, selectedParticipant.ParticipatingActivity.ActivityEndDate);

                if (isAvailable) {
                    DialogResult result = MessageBox.Show($"Are you sure you want to replace the selected activity with {replacementTeacher}", "Confirm", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) {
                        Participant_Service participant_Service = new Participant_Service();

                        participant_Service.setNewUserAsParticipant(selectedParticipant, replacementTeacher);

                        MessageBox.Show("Changed have been made");

                        refreshTeachers();
                        teachersComboBox.SelectedIndex = -1;
                    }
                } else {
                    MessageBox.Show("Selected replacement teacher is not available when the activity takes place.");
                }
            }
        }
    }
}
