using SomerenLogic;
using SomerenModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI {
    public partial class TeachersView:UserControl {
        public TeachersView() {
            InitializeComponent();
            refreshTeachers();
        }

        public void refreshTeachers() {
            Teacher_Services lectService = new Teacher_Services();
            List<Teacher> lecturerList = lectService.GetTeachers();

            // clear the listview before filling it again
            listViewTeachers.Clear();

            foreach (SomerenModel.Teacher s in lecturerList) {

                ListViewItem li = new ListViewItem(s.Name);
                listViewTeachers.Items.Add(li);
            }
        }
    }
}
