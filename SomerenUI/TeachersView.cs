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
            listViewTeachers.Items.Clear();

            foreach (Teacher teacher in lecturerList) {
                ListViewItem item = new ListViewItem(teacher.Number.ToString());
                item.SubItems.Add(teacher.Name);

                listViewTeachers.Items.Add(item);
            }
        }
    }
}
