using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;


namespace SomerenDAL
{
    class Drink_DAO : Base
    {
        public List<Drink> Db_Get_All_Drinks()
        {
            string query = "SELECT DrinkName, Price, IsAlcoholic, AmmountInStock Name FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> Db_Get_Drink_By_Name(string name)
        {
            string query = $"SELECT DrinkName, Price, IsAlcoholic, AmmountInStock Name FROM Drinks WHERE DrinkName = {name}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink();
                {
                    drink.DrinkName = (string)dr["DrinkName"];
                    drink.Price = (int)dr["Price"];
                    drink.IsAlcoholic = (bool)dr["IsAlcoholic"];
                    drink.AmountInStock = (int)dr["AmountInStock"];
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
