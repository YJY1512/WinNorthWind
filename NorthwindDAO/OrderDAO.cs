using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using NorthwindDTO;

namespace NorthwindDAO
{
    public class OrderDAO : IDisposable
    {
        SqlConnection conn;

        public OrderDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
            //a뭐가 변경된거냐고
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ProductInfoDTO> GetProductAllList()
        {
            string sql = @"select ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsOnOrder
                            from Products";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ProductInfoDTO> list = Helper.DataReaderMapToList<ProductInfoDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
        }

        public bool AddOrder(OrderDTO order, List<OrderDetailDTO> cartList)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"insert into Orders(CustomerID,EmployeeID,OrderDate,RequiredDate) 
values (@CustomerID,@EmployeeID,getdate(),@RequiredDate);select @@IDENTITY";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                cmd.Parameters.AddWithValue("@EmployeeID", order.EmployeeID);
                cmd.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
                cmd.Transaction = trans;

                int newOrderID = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Parameters.Clear();
                cmd.CommandText = @"insert into [Order Details](OrderID, ProductID, UnitPrice, Quantity)
values (@OrderID, @ProductID, @UnitPrice, @Quantity)";
                cmd.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money));
                cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int));

                foreach(OrderDetailDTO item in cartList)
                {
                    cmd.Parameters["@OrderID"].Value = newOrderID;
                    cmd.Parameters["@ProductID"].Value = item.ProductID;
                    cmd.Parameters["@UnitPrice"].Value = item.UnitPrice;
                    cmd.Parameters["@Quantity"].Value = item.Quantity;

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<OrderDTO> GetOrderSearchList(string fromDt, string toDt, string custID, int empID)
        {
            StringBuilder sb = new StringBuilder();
            SqlCommand cmd = new SqlCommand();

            sb.Append(@"select OrderID, O.CustomerID, C.CompanyName,
                               O.EmployeeID, concat(FirstName, ' ', LastName) EmpName,
	                           convert(varchar(10), OrderDate, 23) OrderDate, 
	                           convert(varchar(10), RequiredDate, 23) RequiredDate, 
	                           convert(varchar(10), ShippedDate, 23) ShippedDate, 
	                           ShipVia, S.CompanyName ShipCompanyName, 
                               case when Freight = 0.00 then null else Freight end Freight
                        from Orders O inner join Customers C on O.CustomerID = C.CustomerID
                                      inner join Employees E on O.EmployeeID = E.EmployeeID
			                          left outer join Shippers S on O.ShipVia = S.ShipperID
                        where OrderDate >= @fromDt and OrderDate < @toDt ");
            
            cmd.Parameters.AddWithValue("@fromDt", fromDt);
            cmd.Parameters.AddWithValue("@toDt", toDt);

            if (!string.IsNullOrWhiteSpace(custID))
            {
                sb.Append(" and O.CustomerID = @custID");
                cmd.Parameters.AddWithValue("@custID", custID);
            }

            if (empID > 0)
            {
                sb.Append(" and O.EmployeeID = @empID");
                cmd.Parameters.AddWithValue("@empID", empID);
            }

            cmd.Connection = conn;
            cmd.CommandText = sb.ToString();

            conn.Open();
            List<OrderDTO> list = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<OrderDetailDTO> GetOrderDetail(int orderID)
        {
            string sql = @"select OrderID, od.ProductID, ProductName, CategoryName, od.UnitPrice, Quantity
from [Order Details] od inner join Products p on od.ProductID = p.ProductID
		inner join Categories c on p.CategoryID = c.CategoryID
where OrderID = @orderID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@orderID", orderID);

            conn.Open();
            List<OrderDetailDTO> list = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
        }

        public bool UpdateOrder(OrderDTO order)
        {
            string sql = @"update Orders set ShipVia = @ShipVia
	                                    , Freight = @Freight
	                                    , ShippedDate = @ShippedDate
                                    where OrderID = @OrderID";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ShipVia", order.ShipVia);
                cmd.Parameters.AddWithValue("@Freight", order.Freight);
                cmd.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool DeleteOrder(int orderID)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = "delete from [Order Details] where orderID = @OrderID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from Orders where OrderID = @OrderID";
                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch(Exception err)
            {                
                trans.Rollback();
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
