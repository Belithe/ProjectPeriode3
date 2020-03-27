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
using SomerenDAL;

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

        private void ListViewDrinks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < listViewDrinks.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    listViewDrinks.Items[i].Checked = false;
                }
            }
        }

        private void ListViewStudentsKassa_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < listViewStudentsKassa.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    listViewStudentsKassa.Items[i].Checked = false;
                }
            }
        }

        private void Btn_AddSale_Click(object sender, EventArgs e)
        {
            Sales_DAO salesquery = new Sales_DAO();
            string drink = "";
            string studentnr = "";

            for (int i = 0; i < listViewDrinks.Items.Count; i++)
            {
                if (listViewDrinks.Items[i].Checked)
                {
                    drink = listViewDrinks.Items[i].Text;
                }
            }

            for (int i = 0; i < listViewStudentsKassa.Items.Count; i++)
            {
                if (listViewStudentsKassa.Items[i].Checked)
                {
                    studentnr = listViewStudentsKassa.Items[i].Text;
                }
            }
            if (drink != "" & studentnr != "")
            {
                salesquery.Db_Save_New_Sale(drink);
            }

            refreshStudents();
            refreshDrinks();
        }



        //private void listViewStudentsKassa_ItemCheck(object sender, ItemCheckEventArgs e)
        //{

        //}
    }
}

