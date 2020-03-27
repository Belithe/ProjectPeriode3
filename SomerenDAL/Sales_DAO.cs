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
    public class Sales_DAO : Base
    {
        public List<Sale> Db_Get_All_Sales()
        {
            string query = "SELECT *" +
                            "FROM Sales" +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Sale Db_Get_Sale_By_Id(int id)
        {
            string query = "SELECT * " +
                            "FROM Sales " +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName " +
                            $"WHERE Sale.OrderId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Sale> Db_Get_Sale_By_Date_Range(DateTime startDateTime, DateTime endDateTime) {
            string startDateTimeString = startDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string endDateTimeString = endDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "SELECT * " +
                            "FROM Sales " +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName " +
                            $"WHERE OrderDateTime >= @startDateTimeString AND OrderDateTime <= @endDateTimeString;";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@startDateTimeString", startDateTimeString);
            sqlParameters[1] = new SqlParameter("@endDateTimeString", endDateTimeString);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Sale> ReadTables(DataTable dataTable)
        {
            Dictionary<int, Sale> salesMap = new Dictionary<int, Sale>();

            foreach (DataRow dataRow in dataTable.Rows) {
                int orderId = (int) dataRow["orderId"];

                if (!salesMap.ContainsKey(orderId)) {
                    salesMap[orderId] = new Sale() {
                        Id = orderId,
                        dateTime = (DateTime) dataRow["OrderDateTime"]
                    };
                }

                salesMap[orderId].addDrink(new DrinkSale() {
                    DrinkName = (string) dataRow["DrinkName"],
                    Price = (double) (decimal) dataRow["Price"],
                    IsAlcoholic = (bool) dataRow["IsAlcoholic"],
                    AmountInStock = (int) dataRow["AmountInStock"],
                    quantity = (int) dataRow["OrderAmount"],
                    revenue = (double) (decimal) dataRow["Revenue"]
                });
            }

            return salesMap.Values.ToList();
        }
    }
}
