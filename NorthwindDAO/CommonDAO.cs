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
    public class CommonDAO : IDisposable
    {
        SqlConnection conn;

        public CommonDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ComboItemDTO> GetCodeByCategory(string[] category)
        {
            string search = "'" + string.Join("','", category) + "'";

            string sql = @"select Category, Code, Name 
                    from VW_NorthwindCode
                    where Category in (" + search + ")";
                        
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ComboItemDTO> list = Helper.DataReaderMapToList<ComboItemDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
        }
    }
}
