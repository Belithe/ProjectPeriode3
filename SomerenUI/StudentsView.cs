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
            List<Student> studentList = studService.getStudents();

            // clear the listview before filling it again
            listViewStudents.Items.Clear();

            foreach (Student student in studentList) {
                ListViewItem item = new ListViewItem(student.Number.ToString());
                item.SubItems.Add(student.Name);

                listViewStudents.Items.Add(item);
            }
        }

        private void StudentsView_Load(object sender, System.EventArgs e)
        {

        }
    }
}
