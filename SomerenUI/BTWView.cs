using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class BTWView : UserControl
    {
        public int quarterNr = 0;
        SomerenDAL.Sales_DAO daoSales = new SomerenDAL.Sales_DAO();
        public BTWView()
        {
            InitializeComponent();
        }

        private void quarterSelectList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < quarterSelectList.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    quarterSelectList.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < quarterSelectList.Items.Count; i++)
            {
                if (quarterSelectList.GetItemChecked(i))
                {
                    quarterNr = i + 1;
                } 

            }
            UpdateQuarterText(quarterNr);

        }

        private void UpdateQuarterText(int quarter)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();

            switch(quarter)
            {
                case (1): 
                    startDate = DateTime.Parse("1/1/2020");
                    endDate = DateTime.Parse("3/31/2020");
                    break;
                case (2):
                    startDate = DateTime.Parse("4/1/2020");
                    endDate = DateTime.Parse("6/30/2020");
                    break;
                case (3):
                    startDate = DateTime.Parse("7/1/2020");
                    endDate = DateTime.Parse("9/30/2020");
                    break;
                case (4):
                    startDate = DateTime.Parse("10/1/2020");
                    endDate = DateTime.Parse("12/31/2020");
                    break;
            }

            textBox1.Text = String.Format("Kwartaal {0} loopt van {1} tot en met {2}", quarter, startDate.ToShortDateString(), endDate.Date.ToShortDateString());
            CalculateBTW(startDate, endDate);
        }

        public void CalculateBTW(DateTime startDate, DateTime endDate)
        {
            List<SomerenModel.Sale> salesList = daoSales.Db_Get_Sale_By_Date_Range(startDate, endDate);

            double afdracht6 = 0;
            double afdracht21 = 0;


            foreach (SomerenModel.Sale sale in salesList)
            {
                foreach (SomerenModel.DrinkSale drink in sale.drinks)
                {
                    if (drink.IsAlcoholic)
                    {
                        afdracht21 += drink.totalRevenue * .21;
                    } else
                    {
                        afdracht6 += drink.totalRevenue * .6;
                    }
                }
            }

            afdracht6Box.Text = String.Format("Totale afdracht BTW laag tarief 6%: {0}", afdracht6.ToString("0.00"));
            afdracht21Box.Text = String.Format("Totale afdracht BTW laag tarief 21%: {0}", afdracht21.ToString("0.00"));

            totalAfdrachtBox.Text = String.Format("Totale afdracht BTW gecombineerd: {0}", (afdracht6 + afdracht21).ToString("0.00"));
        }


    }
}
