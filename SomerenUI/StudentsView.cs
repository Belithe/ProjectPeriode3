using SomerenLogic;
using SomerenModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI {
    public partial class StudentsView:UserControl {
        public StudentsView() {
            InitializeComponent();
            refreshStudents();
        }

        public void refreshStudents() {
            // fill the students listview within the students panel with a list of students
            Student_Service studService = new Student_Service();
            List<Student> studentList = studService.GetStudents();

            // clear the listview before filling it again
            listViewStudents.Clear();

            foreach (Student s in studentList) {
                ListViewItem li = new ListViewItem(s.Name);
                listViewStudents.Items.Add(li);
            }
        }
    }
}
