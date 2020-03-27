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
        public List<Sale> getAllSales()
        {
            string query = "SELECT *" +
                            "FROM Sales" +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public Sale getSaleById(int id)
        {
            string query = "SELECT * " +
                            "FROM Sales " +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName " +
                            $"WHERE Sale.OrderId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@id", id);

            return readTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Sale> getSalesByDateRange(DateTime startDateTime, DateTime endDateTime) {
            string startDateTimeString = startDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string endDateTimeString = endDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "SELECT * " +
                            "FROM Sales " +
                            "JOIN Drinks ON Sales.DrinkName = Drinks.DrinkName " +
                            $"WHERE OrderDateTime >= @startDateTimeString AND OrderDateTime <= @endDateTimeString;";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@startDateTimeString", startDateTimeString);
            sqlParameters[1] = new SqlParameter("@endDateTimeString", endDateTimeString);

            return readTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Sale> readTable(DataTable dataTable)
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

        public void Db_Save_New_Sale(string drink)
        {
            Random x = new Random();
            string query = ($"INSERT INTO Sales (OrderId, DrinkName, Revenue, OrderAmount, OrderDateTime) VALUES ({x.Next(0,999999)}, '{drink}', 1, 2.00, '20200326 19:00:00')");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
