using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic {
    public class Sales_Services {
        Sales_DAO sales_DAO = new Sales_DAO();

        public List<Sale> GetSales() => sales_DAO.Db_Get_All_Sales();
        public Sale getById(int id) => sales_DAO.Db_Get_Sale_By_Id(id);
        public List<Sale> getByDateRange(DateTime startDateTime, DateTime endDateTime) => sales_DAO.Db_Get_Sale_By_Date_Range(startDateTime, endDateTime);
    }
}
