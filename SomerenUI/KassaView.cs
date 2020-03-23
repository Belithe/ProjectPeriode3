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
    public partial class KassaView : UserControl
    {
        public KassaView()
        {
            InitializeComponent();
            refreshStudents();
            refreshDrinks();
        }


        public void refreshStudents()
        {
            // fill the students listview within the students panel with a list of students
            Student_Service studService = new Student_Service();
            List<Student> studentList = studService.GetStudents();

            // clear the listview before filling it again
            listViewStudentsKassa.Items.Clear();

            foreach (Student student in studentList)
            {
                ListViewItem item = new ListViewItem(student.Number.ToString());
                item.SubItems.Add(student.Name);

                listViewStudentsKassa.Items.Add(item);
            }
        }

        public void refreshDrinks()
        {
            // fill the students listview within the students panel with a list of students
            Drink_Service drinkService = new Drink_Service();
            List<Drink> drinkList = drinkService.GetDrinks();

            // clear the listview before filling it again
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinkList)
            {
                ListViewItem item = new ListViewItem(drink.DrinkName);
                listViewDrinks.Items.Add(item);
            }
        }
    }
}

