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
    public class Drink_DAO : Base
    {
        public List<Drink> getAllDrinks()
        {
            string query = "SELECT * FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drink getDrinkByName(string name)
        {
            string query = $"SELECT * FROM Drinks WHERE DrinkName = @name";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@name", name);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Drink> readTable(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkName = (string) dr["DrinkName"],
                    Price = (double) (decimal) dr["Price"],
                    IsAlcoholic = (bool) dr["IsAlcoholic"],
                    AmountInStock = (int) dr["AmountInStock"],
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
