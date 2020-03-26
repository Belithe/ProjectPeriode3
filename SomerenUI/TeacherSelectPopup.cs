using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI {
    public partial class TeacherSelectPopup:Form {
        Dictionary<string, object> data;

        public TeacherSelectPopup(Dictionary<string, object> dataObject) {
            data = dataObject;
            InitializeComponent();
            refreshTeachers();
        }

        public void refreshTeachers() {
            Teacher_Services teacherServices = new Teacher_Services();

            List<Teacher> teachers = teacherServices.GetTeachers();

            teachersComboBox.Items.Clear();

            foreach (Teacher teacher in teachers) {
                teachersComboBox.Items.Add(teacher);
            }

            if (teachersComboBox.Items.Count > 0) {
                teachersComboBox.SelectedIndex = 0;
            }
        }

        private void btnConfirmSelection_Click(object sender, EventArgs e) {
            if (teachersComboBox.SelectedIndex < 0) {
                MessageBox.Show("Select a teacher to replace the participancy with");
                return;
            }

            data["selectedTeacher"] = (Teacher) teachersComboBox.SelectedItem;
            this.Close();
        }
    }
}
