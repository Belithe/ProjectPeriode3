using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Drink_Service
    {
        Drink_DAO drink_db = new Drink_DAO();

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drink_db.Db_Get_All_Drinks();
            return drinks;
        }
    }

}
