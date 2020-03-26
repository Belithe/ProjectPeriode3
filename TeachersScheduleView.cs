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
        public TeachersScheduleView() {
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

        private void teachersComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (teachersComboBox.SelectedIndex == -1) return;

            Teacher teacher = (Teacher) teachersComboBox.SelectedItem;

            Console.WriteLine(teacher);
        }
    }
}
